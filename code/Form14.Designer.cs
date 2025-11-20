namespace WinFormsApp1
{
    partial class Form14
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form14));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(701, 615);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 21.75F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(780, 132);
            label1.Name = "label1";
            label1.Size = new Size(116, 46);
            label1.TabIndex = 1;
            label1.Text = "Ticket";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(817, 249);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(817, 306);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(763, 249);
            label2.Name = "label2";
            label2.Size = new Size(27, 21);
            label2.TabIndex = 3;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(763, 308);
            label3.Name = "label3";
            label3.Size = new Size(36, 21);
            label3.TabIndex = 3;
            label3.Text = "PW";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Constantia", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(780, 178);
            label4.Name = "label4";
            label4.Size = new Size(118, 33);
            label4.TabIndex = 4;
            label4.Text = "LOG_IN";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(780, 373);
            button1.Name = "button1";
            button1.Size = new Size(118, 44);
            button1.TabIndex = 5;
            button1.Text = "로그인";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(780, 444);
            button2.Name = "button2";
            button2.Size = new Size(118, 53);
            button2.TabIndex = 6;
            button2.Text = "초기화면으로";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form14
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1003, 639);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form14";
            Text = "Form14";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
    }
}