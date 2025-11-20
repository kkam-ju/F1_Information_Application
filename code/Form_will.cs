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
    public partial class Form_will : Form
    {
        int tshirtCount = 0;
        int jacketCount = 0;
        int whiteTshirtCount = 0;
        int capCount = 0;
        int totalPrice = 0;
        int totalQuantity = 0;

        public Form_will()
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
            totalPrice += 140000;
            totalQuantity++;
            UpdateSelectedList("Scuderia Ferrari 2025 Team T-Shirt", tshirtCount);
            UpdatePriceLabel();
        }

        private void btn_Jacket_Click(object sender, EventArgs e)
        {
            jacketCount++;
            totalPrice += 220000;
            totalQuantity++;
            UpdateSelectedList("Scuderia Ferrari 2025 Team Softshell Jacket", jacketCount);
            UpdatePriceLabel();
        }

        private void btn_WhiteTShirt_Click(object sender, EventArgs e)
        {
            whiteTshirtCount++;
            totalPrice += 120000;
            totalQuantity++;
            UpdateSelectedList("Drivers Oversized T-Shirt - White", whiteTshirtCount);
            UpdatePriceLabel();
        }

        private void btn_Cap_Click(object sender, EventArgs e)
        {
            capCount++;
            totalPrice += 50000;
            totalQuantity++;
            UpdateSelectedList("Lewis Hamilton Cap - Red", capCount);
            UpdatePriceLabel();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tshirtCount = 0;
            jacketCount = 0;
            whiteTshirtCount = 0;
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

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }
    }
}
