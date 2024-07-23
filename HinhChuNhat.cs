namespace CSharp_TinhChuViDienTich
{
    public partial class HinhChuNhat : Form
    {
        double a;
        double b;
        public HinhChuNhat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LayThongTin())
            {               
                lblKQ.Text = "- Chu Vi: " + TinhChuVi(a, b) + Environment.NewLine + "- Diện tích: " + TinhDienTich(a, b);
            }
            else
            {
                lblKQ.Text = ""; 
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btxCHUVI_Click(object sender, EventArgs e)
        {
            if (LayThongTin())
            lblKQ.Text = "Chu vi: " + TinhChuVi(a, b);
            else
                lblKQ.Text = "";
        }

        private void btxDIENTICH_Click(object sender, EventArgs e)
        {
            LayThongTin();
            lblKQ.Text = "Diện tích: " + TinhDienTich(a, b);
        }
        private double TinhChuVi(double d, double r)
        {
            return (d + r) * 2;
        }
        private double TinhDienTich(double d, double r)
        {
            return (d * r);
        }
        private bool LayThongTin()
        {
            try
            {
                a = Convert.ToDouble(txtA.Text);
                b = Convert.ToDouble(txtB.Text);
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
    }
}