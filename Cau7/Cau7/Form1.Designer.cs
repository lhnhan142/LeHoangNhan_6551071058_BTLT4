namespace Cau7
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
            txtNamAmLich = new TextBox();
            txtNamDuongLich = new TextBox();
            lblAmLich = new Label();
            lblDuongLich = new Label();
            brnThucHienDoi = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // txtNamAmLich
            // 
            txtNamAmLich.Location = new Point(336, 285);
            txtNamAmLich.Name = "txtNamAmLich";
            txtNamAmLich.Size = new Size(125, 27);
            txtNamAmLich.TabIndex = 0;
            // 
            // txtNamDuongLich
            // 
            txtNamDuongLich.Location = new Point(336, 99);
            txtNamDuongLich.Name = "txtNamDuongLich";
            txtNamDuongLich.Size = new Size(125, 27);
            txtNamDuongLich.TabIndex = 1;
            // 
            // lblAmLich
            // 
            lblAmLich.AutoSize = true;
            lblAmLich.Location = new Point(174, 285);
            lblAmLich.Name = "lblAmLich";
            lblAmLich.Size = new Size(130, 20);
            lblAmLich.TabIndex = 2;
            lblAmLich.Text = "Nhập năm âm lich";
            // 
            // lblDuongLich
            // 
            lblDuongLich.AutoSize = true;
            lblDuongLich.Location = new Point(165, 102);
            lblDuongLich.Name = "lblDuongLich";
            lblDuongLich.Size = new Size(153, 20);
            lblDuongLich.TabIndex = 3;
            lblDuongLich.Text = "Nhập năm dương lịch";
            // 
            // brnThucHienDoi
            // 
            brnThucHienDoi.Location = new Point(205, 186);
            brnThucHienDoi.Name = "brnThucHienDoi";
            brnThucHienDoi.Size = new Size(134, 29);
            brnThucHienDoi.TabIndex = 4;
            brnThucHienDoi.Text = "Thưc hiện đổi";
            brnThucHienDoi.UseVisualStyleBackColor = true;
            brnThucHienDoi.Click += brnThucHienDoi_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(421, 186);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThoat);
            Controls.Add(brnThucHienDoi);
            Controls.Add(lblDuongLich);
            Controls.Add(lblAmLich);
            Controls.Add(txtNamDuongLich);
            Controls.Add(txtNamAmLich);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNamAmLich;
        private TextBox txtNamDuongLich;
        private Label lblAmLich;
        private Label lblDuongLich;
        private Button brnThucHienDoi;
        private Button btnThoat;
    }
}
