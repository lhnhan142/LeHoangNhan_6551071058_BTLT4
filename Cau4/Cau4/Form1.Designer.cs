namespace Cau4
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
            lblSoA = new Label();
            lblSoB = new Label();
            lblSoC = new Label();
            lblKetQua = new Label();
            txtSoA = new TextBox();
            txtSoB = new TextBox();
            txtSoC = new TextBox();
            txtKetQua = new TextBox();
            btnPtBacI = new Button();
            btnPtBacII = new Button();
            SuspendLayout();
            // 
            // lblSoA
            // 
            lblSoA.AutoSize = true;
            lblSoA.Location = new Point(91, 62);
            lblSoA.Name = "lblSoA";
            lblSoA.Size = new Size(40, 20);
            lblSoA.TabIndex = 0;
            lblSoA.Text = "Số A";
            // 
            // lblSoB
            // 
            lblSoB.AutoSize = true;
            lblSoB.Location = new Point(91, 112);
            lblSoB.Name = "lblSoB";
            lblSoB.Size = new Size(39, 20);
            lblSoB.TabIndex = 1;
            lblSoB.Text = "Số B";
            // 
            // lblSoC
            // 
            lblSoC.AutoSize = true;
            lblSoC.Location = new Point(91, 168);
            lblSoC.Name = "lblSoC";
            lblSoC.Size = new Size(39, 20);
            lblSoC.TabIndex = 2;
            lblSoC.Text = "Số C";
            // 
            // lblKetQua
            // 
            lblKetQua.AutoSize = true;
            lblKetQua.Location = new Point(91, 247);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(60, 20);
            lblKetQua.TabIndex = 3;
            lblKetQua.Text = "Kết quả";
            // 
            // txtSoA
            // 
            txtSoA.Location = new Point(264, 62);
            txtSoA.Name = "txtSoA";
            txtSoA.Size = new Size(125, 27);
            txtSoA.TabIndex = 4;
            // 
            // txtSoB
            // 
            txtSoB.Location = new Point(264, 109);
            txtSoB.Name = "txtSoB";
            txtSoB.Size = new Size(125, 27);
            txtSoB.TabIndex = 5;
            // 
            // txtSoC
            // 
            txtSoC.Location = new Point(264, 168);
            txtSoC.Name = "txtSoC";
            txtSoC.Size = new Size(125, 27);
            txtSoC.TabIndex = 6;
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(264, 247);
            txtKetQua.Multiline = true;
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(325, 96);
            txtKetQua.TabIndex = 7;
            // 
            // btnPtBacI
            // 
            btnPtBacI.Location = new Point(237, 349);
            btnPtBacI.Name = "btnPtBacI";
            btnPtBacI.Size = new Size(132, 49);
            btnPtBacI.TabIndex = 8;
            btnPtBacI.Text = "Giải Pt Bậc I";
            btnPtBacI.UseVisualStyleBackColor = true;
            btnPtBacI.Click += btnPtBacI_Click;
            // 
            // btnPtBacII
            // 
            btnPtBacII.Location = new Point(478, 349);
            btnPtBacII.Name = "btnPtBacII";
            btnPtBacII.Size = new Size(148, 49);
            btnPtBacII.TabIndex = 9;
            btnPtBacII.Text = "Giải Pt Bậc II";
            btnPtBacII.UseVisualStyleBackColor = true;
            btnPtBacII.Click += btnPtBacII_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPtBacII);
            Controls.Add(btnPtBacI);
            Controls.Add(txtKetQua);
            Controls.Add(txtSoC);
            Controls.Add(txtSoB);
            Controls.Add(txtSoA);
            Controls.Add(lblKetQua);
            Controls.Add(lblSoC);
            Controls.Add(lblSoB);
            Controls.Add(lblSoA);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSoA;
        private Label lblSoB;
        private Label lblSoC;
        private Label lblKetQua;
        private TextBox txtSoA;
        private TextBox txtSoB;
        private TextBox txtSoC;
        private TextBox txtKetQua;
        private Button btnPtBacI;
        private Button btnPtBacII;
    }
}
