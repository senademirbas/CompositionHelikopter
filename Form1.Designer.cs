namespace NesneCompositions
{
    partial class FormHelikopter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelikopter));
            button1 = new Button();
            pictureBox1 = new PictureBox();
            richTextBox1 = new RichTextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(72, 104);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Çalıştır!";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(262, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(246, 205);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(26, 272);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(510, 153);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Location = new Point(72, 172);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Durdur";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // FormHelikopter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(richTextBox1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Name = "FormHelikopter";
            Text = "Helikopter Kontrol";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox1;
        private RichTextBox richTextBox1;
        private Button button2;
    }
}
