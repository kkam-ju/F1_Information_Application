using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form_mercedes : Form
    {
        int tshirtCount = 0;
        int hoodieCount = 0;
        int shoesCount = 0;
        int capCount = 0;
        int totalPrice = 0;
        int totalQuantity = 0;

        public Form_mercedes()
        {
            InitializeComponent();
        }

        void UpdateSelectedList(string name, int count)
        {
            bool found = false;
            for (int i = 0; i < lst_SelectedItems.Items.Count; i++)
            {
                if (lst_SelectedItems.Items[i].ToString().StartsWith(name))
                {
                    lst_SelectedItems.Items[i] = $"{name} x {count}";
                    found = true;
                    break;
                }
            }
            if (!found)
                lst_SelectedItems.Items.Add($"{name} x {count}");
        }

        void UpdatePriceLabel()
        {
            lbl_TotalPrice.Text = $"총 결제 금액: {totalPrice}원 ({totalQuantity}개)";
        }

        private void btn_TShirt_Click(object sender, EventArgs e)
        {
            tshirtCount++;
            totalPrice += 100000;
            totalQuantity++;
            UpdateSelectedList("Mercedes AMG Petronas adidas F1 2025 Team Driver T-Shirt – Black", tshirtCount);
            UpdatePriceLabel();
        }

        private void btn_Hoodie_Click(object sender, EventArgs e)
        {
            hoodieCount++;
            totalPrice += 100000;
            totalQuantity++;
            UpdateSelectedList("Mercedes AMG Petronas adidas F1 Silver Arrows Zip Through Hoodie", hoodieCount);
            UpdatePriceLabel();
        }

        private void btn_Shoes_Click(object sender, EventArgs e)
        {
            shoesCount++;
            totalPrice += 100000;
            totalQuantity++;
            UpdateSelectedList("Mercedes AMG Petronas adidas VLCourt Base Trainer – White", shoesCount);
            UpdatePriceLabel();
        }

        private void btn_Cap_Click(object sender, EventArgs e)
        {
            capCount++;
            totalPrice += 100000;
            totalQuantity++;
            UpdateSelectedList("Mercedes AMG Petronas F1 2024 Lewis Hamilton Cap – Black – Kids", capCount);
            UpdatePriceLabel();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tshirtCount = 0;
            hoodieCount = 0;
            shoesCount = 0;
            capCount = 0;
            totalPrice = 0;
            totalQuantity = 0;

            lst_SelectedItems.Items.Clear();
            UpdatePriceLabel();
        }

        private void btn_Complete_Click(object sender, EventArgs e)
        {
            if (totalPrice > 0)
                MessageBox.Show("결제가 완료되었습니다!");
            else
                MessageBox.Show("선택된 상품이 없습니다.");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }
    }
}
