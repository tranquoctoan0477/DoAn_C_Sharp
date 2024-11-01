namespace DoAnC_.UI
{
    partial class FrmThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.lblNgayKetThuc = new System.Windows.Forms.Label();
            this.lblNgayBatDau = new System.Windows.Forms.Label();
            this.btnDoanhThu = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.rbtThongKeTheoNgay = new System.Windows.Forms.RadioButton();
            this.rbtThongKeTheoThang = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtThongKeTheoThang);
            this.groupBox1.Controls.Add(this.rbtThongKeTheoNgay);
            this.groupBox1.Controls.Add(this.dtpNgayKetThuc);
            this.groupBox1.Controls.Add(this.dtpNgayBatDau);
            this.groupBox1.Controls.Add(this.lblNgayKetThuc);
            this.groupBox1.Controls.Add(this.lblNgayBatDau);
            this.groupBox1.Location = new System.Drawing.Point(12, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 276);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(190, 89);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(200, 22);
            this.dtpNgayKetThuc.TabIndex = 1;
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.Location = new System.Drawing.Point(190, 41);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(200, 22);
            this.dtpNgayBatDau.TabIndex = 1;
            // 
            // lblNgayKetThuc
            // 
            this.lblNgayKetThuc.AutoSize = true;
            this.lblNgayKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayKetThuc.Location = new System.Drawing.Point(28, 89);
            this.lblNgayKetThuc.Name = "lblNgayKetThuc";
            this.lblNgayKetThuc.Size = new System.Drawing.Size(130, 22);
            this.lblNgayKetThuc.TabIndex = 0;
            this.lblNgayKetThuc.Text = "Ngày Bắt Thúc";
            // 
            // lblNgayBatDau
            // 
            this.lblNgayBatDau.AutoSize = true;
            this.lblNgayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayBatDau.Location = new System.Drawing.Point(28, 41);
            this.lblNgayBatDau.Name = "lblNgayBatDau";
            this.lblNgayBatDau.Size = new System.Drawing.Size(119, 22);
            this.lblNgayBatDau.TabIndex = 0;
            this.lblNgayBatDau.Text = "Ngày Bắt đầu";
            // 
            // btnDoanhThu
            // 
            this.btnDoanhThu.Location = new System.Drawing.Point(12, 12);
            this.btnDoanhThu.Name = "btnDoanhThu";
            this.btnDoanhThu.Size = new System.Drawing.Size(147, 85);
            this.btnDoanhThu.TabIndex = 1;
            this.btnDoanhThu.Text = "DoanhThu";
            this.btnDoanhThu.UseVisualStyleBackColor = true;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(348, 522);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(110, 40);
            this.btnThongKe.TabIndex = 2;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // rbtThongKeTheoNgay
            // 
            this.rbtThongKeTheoNgay.AutoSize = true;
            this.rbtThongKeTheoNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtThongKeTheoNgay.Location = new System.Drawing.Point(468, 44);
            this.rbtThongKeTheoNgay.Name = "rbtThongKeTheoNgay";
            this.rbtThongKeTheoNgay.Size = new System.Drawing.Size(191, 26);
            this.rbtThongKeTheoNgay.TabIndex = 2;
            this.rbtThongKeTheoNgay.TabStop = true;
            this.rbtThongKeTheoNgay.Text = "Thống kê theo ngày";
            this.rbtThongKeTheoNgay.UseVisualStyleBackColor = true;
            this.rbtThongKeTheoNgay.CheckedChanged += new System.EventHandler(this.rbtThongKeTheoNgay_CheckedChanged);
            // 
            // rbtThongKeTheoThang
            // 
            this.rbtThongKeTheoThang.AutoSize = true;
            this.rbtThongKeTheoThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtThongKeTheoThang.Location = new System.Drawing.Point(468, 89);
            this.rbtThongKeTheoThang.Name = "rbtThongKeTheoThang";
            this.rbtThongKeTheoThang.Size = new System.Drawing.Size(197, 26);
            this.rbtThongKeTheoThang.TabIndex = 2;
            this.rbtThongKeTheoThang.TabStop = true;
            this.rbtThongKeTheoThang.Text = "Thống kê theo tháng";
            this.rbtThongKeTheoThang.UseVisualStyleBackColor = true;
            this.rbtThongKeTheoThang.CheckedChanged += new System.EventHandler(this.rbtThongKeTheoThang_CheckedChanged);
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 588);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnDoanhThu);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmThongKe";
            this.Text = "ThongKe";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDoanhThu;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.Label lblNgayKetThuc;
        private System.Windows.Forms.Label lblNgayBatDau;
        private System.Windows.Forms.RadioButton rbtThongKeTheoThang;
        private System.Windows.Forms.RadioButton rbtThongKeTheoNgay;
    }
}