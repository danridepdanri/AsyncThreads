namespace CryptoApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            inputTextBox = new TextBox();
            methodComboBox = new ComboBox();
            encryptedTextBox = new TextBox();
            Encrypt = new Button();
            SuspendLayout();
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(18, 20);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(755, 23);
            inputTextBox.TabIndex = 0;
            // 
            // methodComboBox
            // 
            methodComboBox.FormattingEnabled = true;
            methodComboBox.Items.AddRange(new object[] { "DES", "N-HASH", "RC4" });
            methodComboBox.Location = new Point(19, 64);
            methodComboBox.Name = "methodComboBox";
            methodComboBox.Size = new Size(121, 23);
            methodComboBox.TabIndex = 1;
            // 
            // encryptedTextBox
            // 
            encryptedTextBox.Location = new Point(12, 158);
            encryptedTextBox.Multiline = true;
            encryptedTextBox.Name = "encryptedTextBox";
            encryptedTextBox.Size = new Size(761, 121);
            encryptedTextBox.TabIndex = 2;
            // 
            // Encrypt
            // 
            Encrypt.Location = new Point(18, 310);
            Encrypt.Name = "Encrypt";
            Encrypt.Size = new Size(75, 23);
            Encrypt.TabIndex = 3;
            Encrypt.Text = "Encrypt";
            Encrypt.UseVisualStyleBackColor = true;
            Encrypt.Click += Encrypt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Encrypt);
            Controls.Add(encryptedTextBox);
            Controls.Add(methodComboBox);
            Controls.Add(inputTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputTextBox;
        private ComboBox methodComboBox;
        private TextBox encryptedTextBox;
        private Button Encrypt;
    }
}