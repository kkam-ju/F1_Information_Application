namespace WinFormsApp1
{
    partial class Form_mercedes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_mercedes));
            btn_TShirt = new Button();
            btn_Hoodie = new Button();
            btn_Shoes = new Button();
            btn_Cap = new Button();
            lst_SelectedItems = new ListBox();
            lbl_TotalPrice = new Label();
            btn_Reset = new Button();
            btn_Complete = new Button();
            button10 = new Button();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // btn_TShirt
            // 
            btn_TShirt.BackgroundImage = (Image)resources.GetObject("btn_TShirt.BackgroundImage");
            btn_TShirt.BackgroundImageLayout = ImageLayout.Stretch;
            btn_TShirt.Location = new Point(12, 12);
            btn_TShirt.Name = "btn_TShirt";
            btn_TShirt.Size = new Size(334, 292);
            btn_TShirt.TabIndex = 0;
            btn_TShirt.UseVisualStyleBackColor = true;
            btn_TShirt.Click += btn_TShirt_Click;
            // 
            // btn_Hoodie
            // 
            btn_Hoodie.BackgroundImage = (Image)resources.GetObject("btn_Hoodie.BackgroundImage");
            btn_Hoodie.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Hoodie.Location = new Point(386, 12);
            btn_Hoodie.Name = "btn_Hoodie";
            btn_Hoodie.Size = new Size(334, 292);
            btn_Hoodie.TabIndex = 0;
            btn_Hoodie.UseVisualStyleBackColor = true;
            btn_Hoodie.Click += btn_Hoodie_Click;
            // 
            // btn_Shoes
            // 
            btn_Shoes.BackgroundImage = (Image)resources.GetObject("btn_Shoes.BackgroundImage");
            btn_Shoes.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Shoes.Location = new Point(12, 358);
            btn_Shoes.Name = "btn_Shoes";
            btn_Shoes.Size = new Size(334, 292);
            btn_Shoes.TabIndex = 0;
            btn_Shoes.UseVisualStyleBackColor = true;
            btn_Shoes.Click += btn_Shoes_Click;
            // 
            // btn_Cap
            // 
            btn_Cap.BackgroundImage = (Image)resources.GetObject("btn_Cap.BackgroundImage");
            btn_Cap.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Cap.Location = new Point(386, 358);
            btn_Cap.Name = "btn_Cap";
            btn_Cap.Size = new Size(334, 292);
            btn_Cap.TabIndex = 0;
            btn_Cap.UseVisualStyleBackColor = true;
            btn_Cap.Click += btn_Cap_Click;
            // 
            // lst_SelectedItems
            // 
            lst_SelectedItems.BackColor = Color.Silver;
            lst_SelectedItems.FormattingEnabled = true;
            lst_SelectedItems.ItemHeight = 15;
            lst_SelectedItems.Location = new Point(753, 12);
            lst_SelectedItems.Name = "lst_SelectedItems";
            lst_SelectedItems.Size = new Size(326, 289);
            lst_SelectedItems.TabIndex = 1;
            // 
            // lbl_TotalPrice
            // 
            lbl_TotalPrice.AutoSize = true;
            lbl_TotalPrice.Font = new Font("Segoe Script", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TotalPrice.Location = new Point(753, 320);
            lbl_TotalPrice.Name = "lbl_TotalPrice";
            lbl_TotalPrice.Size = new Size(64, 31);
            lbl_TotalPrice.TabIndex = 2;
            lbl_TotalPrice.Text = "Total";
            // 
            // btn_Reset
            // 
            btn_Reset.FlatStyle = FlatStyle.Flat;
            btn_Reset.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            btn_Reset.Location = new Point(753, 358);
            btn_Reset.Name = "btn_Reset";
            btn_Reset.Size = new Size(151, 51);
            btn_Reset.TabIndex = 3;
            btn_Reset.Text = "초기화";
            btn_Reset.UseVisualStyleBackColor = true;
            btn_Reset.Click += btn_Reset_Click;
            // 
            // btn_Complete
            // 
            btn_Complete.FlatStyle = FlatStyle.Flat;
            btn_Complete.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            btn_Complete.Location = new Point(910, 358);
            btn_Complete.Name = "btn_Complete";
            btn_Complete.Size = new Size(169, 51);
            btn_Complete.TabIndex = 3;
            btn_Complete.Text = "결제 완료";
            btn_Complete.UseVisualStyleBackColor = true;
            btn_Complete.Click += btn_Complete_Click;
            // 
            // button10
            // 
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            button10.Location = new Point(839, 477);
            button10.Name = "button10";
            button10.Size = new Size(132, 51);
            button10.TabIndex = 3;
            button10.Text = "뒤로가기";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 310);
            label4.Name = "label4";
            label4.Size = new Size(83, 25);
            label4.TabIndex = 4;
            label4.Text = "150,000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(386, 310);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 4;
            label2.Text = "200,000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 666);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 4;
            label3.Text = "120,000";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(386, 666);
            label5.Name = "label5";
            label5.Size = new Size(72, 25);
            label5.TabIndex = 4;
            label5.Text = "50,000";
            // 
            // Form_mercedes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1091, 755);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(button10);
            Controls.Add(btn_Complete);
            Controls.Add(btn_Reset);
            Controls.Add(lbl_TotalPrice);
            Controls.Add(lst_SelectedItems);
            Controls.Add(btn_Cap);
            Controls.Add(btn_Shoes);
            Controls.Add(btn_Hoodie);
            Controls.Add(btn_TShirt);
            Name = "Form_mercedes";
            Text = "Form_mercedes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_TShirt;
        private Button btn_Hoodie;
        private Button btn_Shoes;
        private Button btn_Cap;
        private ListBox lst_SelectedItems;
        private Label lbl_TotalPrice;
        private Button btn_Reset;
        private Button btn_Complete;
        private Button button10;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label5;
    }
}