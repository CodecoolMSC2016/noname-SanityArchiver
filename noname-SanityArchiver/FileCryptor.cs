using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace noname_SanityArchiver
{
    internal class FileCryptor
    {
        private string decryptedName;
        private string encryptedName;

        /*
         * usage:
         *   FileCryptor asd = new FileCryptor(@"C:\TEST\asd.txt", @"C:\TEST\lol.txt");
         *   byte[] iv = asd.EncryptFile(@"pass");
         *
         *   FileCryptor dsa = new FileCryptor(@"C:\TEST\dsa.txt", @"C:\TEST\lol.txt");
         *   dsa.DecryptFile(@"pass", iv);
         */

        public FileCryptor(string deName, string enName)
        {
            decryptedName = deName;
            encryptedName = enName;
        }

        public void DecryptFile(string password, byte[] iv)
        {
            byte[] key = ToKey(password);

            using (RijndaelManaged rijn = new RijndaelManaged())
            {
                rijn.IV = iv;
                rijn.Key = key;
                using (FileStream fsIn = new FileStream(encryptedName, FileMode.Open))
                using (FileStream fsOut = new FileStream(decryptedName, FileMode.Create))
                {
                    ICryptoTransform decryptor = rijn.CreateDecryptor();
                    CryptoStream cs = new CryptoStream(fsIn, decryptor, CryptoStreamMode.Read);

                    int data;
                    while ((data = cs.ReadByte()) != -1)
                    {
                        fsOut.WriteByte((byte)data);
                    }
                }
            }
        }

        public byte[] EncryptFile(string password)
        {
            byte[] key = ToKey(password);

            using (RijndaelManaged rijn = new RijndaelManaged())
            {
                // TODO: change this
                //rijn.GenerateIV();
                rijn.IV = new byte[16];
                rijn.Key = key;
                using (FileStream fsIn = new FileStream(decryptedName, FileMode.Open))
                using (FileStream fsOut = new FileStream(encryptedName, FileMode.Create))
                {
                    ICryptoTransform encryptor = rijn.CreateEncryptor();
                    CryptoStream cs = new CryptoStream(fsIn, encryptor, CryptoStreamMode.Read);

                    int data;
                    while ((data = cs.ReadByte()) != -1)
                    {
                        fsOut.WriteByte((byte)data);
                    }
                }
                return rijn.IV;
            }
        }

        private byte[] ToKey(string pass)
        {
            byte[] key = new byte[32];
            byte[] bytePass = new UnicodeEncoding().GetBytes(pass);
            Array.Copy(bytePass, 0, key, 0, Math.Min(key.Length, bytePass.Length));
            return key;
        }
    }
}