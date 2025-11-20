namespace WinFormsApp1
{
    partial class Form13
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form13));
            comboBox1 = new ComboBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            ckb_VVIP = new CheckBox();
            ckb_VIP = new CheckBox();
            ckb_Reserved = new CheckBox();
            ckb_Free = new CheckBox();
            label_vvip = new Label();
            label_vip = new Label();
            label_reserved = new Label();
            label_free = new Label();
            button1 = new Button();
            lb_Ticket = new Label();
            groupBox1 = new GroupBox();
            radioDisagree = new RadioButton();
            radioAgree = new RadioButton();
            label8 = new Label();
            btnEnter = new Button();
            cbPay = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            lbPayInfo = new ListBox();
            btnPay = new Button();
            button_pay = new Button();
            button_cancel = new Button();
            textBox2 = new TextBox();
            LblPay = new Label();
            btn_Return = new Button();
            btn_Return_login = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "R1.호주 그랑프리", "R2.중국 그랑프리", "R3.일본 그랑프리", "R4.바레인 그랑프리", "R5.사우디아라비아 그랑프리", "R6.미국 그랑프리", "R7.이탈리아 그랑프리", "R8.모나코 그랑프리", "R9.스페인 그랑프리", "R10.캐나다 그랑프리", "R11.오스트리아 그랑프리", "R12.영국 그랑프리", "R13.벨기에 그랑프리", "R14.헝가리그랑프리", "R15.네덜란드 그랑프리", "R16.이탈리아 그랑프리", "R17.아제르바이잔 그랑프리", "R18.싱가포르 그랑프리", "R19.미국 그랑프리", "R20.멕시코 그랑프리", "R21.브라질 그랑프리", "R22.미국 그랑프리", "R23.카타르 그랑프리", "R24.아부다비 그랑프리" });
            comboBox1.Location = new Point(620, 117);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(264, 23);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(620, 78);
            label1.Name = "label1";
            label1.Size = new Size(74, 21);
            label1.TabIndex = 1;
            label1.Text = "경기선택";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(591, 844);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe Script", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(834, 21);
            label2.Name = "label2";
            label2.Size = new Size(86, 33);
            label2.TabIndex = 3;
            label2.Text = "Ticket";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(620, 169);
            label3.Name = "label3";
            label3.Size = new Size(74, 21);
            label3.TabIndex = 4;
            label3.Text = "좌석선택";
            // 
            // ckb_VVIP
            // 
            ckb_VVIP.AutoSize = true;
            ckb_VVIP.BackColor = Color.Red;
            ckb_VVIP.Location = new Point(620, 211);
            ckb_VVIP.Name = "ckb_VVIP";
            ckb_VVIP.Size = new Size(64, 19);
            ckb_VVIP.TabIndex = 5;
            ckb_VVIP.Text = "VVIP석";
            ckb_VVIP.UseVisualStyleBackColor = false;
            ckb_VVIP.CheckedChanged += ckb_VVIP_CheckedChanged;
            // 
            // ckb_VIP
            // 
            ckb_VIP.AutoSize = true;
            ckb_VIP.BackColor = Color.FromArgb(192, 64, 0);
            ckb_VIP.Location = new Point(620, 247);
            ckb_VIP.Name = "ckb_VIP";
            ckb_VIP.Size = new Size(56, 19);
            ckb_VIP.TabIndex = 5;
            ckb_VIP.Text = "VIP석";
            ckb_VIP.UseVisualStyleBackColor = false;
            ckb_VIP.CheckedChanged += ckb_VIP_CheckedChanged;
            // 
            // ckb_Reserved
            // 
            ckb_Reserved.AutoSize = true;
            ckb_Reserved.BackColor = Color.FromArgb(0, 192, 0);
            ckb_Reserved.Location = new Point(795, 208);
            ckb_Reserved.Name = "ckb_Reserved";
            ckb_Reserved.Size = new Size(62, 19);
            ckb_Reserved.TabIndex = 5;
            ckb_Reserved.Text = "지정석";
            ckb_Reserved.UseVisualStyleBackColor = false;
            ckb_Reserved.CheckedChanged += ckb_Reserved_CheckedChanged;
            // 
            // ckb_Free
            // 
            ckb_Free.AutoSize = true;
            ckb_Free.BackColor = Color.FromArgb(128, 128, 255);
            ckb_Free.Location = new Point(795, 248);
            ckb_Free.Name = "ckb_Free";
            ckb_Free.Size = new Size(62, 19);
            ckb_Free.TabIndex = 5;
            ckb_Free.Text = "자유석";
            ckb_Free.UseVisualStyleBackColor = false;
            ckb_Free.CheckedChanged += ckb_Free_CheckedChanged;
            // 
            // label_vvip
            // 
            label_vvip.AutoSize = true;
            label_vvip.Location = new Point(708, 212);
            label_vvip.Name = "label_vvip";
            label_vvip.Size = new Size(49, 15);
            label_vvip.TabIndex = 6;
            label_vvip.Text = "500000";
            // 
            // label_vip
            // 
            label_vip.AutoSize = true;
            label_vip.Location = new Point(708, 248);
            label_vip.Name = "label_vip";
            label_vip.Size = new Size(49, 15);
            label_vip.TabIndex = 6;
            label_vip.Text = "300000";
            // 
            // label_reserved
            // 
            label_reserved.AutoSize = true;
            label_reserved.Location = new Point(875, 209);
            label_reserved.Name = "label_reserved";
            label_reserved.Size = new Size(49, 15);
            label_reserved.TabIndex = 6;
            label_reserved.Text = "100000";
            // 
            // label_free
            // 
            label_free.AutoSize = true;
            label_free.Location = new Point(875, 247);
            label_free.Name = "label_free";
            label_free.Size = new Size(42, 15);
            label_free.TabIndex = 6;
            label_free.Text = "50000";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(973, 78);
            button1.Name = "button1";
            button1.Size = new Size(102, 34);
            button1.TabIndex = 7;
            button1.Text = "좌석선택 확인";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lb_Ticket
            // 
            lb_Ticket.AutoSize = true;
            lb_Ticket.Location = new Point(973, 139);
            lb_Ticket.Name = "lb_Ticket";
            lb_Ticket.Size = new Size(83, 15);
            lb_Ticket.TabIndex = 8;
            lb_Ticket.Text = "좌석선택 내역";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioDisagree);
            groupBox1.Controls.Add(radioAgree);
            groupBox1.Location = new Point(620, 640);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "포인트 적립";
            // 
            // radioDisagree
            // 
            radioDisagree.AutoSize = true;
            radioDisagree.Location = new Point(99, 45);
            radioDisagree.Name = "radioDisagree";
            radioDisagree.Size = new Size(77, 19);
            radioDisagree.TabIndex = 0;
            radioDisagree.TabStop = true;
            radioDisagree.Text = "적립 안함";
            radioDisagree.UseVisualStyleBackColor = true;
            // 
            // radioAgree
            // 
            radioAgree.AutoSize = true;
            radioAgree.Location = new Point(7, 45);
            radioAgree.Name = "radioAgree";
            radioAgree.Size = new Size(49, 19);
            radioAgree.TabIndex = 0;
            radioAgree.TabStop = true;
            radioAgree.Text = "적립";
            radioAgree.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(620, 595);
            label8.Name = "label8";
            label8.Size = new Size(134, 21);
            label8.TabIndex = 10;
            label8.Text = "포인트 적립 여부";
            // 
            // btnEnter
            // 
            btnEnter.FlatStyle = FlatStyle.Flat;
            btnEnter.Location = new Point(875, 654);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(106, 38);
            btnEnter.TabIndex = 11;
            btnEnter.Text = "확인";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // cbPay
            // 
            cbPay.FormattingEnabled = true;
            cbPay.Items.AddRange(new object[] { "신용카드", "무통장 입금", "포인트" });
            cbPay.Location = new Point(620, 462);
            cbPay.Name = "cbPay";
            cbPay.Size = new Size(121, 23);
            cbPay.TabIndex = 12;
            cbPay.SelectedIndexChanged += cbPay_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(620, 423);
            label9.Name = "label9";
            label9.Size = new Size(74, 21);
            label9.TabIndex = 13;
            label9.Text = "결제수단";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(771, 423);
            label10.Name = "label10";
            label10.Size = new Size(74, 21);
            label10.TabIndex = 13;
            label10.Text = "결제정보";
            // 
            // lbPayInfo
            // 
            lbPayInfo.FormattingEnabled = true;
            lbPayInfo.ItemHeight = 15;
            lbPayInfo.Location = new Point(771, 462);
            lbPayInfo.Name = "lbPayInfo";
            lbPayInfo.Size = new Size(120, 94);
            lbPayInfo.TabIndex = 14;
            // 
            // btnPay
            // 
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPay.Location = new Point(956, 462);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(100, 52);
            btnPay.TabIndex = 15;
            btnPay.Text = "결제";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // button_pay
            // 
            button_pay.Location = new Point(694, 301);
            button_pay.Name = "button_pay";
            button_pay.Size = new Size(75, 23);
            button_pay.TabIndex = 16;
            button_pay.Text = "구매하기";
            button_pay.UseVisualStyleBackColor = true;
            button_pay.Click += button_pay_Click;
            // 
            // button_cancel
            // 
            button_cancel.Location = new Point(809, 301);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(75, 23);
            button_cancel.TabIndex = 16;
            button_cancel.Text = "구매취소";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.Click += button_cancel_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(739, 348);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(190, 23);
            textBox2.TabIndex = 17;
            // 
            // LblPay
            // 
            LblPay.AutoSize = true;
            LblPay.Location = new Point(635, 351);
            LblPay.Name = "LblPay";
            LblPay.Size = new Size(75, 15);
            LblPay.TabIndex = 18;
            LblPay.Text = "총 결제 금액";
            // 
            // btn_Return
            // 
            btn_Return.BackColor = Color.IndianRed;
            btn_Return.FlatAppearance.BorderSize = 0;
            btn_Return.FlatStyle = FlatStyle.Flat;
            btn_Return.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Return.Location = new Point(695, 793);
            btn_Return.Name = "btn_Return";
            btn_Return.Size = new Size(162, 72);
            btn_Return.TabIndex = 19;
            btn_Return.Text = "초기화면으로";
            btn_Return.UseVisualStyleBackColor = false;
            btn_Return.Click += btn_Return_Click;
            // 
            // btn_Return_login
            // 
            btn_Return_login.BackColor = Color.MediumAquamarine;
            btn_Return_login.FlatAppearance.BorderSize = 0;
            btn_Return_login.FlatStyle = FlatStyle.Flat;
            btn_Return_login.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Return_login.Location = new Point(895, 793);
            btn_Return_login.Name = "btn_Return_login";
            btn_Return_login.Size = new Size(161, 72);
            btn_Return_login.TabIndex = 20;
            btn_Return_login.Text = "로그인 화면으로";
            btn_Return_login.UseVisualStyleBackColor = false;
            btn_Return_login.Click += btn_Return_login_Click;
            // 
            // Form13
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1126, 987);
            Controls.Add(btn_Return_login);
            Controls.Add(btn_Return);
            Controls.Add(LblPay);
            Controls.Add(textBox2);
            Controls.Add(button_cancel);
            Controls.Add(button_pay);
            Controls.Add(btnPay);
            Controls.Add(lbPayInfo);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(cbPay);
            Controls.Add(btnEnter);
            Controls.Add(label8);
            Controls.Add(groupBox1);
            Controls.Add(lb_Ticket);
            Controls.Add(button1);
            Controls.Add(label_free);
            Controls.Add(label_reserved);
            Controls.Add(label_vip);
            Controls.Add(label_vvip);
            Controls.Add(ckb_Free);
            Controls.Add(ckb_Reserved);
            Controls.Add(ckb_VIP);
            Controls.Add(ckb_VVIP);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ControlText;
            Name = "Form13";
            Text = "Form13";
            Load += Form13_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private CheckBox ckb_VVIP;
        private CheckBox ckb_VIP;
        private CheckBox ckb_Reserved;
        private CheckBox ckb_Free;
        private Label label_vvip;
        private Label label_vip;
        private Label label_reserved;
        private Label label_free;
        private Button button1;
        private Label lb_Ticket;
        private GroupBox groupBox1;
        private Label label8;
        private RadioButton radioDisagree;
        private RadioButton radioAgree;
        private Button btnEnter;
        private ComboBox cbPay;
        private Label label9;
        private Label label10;
        private ListBox lbPayInfo;
        private Button btnPay;
        private Button button_pay;
        private Button button_cancel;
        private TextBox textBox2;
        private Label LblPay;
        private Button btn_Return;
        private Button btn_Return_login;
    }
}