namespace quanlynhanvien
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_manv = new System.Windows.Forms.Label();
            this.tb_manv = new System.Windows.Forms.TextBox();
            this.lb_tennv = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_hesl = new System.Windows.Forms.Label();
            this.lb_luong = new System.Windows.Forms.Label();
            this.tb_tennv = new System.Windows.Forms.TextBox();
            this.tb_hsl = new System.Windows.Forms.TextBox();
            this.dt_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.tb_luong = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.lb_gt = new System.Windows.Forms.Label();
            this.lb_ngaysinh = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_timkiem = new System.Windows.Forms.Button();
            this.bt_sapxep = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(434, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // lb_manv
            // 
            this.lb_manv.AutoSize = true;
            this.lb_manv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_manv.Location = new System.Drawing.Point(73, 76);
            this.lb_manv.Name = "lb_manv";
            this.lb_manv.Size = new System.Drawing.Size(95, 18);
            this.lb_manv.TabIndex = 1;
            this.lb_manv.Text = "Mã nhân viên";
            // 
            // tb_manv
            // 
            this.tb_manv.Location = new System.Drawing.Point(197, 75);
            this.tb_manv.Name = "tb_manv";
            this.tb_manv.Size = new System.Drawing.Size(236, 22);
            this.tb_manv.TabIndex = 2;
            // 
            // lb_tennv
            // 
            this.lb_tennv.AutoSize = true;
            this.lb_tennv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tennv.Location = new System.Drawing.Point(73, 126);
            this.lb_tennv.Name = "lb_tennv";
            this.lb_tennv.Size = new System.Drawing.Size(99, 18);
            this.lb_tennv.TabIndex = 3;
            this.lb_tennv.Text = "Tên nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 18);
            this.label4.TabIndex = 4;
            // 
            // lb_hesl
            // 
            this.lb_hesl.AutoSize = true;
            this.lb_hesl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hesl.Location = new System.Drawing.Point(75, 277);
            this.lb_hesl.Name = "lb_hesl";
            this.lb_hesl.Size = new System.Drawing.Size(88, 18);
            this.lb_hesl.TabIndex = 5;
            this.lb_hesl.Text = "Hệ số lương";
            // 
            // lb_luong
            // 
            this.lb_luong.AutoSize = true;
            this.lb_luong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_luong.Location = new System.Drawing.Point(93, 330);
            this.lb_luong.Name = "lb_luong";
            this.lb_luong.Size = new System.Drawing.Size(49, 18);
            this.lb_luong.TabIndex = 6;
            this.lb_luong.Text = "Lương";
            // 
            // tb_tennv
            // 
            this.tb_tennv.Location = new System.Drawing.Point(197, 125);
            this.tb_tennv.Name = "tb_tennv";
            this.tb_tennv.Size = new System.Drawing.Size(236, 22);
            this.tb_tennv.TabIndex = 7;
            // 
            // tb_hsl
            // 
            this.tb_hsl.Location = new System.Drawing.Point(197, 273);
            this.tb_hsl.Name = "tb_hsl";
            this.tb_hsl.Size = new System.Drawing.Size(236, 22);
            this.tb_hsl.TabIndex = 8;
            // 
            // dt_ngaysinh
            // 
            this.dt_ngaysinh.Location = new System.Drawing.Point(197, 174);
            this.dt_ngaysinh.Name = "dt_ngaysinh";
            this.dt_ngaysinh.Size = new System.Drawing.Size(200, 22);
            this.dt_ngaysinh.TabIndex = 9;
            // 
            // tb_luong
            // 
            this.tb_luong.Location = new System.Drawing.Point(194, 330);
            this.tb_luong.Name = "tb_luong";
            this.tb_luong.Size = new System.Drawing.Size(236, 22);
            this.tb_luong.TabIndex = 11;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(197, 222);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 20);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(335, 222);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(95, 20);
            this.checkBox2.TabIndex = 14;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // lb_gt
            // 
            this.lb_gt.AutoSize = true;
            this.lb_gt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gt.Location = new System.Drawing.Point(84, 221);
            this.lb_gt.Name = "lb_gt";
            this.lb_gt.Size = new System.Drawing.Size(62, 18);
            this.lb_gt.TabIndex = 15;
            this.lb_gt.Text = "Giới tính";
            // 
            // lb_ngaysinh
            // 
            this.lb_ngaysinh.AutoSize = true;
            this.lb_ngaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ngaysinh.Location = new System.Drawing.Point(69, 177);
            this.lb_ngaysinh.Name = "lb_ngaysinh";
            this.lb_ngaysinh.Size = new System.Drawing.Size(73, 18);
            this.lb_ngaysinh.TabIndex = 16;
            this.lb_ngaysinh.Text = "Ngày sinh";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Location = new System.Drawing.Point(87, 389);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(807, 230);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(9, 21);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(792, 203);
            this.dgv.TabIndex = 0;
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(791, 70);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(103, 40);
            this.bt_them.TabIndex = 18;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(791, 139);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(103, 40);
            this.bt_sua.TabIndex = 19;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(791, 202);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(103, 40);
            this.bt_xoa.TabIndex = 20;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            // 
            // bt_timkiem
            // 
            this.bt_timkiem.Location = new System.Drawing.Point(791, 264);
            this.bt_timkiem.Name = "bt_timkiem";
            this.bt_timkiem.Size = new System.Drawing.Size(103, 40);
            this.bt_timkiem.TabIndex = 21;
            this.bt_timkiem.Text = "Tìm kiếm";
            this.bt_timkiem.UseVisualStyleBackColor = true;
            this.bt_timkiem.Click += new System.EventHandler(this.bt_timkiem_Click);
            // 
            // bt_sapxep
            // 
            this.bt_sapxep.Location = new System.Drawing.Point(791, 321);
            this.bt_sapxep.Name = "bt_sapxep";
            this.bt_sapxep.Size = new System.Drawing.Size(103, 40);
            this.bt_sapxep.TabIndex = 22;
            this.bt_sapxep.Text = "Sắp xếp";
            this.bt_sapxep.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 631);
            this.Controls.Add(this.bt_sapxep);
            this.Controls.Add(this.bt_timkiem);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_ngaysinh);
            this.Controls.Add(this.lb_gt);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tb_luong);
            this.Controls.Add(this.dt_ngaysinh);
            this.Controls.Add(this.tb_hsl);
            this.Controls.Add(this.tb_tennv);
            this.Controls.Add(this.lb_luong);
            this.Controls.Add(this.lb_hesl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_tennv);
            this.Controls.Add(this.tb_manv);
            this.Controls.Add(this.lb_manv);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_manv;
        private System.Windows.Forms.TextBox tb_manv;
        private System.Windows.Forms.Label lb_tennv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_hesl;
        private System.Windows.Forms.Label lb_luong;
        private System.Windows.Forms.TextBox tb_tennv;
        private System.Windows.Forms.TextBox tb_hsl;
        private System.Windows.Forms.DateTimePicker dt_ngaysinh;
        private System.Windows.Forms.TextBox tb_luong;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label lb_gt;
        private System.Windows.Forms.Label lb_ngaysinh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_timkiem;
        private System.Windows.Forms.Button bt_sapxep;
    }
}

