namespace Cau1
{
    public partial class Form1 : Form
    {
        decimal tienmay = 100;
        decimal tiennguoi = 100;
        Random ran = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtTienMay.Text = tienmay.ToString();
            txtTienNguoiChoi.Text = tiennguoi.ToString();
        }

        private void btnQuaySo_Click(object sender, EventArgs e)
        {
            if (tiennguoi >= 30)
            {
                timer1.Enabled = true; // Cho timer chạy
                timer1.Interval = 2;   // Tốc độ nháy số rất nhanh

                tienmay = tienmay + 30;
                tiennguoi = tiennguoi - 30;

                // Cập nhật lại số tiền hiển thị
                txtTienMay.Text = tienmay.ToString();
                txtTienNguoiChoi.Text = tiennguoi.ToString();
            }
            else
            {
                MessageBox.Show("Không đủ 30 đồng để chơi tiếp!", "Game Over");
                btnQuaySo.Enabled = false; // Khóa nút quay số lại
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval += 5; // Tăng dần thời gian để số nháy chậm lại tạo cảm giác "dừng"

            int so = ran.Next(0, 8);
            int so2 = ran.Next(0, 9);
            int so3 = ran.Next(0, 10);

            lblSo1.Text = so.ToString();
            lblSo2.Text = so2.ToString();
            lblSo3.Text = so3.ToString();

            if (timer1.Interval > 200) // Đủ độ trễ thì dừng timer lại và xét thưởng
            {
                timer1.Stop();
                decimal tienthuong = 0;

                if (so == 7)
                {
                    tienthuong = 100 + (tienmay * 50) / 100;
                    tiennguoi += tienthuong;
                    tienmay -= (tienmay * 50) / 100;
                    MessageBox.Show("Ô 1 trúng! Thưởng " + tienthuong + " đồng");
                }
                if (so2 == 7)
                {
                    tienthuong = 30 + (tienmay * 50) / 100;
                    tiennguoi += tienthuong;
                    tienmay -= (tienmay * 50) / 100;
                    MessageBox.Show("Ô 2 trúng! Thưởng " + tienthuong + " đồng");
                }
                if (so3 == 7)
                {
                    tienthuong = 10;
                    tiennguoi += tienthuong;
                    tienmay -= 10;
                    MessageBox.Show("Ô 3 trúng! Thưởng 10 đồng");
                }

                // Cập nhật lại tiền sau khi cộng/trừ thưởng
                txtTienMay.Text = tienmay.ToString();
                txtTienNguoiChoi.Text = tiennguoi.ToString();
            }
        }

        private void btnGameMoi_Click(object sender, EventArgs e)
        {
            tienmay = 100;
            tiennguoi = 100;
            lblSo1.Text = "7";
            lblSo2.Text = "7";
            lblSo3.Text = "7";
            txtTienMay.Text = tienmay.ToString();
            txtTienNguoiChoi.Text = tiennguoi.ToString();
            btnQuaySo.Enabled = true; // Mở khóa lại nút quay số nếu trước đó bị thua hết tiền
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
