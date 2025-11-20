using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
            textBox2.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strTicket = "";
            lb_Ticket.Text = "";

            if (!ckb_VVIP.Checked && !ckb_VIP.Checked && !ckb_Reserved.Checked && !ckb_Free.Checked)
            {
                MessageBox.Show("경기와 좌석을 선택해주세요");
                return;
            }

            if (ckb_VVIP.Checked == true)
                strTicket += ckb_VVIP.Text + "\n";
            if (ckb_VIP.Checked == true)
                strTicket += ckb_VIP.Text + "\n";
            if (ckb_Reserved.Checked == true)
                strTicket += ckb_Reserved.Text + "\n";
            if (ckb_Free.Checked == true)
                strTicket += ckb_Free.Text + "\n";
            lb_Ticket.Text = strTicket + "선택하셨습니다";



        }

        private bool btnEnterClick = false;
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (radioAgree.Checked == true)
                MessageBox.Show("포인트가 적립 되었습니다");
            else if (radioDisagree.Checked == true)
                MessageBox.Show("포인트가 적립 되지 않았습니다");
            else
                MessageBox.Show("포인트 적립여부를 선택해주세요");
            btnEnterClick = true;
        }

        private void cbPay_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbPayInfo.Items.Clear();

            if (cbPay.SelectedIndex == 0)
            {
                lbPayInfo.Items.Add("일시불");
                lbPayInfo.Items.Add("3개월 할부");
                lbPayInfo.Items.Add("6개월 할부");
                lbPayInfo.Items.Add("12개월 할부");
            }
            else if (cbPay.SelectedIndex == 1)
            {
                lbPayInfo.Items.Add("국민카드");
                lbPayInfo.Items.Add("신한카드");
                lbPayInfo.Items.Add("농협카드");
                lbPayInfo.Items.Add("우리카드");
                lbPayInfo.Items.Add("삼성카드");
            }
            else if (cbPay.SelectedIndex == 2)
            {
                lbPayInfo.Items.Add("네이버 포인트");
                lbPayInfo.Items.Add("카드 포인트");
                lbPayInfo.Items.Add("F1 맴버십 포인트");
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (btnEnterClick == true)
            {

                if (cbPay.Text == "" | lbPayInfo.Text == "")
                {
                    MessageBox.Show("결제수단 및 정보를 다시 확인해 주세요");
                    return;
                }
                else
                {
                    string str = cbPay.Text + "(으)로" + lbPayInfo.Text + " 결재수단을" + " \n선택하셨습니다" + "\n결제 금액은" + textBox2.Text + "원입니다";
                    MessageBox.Show(str);
                }
            }
            else
                MessageBox.Show("포인트 적립 여부를 확인해주세요");

        }

        public int totalPrice = 0;

        private void ckb_VVIP_CheckedChanged(object sender, EventArgs e)
        {
            int vvip = int.Parse(label_vvip.Text);
            if (ckb_VVIP.Checked)
            {
                totalPrice += vvip;
            }
            else
                totalPrice -= vvip;
        }

        private void ckb_VIP_CheckedChanged(object sender, EventArgs e)
        {
            int vip = int.Parse(label_vip.Text);
            if (ckb_VIP.Checked)
            {
                totalPrice += vip;
            }
            else
                totalPrice -= vip;
        }

        private void ckb_Reserved_CheckedChanged(object sender, EventArgs e)
        {
            int reserved = int.Parse(label_reserved.Text);
            if (ckb_Reserved.Checked)
            {
                totalPrice += reserved;
            }
            else
                totalPrice -= reserved;
        }

        private void ckb_Free_CheckedChanged(object sender, EventArgs e)
        {
            int free = int.Parse(label_free.Text);
            if (ckb_Free.Checked)
            {
                totalPrice += free;
            }
            else
                totalPrice -= free;
        }

        private void button_pay_Click(object sender, EventArgs e)
        {
            textBox2.Text = totalPrice.ToString();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            lb_Ticket.Text = "";
            ckb_VVIP.Checked = false;
            ckb_VIP.Checked = false;
            ckb_Reserved.Checked = false;
            ckb_Free.Checked = false;
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.Show();
            this.Close();
        }

        private void btn_Return_login_Click(object sender, EventArgs e)
        {
            Form14 f14 = new Form14();
            f14.Show();
            this.Close();
        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }
    }
}
