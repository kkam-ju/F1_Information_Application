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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputId = textBox1.Text;
            string inputPw = textBox2.Text;


            string correctId = "abcd";
            string correctPw = "1234";

            if (inputId == correctId && inputPw == correctPw)
            {

                Form13 form13 = new Form13();
                form13.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ID 또는 비밀번호가 틀렸습니다.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12();
            form12.Show();
            this.Hide();
        }
    }
}
