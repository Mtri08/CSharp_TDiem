using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BÀI_TÍNH_ĐIỂM_CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtten.Text == "" || txttoan.Text == "" || txtvan.Text == "")
            {
                MessageBox.Show("phải nhập toán văn sao mà ngu thế");
                return;
            }
            Double toan, van, trungbinh;
            toan=Convert.ToDouble(txttoan.Text);
            van=Convert.ToDouble(txtvan.Text);
            trungbinh=(toan+van)/2;
            txttrungbinh.Text=trungbinh.ToString();
            if (trungbinh < 5)
            {
                txtxeploai.Text = "yêu";
            }
            else if (trungbinh < 6)
                txtxeploai.Text = "trung bình";
            else if (trungbinh < 8)
                txtxeploai.Text = "khá";
            else
                txtxeploai.Text = "giỏi";

        }

        private void lblten_Click(object sender, EventArgs e)
        {

        }

        private void txttrungbinh_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
