namespace WinFormsApp1
{
    partial class Form_Ferrari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Ferrari));
            btn_TShirt = new Button();
            btn_Jacket = new Button();
            btn_WhiteTShirt = new Button();
            btn_Cap = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btn_Reset = new Button();
            btn_Complete = new Button();
            lbl_TotalPrice = new Label();
            lst_SelectedItems = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // btn_TShirt
            // 
            btn_TShirt.BackgroundImage = (Image)resources.GetObject("btn_TShirt.BackgroundImage");
            btn_TShirt.BackgroundImageLayout = ImageLayout.Stretch;
            btn_TShirt.Location = new Point(12, 12);
            btn_TShirt.Name = "btn_TShirt";
            btn_TShirt.Size = new Size(303, 283);
            btn_TShirt.TabIndex = 0;
            btn_TShirt.UseVisualStyleBackColor = true;
            btn_TShirt.Click += btn_TShirt_Click;
            // 
            // btn_Jacket
            // 
            btn_Jacket.BackgroundImage = (Image)resources.GetObject("btn_Jacket.BackgroundImage");
            btn_Jacket.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Jacket.Location = new Point(336, 12);
            btn_Jacket.Name = "btn_Jacket";
            btn_Jacket.Size = new Size(303, 283);
            btn_Jacket.TabIndex = 0;
            btn_Jacket.UseVisualStyleBackColor = true;
            btn_Jacket.Click += btn_Jacket_Click;
            // 
            // btn_WhiteTShirt
            // 
            btn_WhiteTShirt.BackgroundImage = (Image)resources.GetObject("btn_WhiteTShirt.BackgroundImage");
            btn_WhiteTShirt.BackgroundImageLayout = ImageLayout.Stretch;
            btn_WhiteTShirt.Location = new Point(12, 352);
            btn_WhiteTShirt.Name = "btn_WhiteTShirt";
            btn_WhiteTShirt.Size = new Size(303, 283);
            btn_WhiteTShirt.TabIndex = 0;
            btn_WhiteTShirt.UseVisualStyleBackColor = true;
            btn_WhiteTShirt.Click += btn_WhiteTShirt_Click;
            // 
            // btn_Cap
            // 
            btn_Cap.BackgroundImage = (Image)resources.GetObject("btn_Cap.BackgroundImage");
            btn_Cap.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Cap.Location = new Point(336, 352);
            btn_Cap.Name = "btn_Cap";
            btn_Cap.Size = new Size(303, 283);
            btn_Cap.TabIndex = 0;
            btn_Cap.UseVisualStyleBackColor = true;
            btn_Cap.Click += btn_Cap_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 297);
            label1.Name = "label1";
            label1.Size = new Size(104, 32);
            label1.TabIndex = 1;
            label1.Text = "100,000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(336, 297);
            label2.Name = "label2";
            label2.Size = new Size(104, 32);
            label2.TabIndex = 1;
            label2.Text = "200,000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 638);
            label3.Name = "label3";
            label3.Size = new Size(104, 32);
            label3.TabIndex = 1;
            label3.Text = "120,000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(336, 638);
            label4.Name = "label4";
            label4.Size = new Size(90, 32);
            label4.TabIndex = 1;
            label4.Text = "50,000";
            // 
            // btn_Reset
            // 
            btn_Reset.BackColor = Color.Transparent;
            btn_Reset.FlatStyle = FlatStyle.Flat;
            btn_Reset.Font = new Font("Arial", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            btn_Reset.Location = new Point(671, 349);
            btn_Reset.Name = "btn_Reset";
            btn_Reset.Size = new Size(155, 47);
            btn_Reset.TabIndex = 2;
            btn_Reset.Text = "초기화";
            btn_Reset.UseVisualStyleBackColor = false;
            btn_Reset.Click += btn_Reset_Click;
            // 
            // btn_Complete
            // 
            btn_Complete.BackColor = Color.Transparent;
            btn_Complete.FlatStyle = FlatStyle.Flat;
            btn_Complete.Font = new Font("Arial", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            btn_Complete.ForeColor = Color.Black;
            btn_Complete.Location = new Point(832, 349);
            btn_Complete.Name = "btn_Complete";
            btn_Complete.Size = new Size(155, 47);
            btn_Complete.TabIndex = 2;
            btn_Complete.Text = "결제 완료";
            btn_Complete.UseVisualStyleBackColor = false;
            btn_Complete.Click += btn_Complete_Click;
            // 
            // lbl_TotalPrice
            // 
            lbl_TotalPrice.AutoSize = true;
            lbl_TotalPrice.BackColor = Color.Transparent;
            lbl_TotalPrice.FlatStyle = FlatStyle.Flat;
            lbl_TotalPrice.Font = new Font("Segoe Script", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TotalPrice.ForeColor = Color.Black;
            lbl_TotalPrice.Location = new Point(671, 308);
            lbl_TotalPrice.Name = "lbl_TotalPrice";
            lbl_TotalPrice.Size = new Size(64, 31);
            lbl_TotalPrice.TabIndex = 4;
            lbl_TotalPrice.Text = "Total";
            // 
            // lst_SelectedItems
            // 
            lst_SelectedItems.BackColor = Color.Salmon;
            lst_SelectedItems.ForeColor = Color.Transparent;
            lst_SelectedItems.FormattingEnabled = true;
            lst_SelectedItems.ItemHeight = 15;
            lst_SelectedItems.Location = new Point(671, 12);
            lst_SelectedItems.Name = "lst_SelectedItems";
            lst_SelectedItems.Size = new Size(331, 274);
            lst_SelectedItems.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(743, 467);
            button1.Name = "button1";
            button1.Size = new Size(155, 48);
            button1.TabIndex = 6;
            button1.Text = "뒤로가기";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form_Ferrari
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(1014, 745);
            Controls.Add(lbl_TotalPrice);
            Controls.Add(button1);
            Controls.Add(lst_SelectedItems);
            Controls.Add(btn_Complete);
            Controls.Add(btn_Reset);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Cap);
            Controls.Add(btn_WhiteTShirt);
            Controls.Add(btn_Jacket);
            Controls.Add(btn_TShirt);
            Name = "Form_Ferrari";
            Text = "Form_Ferrari";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_TShirt;
        private Button btn_Jacket;
        private Button btn_WhiteTShirt;
        private Button btn_Cap;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_Cancel;
        private Button btn_Reset;
        private Button btn_Complete;
        private Label lbl_TotalPrice;
        private ListBox lst_SelectedItems;
        private Button button1;
    }
}