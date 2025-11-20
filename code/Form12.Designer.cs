namespace WinFormsApp1
{
    partial class Form12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            splitContainer1 = new SplitContainer();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(348, 0);
            button3.Name = "button3";
            button3.Size = new Size(280, 531);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe Script", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(7, 0);
            button1.Name = "button1";
            button1.Size = new Size(309, 531);
            button1.TabIndex = 1;
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Size = new Size(336, 528);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(-6, 1);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.White;
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(button1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.White;
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(button3);
            splitContainer1.Panel2.Controls.Add(button2);
            splitContainer1.Size = new Size(947, 614);
            splitContainer1.SplitterDistance = 315;
            splitContainer1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(10, 562);
            label1.Name = "label1";
            label1.Size = new Size(302, 23);
            label1.TabIndex = 2;
            label1.Text = "Race Schedule and Information";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(337, 562);
            label3.Name = "label3";
            label3.Size = new Size(291, 23);
            label3.TabIndex = 4;
            label3.Text = "Purchase Clothing and Goods";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(106, 562);
            label2.Name = "label2";
            label2.Size = new Size(119, 23);
            label2.TabIndex = 3;
            label2.Text = "Buy Tickets";
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 627);
            Controls.Add(splitContainer1);
            Name = "Form12";
            Text = "Form12";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button3;
        private Button button1;
        private Button button2;
        private SplitContainer splitContainer1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}