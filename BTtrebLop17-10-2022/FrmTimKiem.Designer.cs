
namespace BTtrebLop17_10_2022
{
    partial class FrmTimKiem
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
            this.lblThongBao = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.optMaNV = new System.Windows.Forms.RadioButton();
            this.optMaPhong = new System.Windows.Forms.RadioButton();
            this.optMaTK = new System.Windows.Forms.RadioButton();
            this.dataGridViewTimKiem = new System.Windows.Forms.DataGridView();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.cboMaPhong = new System.Windows.Forms.ComboBox();
            this.cboMaLoaiTK = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBao.Location = new System.Drawing.Point(371, 11);
            this.lblThongBao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(234, 31);
            this.lblThongBao.TabIndex = 0;
            this.lblThongBao.Text = "Tìm kiếm thông tin";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(851, 83);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(135, 55);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(851, 164);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(135, 55);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // optMaNV
            // 
            this.optMaNV.AutoSize = true;
            this.optMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optMaNV.Location = new System.Drawing.Point(103, 83);
            this.optMaNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optMaNV.Name = "optMaNV";
            this.optMaNV.Size = new System.Drawing.Size(193, 28);
            this.optMaNV.TabIndex = 2;
            this.optMaNV.TabStop = true;
            this.optMaNV.Text = "Nhập mã nhân viên";
            this.optMaNV.UseVisualStyleBackColor = true;
            // 
            // optMaPhong
            // 
            this.optMaPhong.AutoSize = true;
            this.optMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optMaPhong.Location = new System.Drawing.Point(103, 131);
            this.optMaPhong.Margin = new System.Windows.Forms.Padding(4);
            this.optMaPhong.Name = "optMaPhong";
            this.optMaPhong.Size = new System.Drawing.Size(197, 28);
            this.optMaPhong.TabIndex = 2;
            this.optMaPhong.TabStop = true;
            this.optMaPhong.Text = "Nhập mã phòng GD";
            this.optMaPhong.UseVisualStyleBackColor = true;
            // 
            // optMaTK
            // 
            this.optMaTK.AutoSize = true;
            this.optMaTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optMaTK.Location = new System.Drawing.Point(103, 177);
            this.optMaTK.Margin = new System.Windows.Forms.Padding(4);
            this.optMaTK.Name = "optMaTK";
            this.optMaTK.Size = new System.Drawing.Size(219, 28);
            this.optMaTK.TabIndex = 2;
            this.optMaTK.TabStop = true;
            this.optMaTK.Text = "Nhập mã loại tài khoản";
            this.optMaTK.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTimKiem
            // 
            this.dataGridViewTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTimKiem.Location = new System.Drawing.Point(105, 259);
            this.dataGridViewTimKiem.Name = "dataGridViewTimKiem";
            this.dataGridViewTimKiem.Size = new System.Drawing.Size(736, 271);
            this.dataGridViewTimKiem.TabIndex = 4;
            // 
            // cboMaNV
            // 
            this.cboMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(377, 79);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(342, 32);
            this.cboMaNV.TabIndex = 5;
            // 
            // cboMaPhong
            // 
            this.cboMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaPhong.FormattingEnabled = true;
            this.cboMaPhong.Location = new System.Drawing.Point(377, 127);
            this.cboMaPhong.Name = "cboMaPhong";
            this.cboMaPhong.Size = new System.Drawing.Size(342, 32);
            this.cboMaPhong.TabIndex = 5;
            // 
            // cboMaLoaiTK
            // 
            this.cboMaLoaiTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaLoaiTK.FormattingEnabled = true;
            this.cboMaLoaiTK.Location = new System.Drawing.Point(377, 173);
            this.cboMaLoaiTK.Name = "cboMaLoaiTK";
            this.cboMaLoaiTK.Size = new System.Drawing.Size(342, 32);
            this.cboMaLoaiTK.TabIndex = 5;
            // 
            // FrmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.cboMaLoaiTK);
            this.Controls.Add(this.cboMaPhong);
            this.Controls.Add(this.cboMaNV);
            this.Controls.Add(this.dataGridViewTimKiem);
            this.Controls.Add(this.optMaTK);
            this.Controls.Add(this.optMaPhong);
            this.Controls.Add(this.optMaNV);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.lblThongBao);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmTimKiem";
            this.Text = "Tìm kiếm";
            this.Load += new System.EventHandler(this.FrmTimKiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimKiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.RadioButton optMaNV;
        private System.Windows.Forms.RadioButton optMaPhong;
        private System.Windows.Forms.RadioButton optMaTK;
        private System.Windows.Forms.DataGridView dataGridViewTimKiem;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.ComboBox cboMaPhong;
        private System.Windows.Forms.ComboBox cboMaLoaiTK;
    }
}