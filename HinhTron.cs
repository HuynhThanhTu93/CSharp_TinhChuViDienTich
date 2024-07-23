using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_TinhChuViDienTich
{
    public partial class HinhTron : Form
    {
        public HinhTron()
        {
            InitializeComponent();
        }
        double a;
        double b = 3.14;
        private void button1_Click(object sender, EventArgs e)
        {
            DuLieu();
            lblKQ.Text = "- Diện tích: " + (a * b);
        }

        private bool DuLieu()
        {
            try
            {
                a = Convert.ToDouble(txtA.Text);
                return true;
            }
            catch
            {
                MessageBox.Show("Không được nhập chữ, Phải nhập số", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtA.Clear();
                txtB.Clear();
                txtA.Focus();
                return false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
