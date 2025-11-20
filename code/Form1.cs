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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_mercedes_Click(object sender, EventArgs e)
        {
            Form_mercedes f_mercedes = new Form_mercedes();
            f_mercedes.Show();
            this.Close();
        }

        private void btn_ferrari_Click(object sender, EventArgs e)
        {
            Form_Ferrari f_Ferrari = new Form_Ferrari();
            f_Ferrari.Show();
            this.Close();
        }

        private void btn_redbull_Click(object sender, EventArgs e)
        {
            MessageBox.Show("남은 재고가 없습니다 다음에 또 이용해주세요.");
        }

        private void btn_mclaren_Click(object sender, EventArgs e)
        {
            MessageBox.Show("서버 준비 중입니다.");
        }

        private void btn_sauber_Click(object sender, EventArgs e)
        {
            MessageBox.Show("남은 재고가 없습니다 다음에 또 이용해주세요.");
        }

        private void btn_aston_Click(object sender, EventArgs e)
        {
            MessageBox.Show("서버 준비 중입니다.");
        }

        private void btn_alpin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("남은 재고가 없습니다 다음에 또 이용해주세요.");
        }

        private void btn_bull_Click(object sender, EventArgs e)
        {
            MessageBox.Show("서버 준비 중입니다.");
        }

        private void btn_will_Click(object sender, EventArgs e)
        {
            Form_will fwill = new Form_will();
            fwill.Show();
            this.Close();
        }

        private void btn_haas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("서버 준비 중입니다.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.Show();
            this.Close();
        }
    }
}
