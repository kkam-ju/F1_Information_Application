namespace WinFormsApp1
{
    partial class Form_will
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_will));
            btn_TShirt = new Button();
            btn_Jacket = new Button();
            btn_WhiteTShirt = new Button();
            btn_Cap = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lst_SelectedItems = new ListBox();
            btn_Reset = new Button();
            btn_Complete = new Button();
            button7 = new Button();
            lbl_TotalPrice = new Label();
            SuspendLayout();
            // 
            // btn_TShirt
            // 
            btn_TShirt.BackgroundImage = (Image)resources.GetObject("btn_TShirt.BackgroundImage");
            btn_TShirt.BackgroundImageLayout = ImageLayout.Stretch;
            btn_TShirt.Location = new Point(7, 8);
            btn_TShirt.Name = "btn_TShirt";
            btn_TShirt.Size = new Size(347, 289);
            btn_TShirt.TabIndex = 0;
            btn_TShirt.UseVisualStyleBackColor = true;
            btn_TShirt.Click += btn_TShirt_Click;
            // 
            // btn_Jacket
            // 
            btn_Jacket.BackgroundImage = (Image)resources.GetObject("btn_Jacket.BackgroundImage");
            btn_Jacket.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Jacket.Location = new Point(394, 8);
            btn_Jacket.Name = "btn_Jacket";
            btn_Jacket.Size = new Size(347, 289);
            btn_Jacket.TabIndex = 0;
            btn_Jacket.UseVisualStyleBackColor = true;
            btn_Jacket.Click += btn_Jacket_Click;
            // 
            // btn_WhiteTShirt
            // 
            btn_WhiteTShirt.BackgroundImage = (Image)resources.GetObject("btn_WhiteTShirt.BackgroundImage");
            btn_WhiteTShirt.BackgroundImageLayout = ImageLayout.Stretch;
            btn_WhiteTShirt.Location = new Point(7, 341);
            btn_WhiteTShirt.Name = "btn_WhiteTShirt";
            btn_WhiteTShirt.Size = new Size(347, 289);
            btn_WhiteTShirt.TabIndex = 0;
            btn_WhiteTShirt.UseVisualStyleBackColor = true;
            btn_WhiteTShirt.Click += btn_WhiteTShirt_Click;
            // 
            // btn_Cap
            // 
            btn_Cap.BackgroundImage = (Image)resources.GetObject("btn_Cap.BackgroundImage");
            btn_Cap.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Cap.Location = new Point(394, 341);
            btn_Cap.Name = "btn_Cap";
            btn_Cap.Size = new Size(347, 289);
            btn_Cap.TabIndex = 0;
            btn_Cap.UseVisualStyleBackColor = true;
            btn_Cap.Click += btn_Cap_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 311);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 1;
            label1.Text = "140,000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(394, 311);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 1;
            label2.Text = "220,000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(7, 657);
            label3.Name = "label3";
            label3.Size = new Size(68, 21);
            label3.TabIndex = 1;
            label3.Text = "120,000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(394, 657);
            label4.Name = "label4";
            label4.Size = new Size(59, 21);
            label4.TabIndex = 1;
            label4.Text = "50,000";
            // 
            // lst_SelectedItems
            // 
            lst_SelectedItems.BackColor = Color.RoyalBlue;
            lst_SelectedItems.FormattingEnabled = true;
            lst_SelectedItems.ItemHeight = 15;
            lst_SelectedItems.Location = new Point(760, 12);
            lst_SelectedItems.Name = "lst_SelectedItems";
            lst_SelectedItems.Size = new Size(362, 274);
            lst_SelectedItems.TabIndex = 2;
            // 
            // btn_Reset
            // 
            btn_Reset.FlatStyle = FlatStyle.Flat;
            btn_Reset.Font = new Font("Arial", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_Reset.Location = new Point(760, 341);
            btn_Reset.Name = "btn_Reset";
            btn_Reset.Size = new Size(164, 47);
            btn_Reset.TabIndex = 3;
            btn_Reset.Text = "초기화";
            btn_Reset.UseVisualStyleBackColor = true;
            btn_Reset.Click += btn_Reset_Click;
            // 
            // btn_Complete
            // 
            btn_Complete.FlatStyle = FlatStyle.Flat;
            btn_Complete.Font = new Font("Arial", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_Complete.Location = new Point(958, 341);
            btn_Complete.Name = "btn_Complete";
            btn_Complete.Size = new Size(164, 47);
            btn_Complete.TabIndex = 3;
            btn_Complete.Text = "결제완료";
            btn_Complete.UseVisualStyleBackColor = true;
            btn_Complete.Click += btn_Complete_Click;
            // 
            // button7
            // 
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Arial", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button7.Location = new Point(856, 424);
            button7.Name = "button7";
            button7.Size = new Size(164, 47);
            button7.TabIndex = 3;
            button7.Text = "뒤로가기";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // lbl_TotalPrice
            // 
            lbl_TotalPrice.AutoSize = true;
            lbl_TotalPrice.Font = new Font("Segoe Script", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TotalPrice.Location = new Point(760, 307);
            lbl_TotalPrice.Name = "lbl_TotalPrice";
            lbl_TotalPrice.Size = new Size(64, 31);
            lbl_TotalPrice.TabIndex = 4;
            lbl_TotalPrice.Text = "Total";
            // 
            // Form_will
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(1134, 860);
            Controls.Add(lbl_TotalPrice);
            Controls.Add(button7);
            Controls.Add(btn_Complete);
            Controls.Add(btn_Reset);
            Controls.Add(lst_SelectedItems);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Cap);
            Controls.Add(btn_WhiteTShirt);
            Controls.Add(btn_Jacket);
            Controls.Add(btn_TShirt);
            Name = "Form_will";
            Text = "Form_will";
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
        private ListBox lst_SelectedItems;
        private Button btn_Reset;
        private Button btn_Complete;
        private Button button7;
        private Label lbl_TotalPrice;
    }
}