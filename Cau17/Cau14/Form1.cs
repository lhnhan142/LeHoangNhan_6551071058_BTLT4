using System;
using System.Windows.Forms;

namespace Cau14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == "")
            {
                MessageBox.Show("Bạn ko được phép nhập dữ liệu rỗng!", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTen.Focus();
            }
            else
            {
                string strDuLieu = txtTen.Text;
                lstLopA.Items.Add(strDuLieu);
                txtTen.Clear();
                txtTen.Focus();
            }
        }

        // Hàm dùng chung cho ListBox
        private void chuyenDuLieu(ListBox lstNguon, ListBox lstDich)
        {
            int i = 0;
            while (i < lstNguon.Items.Count)
            {
                if (lstNguon.GetSelected(i))
                {
                    lstDich.Items.Add(lstNguon.Items[i].ToString());
                    lstNguon.Items.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
        }

        // Hàm dùng chung cho ListBox
        private void chuyenToanBo(ListBox lstNguon, ListBox lstDich)
        {
            while (lstNguon.Items.Count > 0)
            {
                lstDich.Items.Add(lstNguon.Items[0].ToString());
                lstNguon.Items.RemoveAt(0);
            }
        }

        // Hàm xóa dữ liệu dùng chung
        private void xoaDuLieu(ListBox lst)
        {
            int i = 0;
            while (i < lst.Items.Count)
            {
                if (lst.GetSelected(i))
                {
                    lst.Items.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
        }

        // 5. Các nút di chuyển mục được chọn ( > và < )
        private void btnChuyenPhai_Click(object sender, EventArgs e)
        {
            if (lstLopA.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc chuyển những dữ liệu đang chọn không?", "Thông Báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    chuyenDuLieu(lstLopA, lstLopB);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn mục nào hoặc danh sách hiện đang rỗng!", "Chú ý");
            }
        }

        private void btnChuyenTrai_Click(object sender, EventArgs e)
        {
            if (lstLopB.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc chuyển những dữ liệu đang chọn không?", "Thông Báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    chuyenDuLieu(lstLopB, lstLopA);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn mục nào hoặc danh sách hiện đang rỗng!", "Chú ý");
            }
        }

        // 6. Các nút di chuyển toàn bộ mục ( >> và << )
        private void btnChuyenTatCaPhai_Click(object sender, EventArgs e)
        {
            if (lstLopA.Items.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc chuyển toàn bộ dữ liệu không?", "Thông Báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    chuyenToanBo(lstLopA, lstLopB);
                }
            }
            else
            {
                MessageBox.Show("Danh sách lớp A hiện đang rỗng!", "Chú ý");
            }
        }

        private void btnChuyenTatCaTrai_Click(object sender, EventArgs e)
        {
            if (lstLopB.Items.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc chuyển toàn bộ dữ liệu không?", "Thông Báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    chuyenToanBo(lstLopB, lstLopA);
                }
            }
            else
            {
                MessageBox.Show("Danh sách lớp B hiện đang rỗng!", "Chú ý");
            }
        }

        // 7. Các nút Xóa
        private void btnXoaLopA_Click(object sender, EventArgs e)
        {
            if (lstLopA.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc xóa những phần tử này?", "Chú ý",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    xoaDuLieu(lstLopA);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn mục nào để xóa!", "Chú ý");
            }
        }

        private void btnXoaLopB_Click(object sender, EventArgs e)
        {
            if (lstLopB.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc xóa những phần tử này?", "Chú ý",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    xoaDuLieu(lstLopB);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn mục nào để xóa!", "Chú ý");
            }
        }

        // Nút Kết Thúc và sự kiện FormClosing
        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close(); // Lệnh này sẽ kích hoạt sự kiện FormClosing bên dưới
        }

        private void FormCapNhatListBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thật sự muốn thoát?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true; // Hủy lệnh đóng form
            }
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Họ tên: LÊ HOÀNG NHÂN\nMSSV: 6551071058\nLớp: CNTT K65", "Thông Tin Sinh Viên",
                MessageBoxButtons.OK);
        }

        private void cậpNhậtLớpBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng có để trống không
            if (txtTen.Text == "")
            {
                MessageBox.Show("Bạn ko được phép nhập dữ liệu rỗng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTen.Focus();
            }
            else
            {
                // Thêm dữ liệu vào ListBox Lớp B thay vì Lớp A
                string strDuLieu = txtTen.Text;
                lstLopB.Items.Add(strDuLieu);

                // Xóa nội dung vừa nhập và đặt lại con trỏ
                txtTen.Clear();
                txtTen.Focus();
            }
        }
    }
}