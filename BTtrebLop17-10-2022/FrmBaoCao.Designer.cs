
namespace BTtrebLop17_10_2022
{
    partial class FrmBaoCao
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
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.crystalReportViewerBaoCao = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.Location = new System.Drawing.Point(629, 12);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(121, 36);
            this.btnBaoCao.TabIndex = 0;
            this.btnBaoCao.Text = "Báo cáo ";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(629, 54);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(121, 36);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNV.Location = new System.Drawing.Point(98, 41);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(124, 24);
            this.lblMaNV.TabIndex = 1;
            this.lblMaNV.Text = "Mã nhân viên";
            // 
            // cboMaNV
            // 
            this.cboMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(268, 33);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(290, 32);
            this.cboMaNV.TabIndex = 2;
            this.cboMaNV.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // crystalReportViewerBaoCao
            // 
            this.crystalReportViewerBaoCao.ActiveViewIndex = -1;
            this.crystalReportViewerBaoCao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerBaoCao.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerBaoCao.Location = new System.Drawing.Point(33, 114);
            this.crystalReportViewerBaoCao.Name = "crystalReportViewerBaoCao";
            this.crystalReportViewerBaoCao.Size = new System.Drawing.Size(717, 324);
            this.crystalReportViewerBaoCao.TabIndex = 3;
            // 
            // FrmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewerBaoCao);
            this.Controls.Add(this.cboMaNV);
            this.Controls.Add(this.lblMaNV);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnBaoCao);
            this.Name = "FrmBaoCao";
            this.Text = "Báo cáo thông tin nhân viên ";
            this.Load += new System.EventHandler(this.FrmBaoCao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.ComboBox cboMaNV;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerBaoCao;
    }
}