namespace noname_SanityArchiver
{
    partial class changeAttribute
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxReadOnly = new System.Windows.Forms.CheckBox();
            this.checkBoxHidden = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBoxReadOnly
            // 
            this.checkBoxReadOnly.AutoSize = true;
            this.checkBoxReadOnly.Location = new System.Drawing.Point(12, 12);
            this.checkBoxReadOnly.Name = "checkBoxReadOnly";
            this.checkBoxReadOnly.Size = new System.Drawing.Size(76, 17);
            this.checkBoxReadOnly.TabIndex = 0;
            this.checkBoxReadOnly.Text = "Read Only";
            this.checkBoxReadOnly.UseVisualStyleBackColor = true;
            // 
            // checkBoxHidden
            // 
            this.checkBoxHidden.AutoSize = true;
            this.checkBoxHidden.Location = new System.Drawing.Point(12, 35);
            this.checkBoxHidden.Name = "checkBoxHidden";
            this.checkBoxHidden.Size = new System.Drawing.Size(60, 17);
            this.checkBoxHidden.TabIndex = 1;
            this.checkBoxHidden.Text = "Hidden";
            this.checkBoxHidden.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(211, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // changeAttribute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 93);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxHidden);
            this.Controls.Add(this.checkBoxReadOnly);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "changeAttribute";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change File Attribute";
            this.Load += new System.EventHandler(this.changeAttribute_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxReadOnly;
        private System.Windows.Forms.CheckBox checkBoxHidden;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}