namespace WinFormsApp1
{
    partial class Form11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            tb_Site = new TabControl();
            tb_Result = new TabPage();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            listView1 = new ListView();
            chNumber = new ColumnHeader();
            chGrang = new ColumnHeader();
            chDate = new ColumnHeader();
            chWinner = new ColumnHeader();
            chTeam = new ColumnHeader();
            tb_Team = new TabPage();
            btn_Alpine = new Button();
            btn_Redbull = new Button();
            btn_Bulls = new Button();
            btn_Sauber = new Button();
            btn_Haas = new Button();
            btn_Williams = new Button();
            btn_Aston = new Button();
            btn_Mercedes = new Button();
            btn_Ferrari = new Button();
            btn_Mclaren = new Button();
            pictureBox13 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox14 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            tb_Site.SuspendLayout();
            tb_Result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tb_Team.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            SuspendLayout();
            // 
            // tb_Site
            // 
            tb_Site.Controls.Add(tb_Result);
            tb_Site.Controls.Add(tb_Team);
            tb_Site.Location = new Point(12, 12);
            tb_Site.Name = "tb_Site";
            tb_Site.SelectedIndex = 0;
            tb_Site.Size = new Size(1110, 1037);
            tb_Site.TabIndex = 0;
            // 
            // tb_Result
            // 
            tb_Result.Controls.Add(pictureBox2);
            tb_Result.Controls.Add(pictureBox1);
            tb_Result.Controls.Add(listView1);
            tb_Result.Location = new Point(4, 24);
            tb_Result.Name = "tb_Result";
            tb_Result.Padding = new Padding(3);
            tb_Result.Size = new Size(1102, 1009);
            tb_Result.TabIndex = 5;
            tb_Result.Text = "2025 경기 일정/결과";
            tb_Result.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(762, 250);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(336, 355);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(762, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(336, 238);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            listView1.BackColor = Color.Lavender;
            listView1.Columns.AddRange(new ColumnHeader[] { chNumber, chGrang, chDate, chWinner, chTeam });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(3, 3);
            listView1.Name = "listView1";
            listView1.Size = new Size(753, 599);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // chNumber
            // 
            chNumber.Text = "No";
            chNumber.Width = 150;
            // 
            // chGrang
            // 
            chGrang.Text = "그랑프리";
            chGrang.Width = 150;
            // 
            // chDate
            // 
            chDate.Text = "날짜";
            chDate.Width = 150;
            // 
            // chWinner
            // 
            chWinner.Text = "우승자";
            chWinner.Width = 150;
            // 
            // chTeam
            // 
            chTeam.Text = "우승팀";
            chTeam.Width = 150;
            // 
            // tb_Team
            // 
            tb_Team.Controls.Add(btn_Alpine);
            tb_Team.Controls.Add(btn_Redbull);
            tb_Team.Controls.Add(btn_Bulls);
            tb_Team.Controls.Add(btn_Sauber);
            tb_Team.Controls.Add(btn_Haas);
            tb_Team.Controls.Add(btn_Williams);
            tb_Team.Controls.Add(btn_Aston);
            tb_Team.Controls.Add(btn_Mercedes);
            tb_Team.Controls.Add(btn_Ferrari);
            tb_Team.Controls.Add(btn_Mclaren);
            tb_Team.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Team.Location = new Point(4, 24);
            tb_Team.Name = "tb_Team";
            tb_Team.Padding = new Padding(3);
            tb_Team.Size = new Size(1102, 1009);
            tb_Team.TabIndex = 1;
            tb_Team.Text = "Team";
            tb_Team.UseVisualStyleBackColor = true;
            // 
            // btn_Alpine
            // 
            btn_Alpine.BackgroundImage = (Image)resources.GetObject("btn_Alpine.BackgroundImage");
            btn_Alpine.Location = new Point(739, 231);
            btn_Alpine.Name = "btn_Alpine";
            btn_Alpine.Size = new Size(357, 201);
            btn_Alpine.TabIndex = 0;
            btn_Alpine.UseVisualStyleBackColor = true;
            btn_Alpine.Click += btn_Alpine_Click;
            // 
            // btn_Redbull
            // 
            btn_Redbull.BackgroundImage = (Image)resources.GetObject("btn_Redbull.BackgroundImage");
            btn_Redbull.Location = new Point(385, 231);
            btn_Redbull.Name = "btn_Redbull";
            btn_Redbull.Size = new Size(348, 201);
            btn_Redbull.TabIndex = 0;
            btn_Redbull.UseVisualStyleBackColor = true;
            btn_Redbull.Click += btn_Redbull_Click;
            // 
            // btn_Bulls
            // 
            btn_Bulls.BackgroundImage = (Image)resources.GetObject("btn_Bulls.BackgroundImage");
            btn_Bulls.Location = new Point(6, 674);
            btn_Bulls.Name = "btn_Bulls";
            btn_Bulls.Size = new Size(373, 201);
            btn_Bulls.TabIndex = 0;
            btn_Bulls.UseVisualStyleBackColor = true;
            btn_Bulls.Click += btn_Bulls_Click;
            // 
            // btn_Sauber
            // 
            btn_Sauber.BackgroundImage = (Image)resources.GetObject("btn_Sauber.BackgroundImage");
            btn_Sauber.Location = new Point(385, 439);
            btn_Sauber.Name = "btn_Sauber";
            btn_Sauber.Size = new Size(348, 220);
            btn_Sauber.TabIndex = 0;
            btn_Sauber.UseVisualStyleBackColor = true;
            btn_Sauber.Click += btn_Sauber_Click;
            // 
            // btn_Haas
            // 
            btn_Haas.BackgroundImage = (Image)resources.GetObject("btn_Haas.BackgroundImage");
            btn_Haas.Location = new Point(739, 439);
            btn_Haas.Name = "btn_Haas";
            btn_Haas.Size = new Size(357, 220);
            btn_Haas.TabIndex = 0;
            btn_Haas.UseVisualStyleBackColor = true;
            btn_Haas.Click += btn_Haas_Click;
            // 
            // btn_Williams
            // 
            btn_Williams.BackgroundImage = (Image)resources.GetObject("btn_Williams.BackgroundImage");
            btn_Williams.Location = new Point(6, 439);
            btn_Williams.Name = "btn_Williams";
            btn_Williams.Size = new Size(373, 220);
            btn_Williams.TabIndex = 0;
            btn_Williams.UseVisualStyleBackColor = true;
            btn_Williams.Click += btn_Williams_Click;
            // 
            // btn_Aston
            // 
            btn_Aston.BackgroundImage = (Image)resources.GetObject("btn_Aston.BackgroundImage");
            btn_Aston.Location = new Point(6, 231);
            btn_Aston.Name = "btn_Aston";
            btn_Aston.Size = new Size(373, 201);
            btn_Aston.TabIndex = 0;
            btn_Aston.UseVisualStyleBackColor = true;
            btn_Aston.Click += btn_Aston_Click;
            // 
            // btn_Mercedes
            // 
            btn_Mercedes.BackgroundImage = (Image)resources.GetObject("btn_Mercedes.BackgroundImage");
            btn_Mercedes.Location = new Point(739, 6);
            btn_Mercedes.Name = "btn_Mercedes";
            btn_Mercedes.Size = new Size(357, 219);
            btn_Mercedes.TabIndex = 0;
            btn_Mercedes.UseVisualStyleBackColor = true;
            btn_Mercedes.Click += btn_Mercedes_Click;
            // 
            // btn_Ferrari
            // 
            btn_Ferrari.BackgroundImage = (Image)resources.GetObject("btn_Ferrari.BackgroundImage");
            btn_Ferrari.Location = new Point(385, 3);
            btn_Ferrari.Name = "btn_Ferrari";
            btn_Ferrari.Size = new Size(348, 222);
            btn_Ferrari.TabIndex = 0;
            btn_Ferrari.UseVisualStyleBackColor = true;
            btn_Ferrari.Click += btn_Ferrari_Click;
            // 
            // btn_Mclaren
            // 
            btn_Mclaren.BackgroundImage = (Image)resources.GetObject("btn_Mclaren.BackgroundImage");
            btn_Mclaren.Location = new Point(3, 3);
            btn_Mclaren.Name = "btn_Mclaren";
            btn_Mclaren.Size = new Size(376, 222);
            btn_Mclaren.TabIndex = 0;
            btn_Mclaren.UseVisualStyleBackColor = true;
            btn_Mclaren.Click += btn_Mclaren_Click;
            // 
            // pictureBox13
            // 
            pictureBox13.Location = new Point(1146, 36);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(412, 302);
            pictureBox13.TabIndex = 1;
            pictureBox13.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(1146, 365);
            label1.Name = "label1";
            label1.Size = new Size(42, 21);
            label1.TabIndex = 2;
            label1.Text = "이름";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1146, 401);
            label2.Name = "label2";
            label2.Size = new Size(42, 21);
            label2.TabIndex = 2;
            label2.Text = "국적";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(1146, 431);
            label3.Name = "label3";
            label3.Size = new Size(150, 21);
            label3.TabIndex = 2;
            label3.Text = "월드 챔피언십 횟수";
            // 
            // pictureBox14
            // 
            pictureBox14.Location = new Point(1146, 475);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(412, 302);
            pictureBox14.TabIndex = 1;
            pictureBox14.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(1146, 804);
            label4.Name = "label4";
            label4.Size = new Size(42, 21);
            label4.TabIndex = 2;
            label4.Text = "이름";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(1146, 840);
            label5.Name = "label5";
            label5.Size = new Size(42, 21);
            label5.TabIndex = 2;
            label5.Text = "국적";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(1146, 870);
            label6.Name = "label6";
            label6.Size = new Size(150, 21);
            label6.TabIndex = 2;
            label6.Text = "월드 챔피언십 횟수";
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(1388, 904);
            button1.Name = "button1";
            button1.Size = new Size(170, 50);
            button1.TabIndex = 3;
            button1.Text = "초기화면으로";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form11
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1581, 1061);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(pictureBox14);
            Controls.Add(pictureBox13);
            Controls.Add(tb_Site);
            Name = "Form11";
            Text = "Form11";
            tb_Site.ResumeLayout(false);
            tb_Result.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tb_Team.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tb_Site;
        private TabPage tb_Team;
        private TabPage tb_Result;
        private ListView listView1;
        private ColumnHeader chNumber;
        private ColumnHeader chGrang;
        private ColumnHeader chDate;
        private ColumnHeader chWinner;
        private ColumnHeader chTeam;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox8;
        private Button btn_Alpine;
        private PictureBox pictureBox7;
        private Button btn_Redbull;
        private PictureBox pictureBox6;
        private Button btn_Aston;
        private Button btn_Mercedes;
        private Button btn_Ferrari;
        private Button btn_Mclaren;
        private PictureBox pictureBox12;
        private Button btn_Bulls;
        private PictureBox pictureBox11;
        private Button btn_Sauber;
        private PictureBox pictureBox10;
        private Button btn_Haas;
        private PictureBox pictureBox9;
        private Button btn_Williams;
        private PictureBox pictureBox13;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox14;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
    }
}