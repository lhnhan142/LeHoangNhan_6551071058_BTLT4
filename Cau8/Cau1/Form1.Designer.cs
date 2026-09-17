namespace Cau1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTienMay = new Label();
            lblTienNguoiChoi = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btnQuaySo = new Button();
            btnGameMoi = new Button();
            btnKetThuc = new Button();
            groupBox1 = new GroupBox();
            lblSo3 = new Label();
            lblSo2 = new Label();
            lblSo1 = new Label();
            txtTienMay = new TextBox();
            txtTienNguoiChoi = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTienMay
            // 
            lblTienMay.AutoSize = true;
            lblTienMay.Location = new Point(260, 255);
            lblTienMay.Name = "lblTienMay";
            lblTienMay.Size = new Size(69, 20);
            lblTienMay.TabIndex = 0;
            lblTienMay.Text = "Tiền máy";
            // 
            // lblTienNguoiChoi
            // 
            lblTienNguoiChoi.AutoSize = true;
            lblTienNguoiChoi.Location = new Point(248, 302);
            lblTienNguoiChoi.Name = "lblTienNguoiChoi";
            lblTienNguoiChoi.Size = new Size(112, 20);
            lblTienNguoiChoi.TabIndex = 1;
            lblTienNguoiChoi.Text = "Tiền người chơi";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // btnQuaySo
            // 
            btnQuaySo.Location = new Point(167, 371);
            btnQuaySo.Name = "btnQuaySo";
            btnQuaySo.Size = new Size(94, 29);
            btnQuaySo.TabIndex = 4;
            btnQuaySo.Text = "Quay số";
            btnQuaySo.UseVisualStyleBackColor = true;
            btnQuaySo.Click += btnQuaySo_Click;
            // 
            // btnGameMoi
            // 
            btnGameMoi.Location = new Point(342, 371);
            btnGameMoi.Name = "btnGameMoi";
            btnGameMoi.Size = new Size(94, 29);
            btnGameMoi.TabIndex = 5;
            btnGameMoi.Text = "Game mới";
            btnGameMoi.UseVisualStyleBackColor = true;
            btnGameMoi.Click += btnGameMoi_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Location = new Point(506, 371);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(94, 29);
            btnKetThuc.TabIndex = 6;
            btnKetThuc.Text = "Kết thúc";
            btnKetThuc.UseVisualStyleBackColor = true;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblSo3);
            groupBox1.Controls.Add(lblSo2);
            groupBox1.Controls.Add(lblSo1);
            groupBox1.Location = new Point(184, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(460, 159);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // lblSo3
            // 
            lblSo3.BackColor = SystemColors.Info;
            lblSo3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSo3.ForeColor = Color.Red;
            lblSo3.Location = new Point(322, 45);
            lblSo3.Name = "lblSo3";
            lblSo3.Size = new Size(118, 84);
            lblSo3.TabIndex = 2;
            lblSo3.Text = "7";
            lblSo3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSo2
            // 
            lblSo2.BackColor = SystemColors.Info;
            lblSo2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSo2.ForeColor = Color.Red;
            lblSo2.Location = new Point(176, 45);
            lblSo2.Name = "lblSo2";
            lblSo2.Size = new Size(118, 84);
            lblSo2.TabIndex = 1;
            lblSo2.Text = "7";
            lblSo2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSo1
            // 
            lblSo1.BackColor = SystemColors.Info;
            lblSo1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSo1.ForeColor = Color.Red;
            lblSo1.Location = new Point(27, 45);
            lblSo1.Name = "lblSo1";
            lblSo1.Size = new Size(118, 84);
            lblSo1.TabIndex = 0;
            lblSo1.Text = "7";
            lblSo1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTienMay
            // 
            txtTienMay.Location = new Point(422, 255);
            txtTienMay.Name = "txtTienMay";
            txtTienMay.Size = new Size(125, 27);
            txtTienMay.TabIndex = 8;
            // 
            // txtTienNguoiChoi
            // 
            txtTienNguoiChoi.Location = new Point(422, 302);
            txtTienNguoiChoi.Name = "txtTienNguoiChoi";
            txtTienNguoiChoi.Size = new Size(125, 27);
            txtTienNguoiChoi.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTienNguoiChoi);
            Controls.Add(txtTienMay);
            Controls.Add(groupBox1);
            Controls.Add(btnKetThuc);
            Controls.Add(btnGameMoi);
            Controls.Add(btnQuaySo);
            Controls.Add(lblTienNguoiChoi);
            Controls.Add(lblTienMay);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTienMay;
        private Label lblTienNguoiChoi;
        private System.Windows.Forms.Timer timer1;
        private Button btnQuaySo;
        private Button btnGameMoi;
        private Button btnKetThuc;
        private GroupBox groupBox1;
        private Label lblSo1;
        private Label lblSo3;
        private Label lblSo2;
        private TextBox txtTienMay;
        private TextBox txtTienNguoiChoi;
    }
}
