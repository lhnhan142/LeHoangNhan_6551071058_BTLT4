namespace Cau14
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
            lblTen = new Label();
            txtTen = new TextBox();
            btnCapNhat = new Button();
            btnChuyenPhai = new Button();
            btnChuyentatCaPhai = new Button();
            btnChuyenTrai = new Button();
            btnChuyentatCaTrai = new Button();
            label3 = new Label();
            btnXoaLopA = new Button();
            btnKetThuc = new Button();
            btnXoaLopB = new Button();
            menuStrip1 = new MenuStrip();
            cậpNhậtToolStripMenuItem = new ToolStripMenuItem();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            lstLopA = new ListBox();
            lstLopB = new ListBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(64, 43);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(32, 20);
            lblTen.TabIndex = 0;
            lblTen.Text = "Tên";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(146, 43);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(254, 27);
            txtTen.TabIndex = 1;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(489, 43);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(94, 29);
            btnCapNhat.TabIndex = 2;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += button1_Click;
            // 
            // btnChuyenPhai
            // 
            btnChuyenPhai.Location = new Point(354, 117);
            btnChuyenPhai.Name = "btnChuyenPhai";
            btnChuyenPhai.Size = new Size(94, 29);
            btnChuyenPhai.TabIndex = 3;
            btnChuyenPhai.Text = ">";
            btnChuyenPhai.UseVisualStyleBackColor = true;
            btnChuyenPhai.Click += btnChuyenPhai_Click;
            // 
            // btnChuyentatCaPhai
            // 
            btnChuyentatCaPhai.Location = new Point(354, 178);
            btnChuyentatCaPhai.Name = "btnChuyentatCaPhai";
            btnChuyentatCaPhai.Size = new Size(94, 29);
            btnChuyentatCaPhai.TabIndex = 4;
            btnChuyentatCaPhai.Text = ">>";
            btnChuyentatCaPhai.UseVisualStyleBackColor = true;
            btnChuyentatCaPhai.Click += btnChuyenTatCaPhai_Click;
            // 
            // btnChuyenTrai
            // 
            btnChuyenTrai.Location = new Point(354, 239);
            btnChuyenTrai.Name = "btnChuyenTrai";
            btnChuyenTrai.Size = new Size(94, 29);
            btnChuyenTrai.TabIndex = 5;
            btnChuyenTrai.Text = "<";
            btnChuyenTrai.UseVisualStyleBackColor = true;
            btnChuyenTrai.Click += btnChuyenTrai_Click;
            // 
            // btnChuyentatCaTrai
            // 
            btnChuyentatCaTrai.Location = new Point(354, 295);
            btnChuyentatCaTrai.Name = "btnChuyentatCaTrai";
            btnChuyentatCaTrai.Size = new Size(94, 29);
            btnChuyentatCaTrai.TabIndex = 6;
            btnChuyentatCaTrai.Text = "<<";
            btnChuyentatCaTrai.UseVisualStyleBackColor = true;
            btnChuyentatCaTrai.Click += btnChuyenTatCaTrai_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Cyan;
            label3.Location = new Point(1, 421);
            label3.Name = "label3";
            label3.Size = new Size(798, 25);
            label3.TabIndex = 10;
            label3.Text = "label3";
            // 
            // btnXoaLopA
            // 
            btnXoaLopA.Location = new Point(118, 380);
            btnXoaLopA.Name = "btnXoaLopA";
            btnXoaLopA.Size = new Size(94, 29);
            btnXoaLopA.TabIndex = 11;
            btnXoaLopA.Text = "Xóa lớp A";
            btnXoaLopA.UseVisualStyleBackColor = true;
            btnXoaLopA.Click += btnXoaLopA_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Location = new Point(354, 380);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(94, 29);
            btnKetThuc.TabIndex = 12;
            btnKetThuc.Text = "Kết thúc";
            btnKetThuc.UseVisualStyleBackColor = true;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // btnXoaLopB
            // 
            btnXoaLopB.Location = new Point(588, 380);
            btnXoaLopB.Name = "btnXoaLopB";
            btnXoaLopB.Size = new Size(94, 29);
            btnXoaLopB.TabIndex = 13;
            btnXoaLopB.Text = "Xóa lớp B";
            btnXoaLopB.UseVisualStyleBackColor = true;
            btnXoaLopB.Click += btnXoaLopB_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Cyan;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cậpNhậtToolStripMenuItem, hệThốngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            // 
            // cậpNhậtToolStripMenuItem
            // 
            cậpNhậtToolStripMenuItem.BackColor = Color.Cyan;
            cậpNhậtToolStripMenuItem.Name = "cậpNhậtToolStripMenuItem";
            cậpNhậtToolStripMenuItem.Size = new Size(82, 24);
            cậpNhậtToolStripMenuItem.Text = "Cập nhật";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(85, 24);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // lstLopA
            // 
            lstLopA.FormattingEnabled = true;
            lstLopA.Location = new Point(80, 100);
            lstLopA.Name = "lstLopA";
            lstLopA.Size = new Size(219, 244);
            lstLopA.TabIndex = 15;
            // 
            // lstLopB
            // 
            lstLopB.FormattingEnabled = true;
            lstLopB.Location = new Point(489, 100);
            lstLopB.Name = "lstLopB";
            lstLopB.Size = new Size(219, 244);
            lstLopB.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstLopB);
            Controls.Add(lstLopA);
            Controls.Add(btnXoaLopB);
            Controls.Add(btnKetThuc);
            Controls.Add(btnXoaLopA);
            Controls.Add(label3);
            Controls.Add(btnChuyentatCaTrai);
            Controls.Add(btnChuyenTrai);
            Controls.Add(btnChuyentatCaPhai);
            Controls.Add(btnChuyenPhai);
            Controls.Add(btnCapNhat);
            Controls.Add(txtTen);
            Controls.Add(lblTen);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTen;
        private TextBox txtTen;
        private Button btnCapNhat;
        private Button btnChuyenPhai;
        private Button btnChuyentatCaPhai;
        private Button btnChuyenTrai;
        private Button btnChuyentatCaTrai;
        private Label label3;
        private Button btnXoaLopA;
        private Button btnKetThuc;
        private Button btnXoaLopB;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cậpNhậtToolStripMenuItem;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ListBox lstLopA;
        private ListBox lstLopB;
    }
}
