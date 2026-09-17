namespace Cau4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void giaiPtBacI(int a, int b)
        {
            if (a == 0)
            {
                if (b == 0)
                    txtKetQua.Text = "Pt co vo so nghiem!";
                else
                    txtKetQua.Text = "Pt vo nghiem!";
            }
            else
            {
                txtKetQua.Text = string.Format("Pt co nghiem x = {0:N2}", -b / (a * 1.0));
            }
        }

        void giaiPtBacII(int a, int b, int c)
        {
            if (a == 0)
            {
                giaiPtBacI(b, c);
            }
            else
            {
                double dbDelt = Math.Pow(b, 2) - 4 * a * c;
                if (dbDelt < 0)
                    txtKetQua.Text = "Pt vo nghiem!";
                else if (dbDelt == 0)
                    txtKetQua.Text = string.Format("Pt co nghiem kep x= {0:N2}", -b / (2.0 * a));
                else
                {
                    double dbNghiem1 = (-b + Math.Sqrt(dbDelt)) / (2.0 * a);
                    double dbNghiem2 = (-b - Math.Sqrt(dbDelt)) / (2.0 * a);

                    txtKetQua.Text = string.Format("Pt co 2 nghiem phan biet \n x1 = {0:N2}\n x2 = {1:N2}", dbNghiem1, dbNghiem2);
                }
            }
        }

        private void btnPtBacI_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSoA.Text, out int a) && int.TryParse(txtSoB.Text, out int b))
            {
                // Gọi hàm thực thi
                giaiPtBacI(a, b);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ cho Số A và Số B!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPtBacII_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSoA.Text, out int a) &&
        int.TryParse(txtSoB.Text, out int b) &&
        int.TryParse(txtSoC.Text, out int c))
            {
                // Gọi hàm thực thi
                giaiPtBacII(a, b, c);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ số nguyên hợp lệ cho A, B và C!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
