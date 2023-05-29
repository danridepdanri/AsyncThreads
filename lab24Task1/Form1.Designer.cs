namespace lab24Task1
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
            panel1 = new Panel();
            panel2 = new Panel();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 217);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Location = new Point(263, 25);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 217);
            panel2.TabIndex = 1;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(510, 26);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(209, 216);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(16, 266);
            button1.Name = "button1";
            button1.Size = new Size(196, 23);
            button1.TabIndex = 3;
            button1.Text = "Запустить 1 поток";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(263, 266);
            button2.Name = "button2";
            button2.Size = new Size(196, 23);
            button2.TabIndex = 4;
            button2.Text = "Запустить 2 поток";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(510, 266);
            button3.Name = "button3";
            button3.Size = new Size(196, 23);
            button3.TabIndex = 5;
            button3.Text = "Запустить 3 поток";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(263, 372);
            button4.Name = "button4";
            button4.Size = new Size(196, 23);
            button4.TabIndex = 6;
            button4.Text = "Запустить все потоки";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(16, 295);
            button5.Name = "button5";
            button5.Size = new Size(196, 23);
            button5.TabIndex = 7;
            button5.Text = "Остановить 1 поток";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(263, 295);
            button6.Name = "button6";
            button6.Size = new Size(196, 23);
            button6.TabIndex = 8;
            button6.Text = "Остановить 2 поток";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(510, 295);
            button7.Name = "button7";
            button7.Size = new Size(196, 23);
            button7.TabIndex = 9;
            button7.Text = "Остановить 3 поток";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(263, 401);
            button8.Name = "button8";
            button8.Size = new Size(196, 23);
            button8.TabIndex = 10;
            button8.Text = "Остановить все потоки";
            button8.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private RichTextBox richTextBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}