﻿using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace noname_SanityArchiver
{
    internal class FileCryptor
    {
        private string filename;

        public FileCryptor(string filename)
        {
            this.filename = filename;
        }

        public string DecryptFile(string password, string decryptedName = null)
        {
            Regex filenameWithExtension = new Regex(@".+\.tnc", RegexOptions.IgnoreCase);
            if (!filenameWithExtension.Match(filename).Success)
            {
                return null;
            }
            if (decryptedName == null)
            {
                Regex cryptExtension = new Regex(@"\.tnc$");
                decryptedName = cryptExtension.Replace(filename, "");
            }
            byte[] key = ToKey(password);

            using (RijndaelManaged rijn = new RijndaelManaged())
            {
                rijn.Key = key;
                using (FileStream fsIn = new FileStream(filename, FileMode.Open))
                using (FileStream fsOut = new FileStream(decryptedName, FileMode.CreateNew))
                {
                    byte[] iv = new byte[16];
                    for (int i = 0; i < iv.Length; i++)
                    {
                        iv[i] = (byte)fsIn.ReadByte();
                    }

                    rijn.IV = iv;

                    ICryptoTransform decryptor = rijn.CreateDecryptor();

                    using (CryptoStream cs = new CryptoStream(fsOut, decryptor, CryptoStreamMode.Write))
                    {
                        int data;
                        while ((data = fsIn.ReadByte()) != -1)
                        {
                            cs.WriteByte((byte)data);
                        }
                        return decryptedName;
                    }
                }
            }
        }

        public void EncryptFile(string password, string encryptedName = null)
        {
            if (encryptedName == null)
            {
                encryptedName = filename + ".tnc";
            }
            byte[] key = ToKey(password);

            using (RijndaelManaged rijn = new RijndaelManaged())
            {
                rijn.GenerateIV();
                rijn.Key = key;
                try
                {
                    using (FileStream fsIn = new FileStream(filename, FileMode.Open))
                    using (FileStream fsOut = new FileStream(encryptedName, FileMode.CreateNew))
                    {
                        ICryptoTransform encryptor = rijn.CreateEncryptor();
                        using (CryptoStream cs = new CryptoStream(fsIn, encryptor, CryptoStreamMode.Read))
                        {
                            for (int i = 0; i < rijn.IV.Length; i++)
                            {
                                fsOut.WriteByte(rijn.IV[i]);
                            }

                            int data;
                            while ((data = cs.ReadByte()) != -1)
                            {
                                fsOut.WriteByte((byte)data);
                            }
                        }
                    }
                } catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        public static void EncryptMultiple(string[] paths, string location, string password, string encryptedName = null)
        {
            FileCompress comp = new FileCompress();
            comp.Compress(paths, location);
            FileCryptor cryptor = new FileCryptor(location);
            cryptor.EncryptFile(password, encryptedName);
            File.Delete(location);
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