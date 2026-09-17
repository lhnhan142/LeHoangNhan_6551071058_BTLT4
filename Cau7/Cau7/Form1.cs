namespace Cau7
{
    public partial class Form1 : Form
    {
        private string TinhCan(int nam)
        {
            string strCan = "";
            switch (nam % 10)
            {
                case 0: strCan = "Canh"; break;
                case 1: strCan = "Tân"; break;
                case 2: strCan = "Nhâm"; break;
                case 3: strCan = "Quý"; break;
                case 4: strCan = "Giáp"; break;
                case 5: strCan = "Ất"; break;
                case 6: strCan = "Bính"; break;
                case 7: strCan = "Đinh"; break;
                case 8: strCan = "Mậu"; break;
                case 9: strCan = "Kỷ"; break;
            }
            return strCan;
        }

        private string TinhChi(int nam)
        {
            string strChi = "";
            switch (nam % 12)
            {
                case 0: strChi = "Thân"; break;
                case 1: strChi = "Dậu"; break;
                case 2: strChi = "Tuất"; break;
                case 3: strChi = "Hợi"; break;
                case 4: strChi = "Tý"; break;
                case 5: strChi = "Sửu"; break;
                case 6: strChi = "Dần"; break;
                case 7: strChi = "Mẹo"; break;
                case 8: strChi = "Thìn"; break;
                case 9: strChi = "Tỵ"; break;
                case 10: strChi = "Ngọ"; break;
                case 11: strChi = "Mùi"; break;
            }
            return strChi;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void brnThucHienDoi_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra người dùng có để trống không
            if (string.IsNullOrWhiteSpace(txtNamDuongLich.Text))
            {
                MessageBox.Show("Vui lòng nhập năm dương lịch!", "Thông báo");
                txtNamDuongLich.Focus(); // Đưa con trỏ chuột nháy lại vào ô nhập
                return;
            }

            // 2 & 3. Gán giá trị và kiểm tra số nguyên dương
            int intNamDuong;
            // int.TryParse giúp kiểm tra chuỗi nhập vào có phải là số nguyên hay không
            if (int.TryParse(txtNamDuongLich.Text, out intNamDuong) && intNamDuong > 0)
            {
                // Gọi hàm TinhCan và TinhChi, ghép lại bằng dấu khoảng trắng
                txtNamAmLich.Text = TinhCan(intNamDuong) + " " + TinhChi(intNamDuong);
            }
            else
            {
                // Nếu nhập chữ hoặc số âm
                MessageBox.Show("Vui lòng nhập một số nguyên dương hợp lệ (ví dụ: 2005)!", "Lỗi");
                txtNamDuongLich.Clear(); // Xóa dữ liệu sai đi
                txtNamDuongLich.Focus();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dl;
            dl = MessageBox.Show("Có chắc bạn muốn đóng ứng dụng?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                Close(); // Đóng form hiện tại
            }
        }
    }
}
