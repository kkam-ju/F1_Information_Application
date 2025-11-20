namespace WinFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn_mercedes = new Button();
            btn_bull = new Button();
            btn_ferrari = new Button();
            btn_redbull = new Button();
            btn_sauber = new Button();
            btn_aston = new Button();
            btn_alpin = new Button();
            btn_mclaren = new Button();
            btn_haas = new Button();
            btn_will = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_mercedes
            // 
            btn_mercedes.BackColor = Color.Transparent;
            btn_mercedes.BackgroundImage = (Image)resources.GetObject("btn_mercedes.BackgroundImage");
            btn_mercedes.BackgroundImageLayout = ImageLayout.Stretch;
            btn_mercedes.Location = new Point(12, 63);
            btn_mercedes.Name = "btn_mercedes";
            btn_mercedes.Size = new Size(123, 111);
            btn_mercedes.TabIndex = 0;
            btn_mercedes.UseVisualStyleBackColor = false;
            btn_mercedes.Click += btn_mercedes_Click;
            // 
            // btn_bull
            // 
            btn_bull.BackgroundImage = (Image)resources.GetObject("btn_bull.BackgroundImage");
            btn_bull.BackgroundImageLayout = ImageLayout.Stretch;
            btn_bull.Location = new Point(156, 196);
            btn_bull.Name = "btn_bull";
            btn_bull.Size = new Size(123, 112);
            btn_bull.TabIndex = 0;
            btn_bull.UseVisualStyleBackColor = true;
            btn_bull.Click += btn_bull_Click;
            // 
            // btn_ferrari
            // 
            btn_ferrari.BackColor = SystemColors.Control;
            btn_ferrari.BackgroundImage = (Image)resources.GetObject("btn_ferrari.BackgroundImage");
            btn_ferrari.BackgroundImageLayout = ImageLayout.Stretch;
            btn_ferrari.Location = new Point(156, 63);
            btn_ferrari.Name = "btn_ferrari";
            btn_ferrari.Size = new Size(123, 111);
            btn_ferrari.TabIndex = 0;
            btn_ferrari.UseVisualStyleBackColor = false;
            btn_ferrari.Click += btn_ferrari_Click;
            // 
            // btn_redbull
            // 
            btn_redbull.BackgroundImage = (Image)resources.GetObject("btn_redbull.BackgroundImage");
            btn_redbull.BackgroundImageLayout = ImageLayout.Stretch;
            btn_redbull.Location = new Point(299, 63);
            btn_redbull.Name = "btn_redbull";
            btn_redbull.Size = new Size(123, 111);
            btn_redbull.TabIndex = 0;
            btn_redbull.UseVisualStyleBackColor = true;
            btn_redbull.Click += btn_redbull_Click;
            // 
            // btn_sauber
            // 
            btn_sauber.BackgroundImage = (Image)resources.GetObject("btn_sauber.BackgroundImage");
            btn_sauber.BackgroundImageLayout = ImageLayout.Stretch;
            btn_sauber.Location = new Point(448, 63);
            btn_sauber.Name = "btn_sauber";
            btn_sauber.Size = new Size(123, 111);
            btn_sauber.TabIndex = 0;
            btn_sauber.UseVisualStyleBackColor = true;
            btn_sauber.Click += btn_sauber_Click;
            // 
            // btn_aston
            // 
            btn_aston.BackgroundImage = (Image)resources.GetObject("btn_aston.BackgroundImage");
            btn_aston.BackgroundImageLayout = ImageLayout.Stretch;
            btn_aston.Location = new Point(12, 196);
            btn_aston.Name = "btn_aston";
            btn_aston.Size = new Size(123, 112);
            btn_aston.TabIndex = 0;
            btn_aston.UseVisualStyleBackColor = true;
            btn_aston.Click += btn_aston_Click;
            // 
            // btn_alpin
            // 
            btn_alpin.BackgroundImage = (Image)resources.GetObject("btn_alpin.BackgroundImage");
            btn_alpin.BackgroundImageLayout = ImageLayout.Stretch;
            btn_alpin.Location = new Point(12, 331);
            btn_alpin.Name = "btn_alpin";
            btn_alpin.Size = new Size(123, 112);
            btn_alpin.TabIndex = 0;
            btn_alpin.UseVisualStyleBackColor = true;
            btn_alpin.Click += btn_alpin_Click;
            // 
            // btn_mclaren
            // 
            btn_mclaren.BackgroundImage = (Image)resources.GetObject("btn_mclaren.BackgroundImage");
            btn_mclaren.BackgroundImageLayout = ImageLayout.Stretch;
            btn_mclaren.Location = new Point(299, 197);
            btn_mclaren.Name = "btn_mclaren";
            btn_mclaren.Size = new Size(123, 111);
            btn_mclaren.TabIndex = 0;
            btn_mclaren.UseVisualStyleBackColor = true;
            btn_mclaren.Click += btn_mclaren_Click;
            // 
            // btn_haas
            // 
            btn_haas.BackgroundImage = (Image)resources.GetObject("btn_haas.BackgroundImage");
            btn_haas.BackgroundImageLayout = ImageLayout.Stretch;
            btn_haas.Location = new Point(299, 331);
            btn_haas.Name = "btn_haas";
            btn_haas.Size = new Size(123, 112);
            btn_haas.TabIndex = 0;
            btn_haas.UseVisualStyleBackColor = true;
            btn_haas.Click += btn_haas_Click;
            // 
            // btn_will
            // 
            btn_will.BackgroundImage = (Image)resources.GetObject("btn_will.BackgroundImage");
            btn_will.BackgroundImageLayout = ImageLayout.Stretch;
            btn_will.Location = new Point(156, 331);
            btn_will.Name = "btn_will";
            btn_will.Size = new Size(123, 112);
            btn_will.TabIndex = 0;
            btn_will.UseVisualStyleBackColor = true;
            btn_will.Click += btn_will_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe Script", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(299, 9);
            label1.Name = "label1";
            label1.Size = new Size(171, 38);
            label1.TabIndex = 1;
            label1.Text = "Select Team";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(867, 617);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(655, 63);
            button1.Name = "button1";
            button1.Size = new Size(165, 61);
            button1.TabIndex = 3;
            button1.Text = "초기화면으로";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 629);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(btn_will);
            Controls.Add(btn_haas);
            Controls.Add(btn_mclaren);
            Controls.Add(btn_alpin);
            Controls.Add(btn_aston);
            Controls.Add(btn_sauber);
            Controls.Add(btn_redbull);
            Controls.Add(btn_ferrari);
            Controls.Add(btn_bull);
            Controls.Add(btn_mercedes);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_mercedes;
        private Button btn_bull;
        private Button btn_ferrari;
        private Button btn_redbull;
        private Button btn_sauber;
        private Button btn_aston;
        private Button btn_alpin;
        private Button btn_mclaren;
        private Button btn_haas;
        private Button btn_will;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button1;
    }
}