namespace WindowsFormsApplication1.Views
{
    partial class UserNhanVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupQLNV = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtidNhanVien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoLot = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dttNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbbGioiTinh = new System.Windows.Forms.ComboBox();
            this.dtvDSNhanVien = new System.Windows.Forms.DataGridView();
            this.bttThem = new System.Windows.Forms.Button();
            this.bttSua = new System.Windows.Forms.Button();
            this.bttXoa = new System.Windows.Forms.Button();
            this.bttLuu = new System.Windows.Forms.Button();
            this.bttHuy = new System.Windows.Forms.Button();
            this.bttTimKiem = new System.Windows.Forms.Button();
            this.bttTroLai = new System.Windows.Forms.Button();
            this.groupQLNV.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvDSNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupQLNV
            // 
            this.groupQLNV.Controls.Add(this.cbbGioiTinh);
            this.groupQLNV.Controls.Add(this.dttNgaySinh);
            this.groupQLNV.Controls.Add(this.label10);
            this.groupQLNV.Controls.Add(this.label6);
            this.groupQLNV.Controls.Add(this.label9);
            this.groupQLNV.Controls.Add(this.label5);
            this.groupQLNV.Controls.Add(this.label8);
            this.groupQLNV.Controls.Add(this.label4);
            this.groupQLNV.Controls.Add(this.label7);
            this.groupQLNV.Controls.Add(this.label3);
            this.groupQLNV.Controls.Add(this.txtDiaChi);
            this.groupQLNV.Controls.Add(this.txtTen);
            this.groupQLNV.Controls.Add(this.txtEmail);
            this.groupQLNV.Controls.Add(this.txtDienThoai);
            this.groupQLNV.Controls.Add(this.txtHoLot);
            this.groupQLNV.Controls.Add(this.txtidNhanVien);
            this.groupQLNV.Location = new System.Drawing.Point(63, 99);
            this.groupQLNV.Name = "groupQLNV";
            this.groupQLNV.Size = new System.Drawing.Size(361, 121);
            this.groupQLNV.TabIndex = 0;
            this.groupQLNV.TabStop = false;
            this.groupQLNV.Enter += new System.EventHandler(this.groupQLNV_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtvDSNhanVien);
            this.groupBox1.Location = new System.Drawing.Point(444, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupQLNV_Enter);
            // 
            // txtidNhanVien
            // 
            this.txtidNhanVien.Location = new System.Drawing.Point(81, 17);
            this.txtidNhanVien.Name = "txtidNhanVien";
            this.txtidNhanVien.Size = new System.Drawing.Size(100, 20);
            this.txtidNhanVien.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản Lý Nhân Viên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(565, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh Sách Nhân Viên";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Id Nhân Viên :";
            // 
            // txtHoLot
            // 
            this.txtHoLot.Location = new System.Drawing.Point(81, 43);
            this.txtHoLot.Name = "txtHoLot";
            this.txtHoLot.Size = new System.Drawing.Size(100, 20);
            this.txtHoLot.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Họ lót:";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(81, 69);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(100, 20);
            this.txtTen.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ngày Sinh :";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(252, 17);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(100, 20);
            this.txtDienThoai.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(252, 43);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 0;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(252, 69);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(100, 20);
            this.txtDiaChi.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(191, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Điện thoại :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(191, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Email :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(191, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Địa Chỉ ;";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(191, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Giới Tính :";
            // 
            // dttNgaySinh
            // 
            this.dttNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttNgaySinh.Location = new System.Drawing.Point(81, 92);
            this.dttNgaySinh.Name = "dttNgaySinh";
            this.dttNgaySinh.Size = new System.Drawing.Size(100, 20);
            this.dttNgaySinh.TabIndex = 2;
            // 
            // cbbGioiTinh
            // 
            this.cbbGioiTinh.FormattingEnabled = true;
            this.cbbGioiTinh.Location = new System.Drawing.Point(252, 90);
            this.cbbGioiTinh.Name = "cbbGioiTinh";
            this.cbbGioiTinh.Size = new System.Drawing.Size(100, 21);
            this.cbbGioiTinh.TabIndex = 3;
            // 
            // dtvDSNhanVien
            // 
            this.dtvDSNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvDSNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtvDSNhanVien.Location = new System.Drawing.Point(3, 16);
            this.dtvDSNhanVien.Name = "dtvDSNhanVien";
            this.dtvDSNhanVien.Size = new System.Drawing.Size(406, 102);
            this.dtvDSNhanVien.TabIndex = 0;
            // 
            // bttThem
            // 
            this.bttThem.Location = new System.Drawing.Point(73, 245);
            this.bttThem.Name = "bttThem";
            this.bttThem.Size = new System.Drawing.Size(59, 23);
            this.bttThem.TabIndex = 2;
            this.bttThem.Text = "Thêm";
            this.bttThem.UseVisualStyleBackColor = true;
            // 
            // bttSua
            // 
            this.bttSua.Location = new System.Drawing.Point(143, 245);
            this.bttSua.Name = "bttSua";
            this.bttSua.Size = new System.Drawing.Size(53, 23);
            this.bttSua.TabIndex = 2;
            this.bttSua.Text = "Sửa";
            this.bttSua.UseVisualStyleBackColor = true;
            // 
            // bttXoa
            // 
            this.bttXoa.Location = new System.Drawing.Point(208, 245);
            this.bttXoa.Name = "bttXoa";
            this.bttXoa.Size = new System.Drawing.Size(54, 23);
            this.bttXoa.TabIndex = 2;
            this.bttXoa.Text = "Xóa";
            this.bttXoa.UseVisualStyleBackColor = true;
            // 
            // bttLuu
            // 
            this.bttLuu.Location = new System.Drawing.Point(275, 245);
            this.bttLuu.Name = "bttLuu";
            this.bttLuu.Size = new System.Drawing.Size(51, 23);
            this.bttLuu.TabIndex = 2;
            this.bttLuu.Text = "Lưu";
            this.bttLuu.UseVisualStyleBackColor = true;
            // 
            // bttHuy
            // 
            this.bttHuy.Location = new System.Drawing.Point(340, 245);
            this.bttHuy.Name = "bttHuy";
            this.bttHuy.Size = new System.Drawing.Size(45, 23);
            this.bttHuy.TabIndex = 2;
            this.bttHuy.Text = "Hủy";
            this.bttHuy.UseVisualStyleBackColor = true;
            // 
            // bttTimKiem
            // 
            this.bttTimKiem.Location = new System.Drawing.Point(457, 245);
            this.bttTimKiem.Name = "bttTimKiem";
            this.bttTimKiem.Size = new System.Drawing.Size(64, 23);
            this.bttTimKiem.TabIndex = 2;
            this.bttTimKiem.Text = "Tìm Kiếm";
            this.bttTimKiem.UseVisualStyleBackColor = true;
            // 
            // bttTroLai
            // 
            this.bttTroLai.Location = new System.Drawing.Point(531, 245);
            this.bttTroLai.Name = "bttTroLai";
            this.bttTroLai.Size = new System.Drawing.Size(42, 23);
            this.bttTroLai.TabIndex = 2;
            this.bttTroLai.Text = "<<";
            this.bttTroLai.UseVisualStyleBackColor = true;
            // 
            // UserNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bttTroLai);
            this.Controls.Add(this.bttTimKiem);
            this.Controls.Add(this.bttLuu);
            this.Controls.Add(this.bttHuy);
            this.Controls.Add(this.bttXoa);
            this.Controls.Add(this.bttSua);
            this.Controls.Add(this.bttThem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupQLNV);
            this.Name = "UserNhanVien";
            this.Size = new System.Drawing.Size(919, 378);
            this.groupQLNV.ResumeLayout(false);
            this.groupQLNV.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtvDSNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupQLNV;
        private System.Windows.Forms.TextBox txtidNhanVien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbGioiTinh;
        private System.Windows.Forms.DateTimePicker dttNgaySinh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtHoLot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtvDSNhanVien;
        private System.Windows.Forms.Button bttThem;
        private System.Windows.Forms.Button bttSua;
        private System.Windows.Forms.Button bttXoa;
        private System.Windows.Forms.Button bttLuu;
        private System.Windows.Forms.Button bttHuy;
        private System.Windows.Forms.Button bttTimKiem;
        private System.Windows.Forms.Button bttTroLai;
    }
}
