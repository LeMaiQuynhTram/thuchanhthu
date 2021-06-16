namespace WindowsFormsApplication1
{
    partial class Quanlythuvien
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
            this.HoTen = new System.Windows.Forms.TextBox();
            this.MaNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BoPhan = new System.Windows.Forms.TextBox();
            this.SDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Nu = new System.Windows.Forms.RadioButton();
            this.Nam = new System.Windows.Forms.RadioButton();
            this.Taomoi = new System.Windows.Forms.Button();
            this.Timkiem = new System.Windows.Forms.Button();
            this.Chinhsua = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.Luu = new System.Windows.Forms.Button();
            this.NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(44, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // HoTen
            // 
            this.HoTen.Location = new System.Drawing.Point(219, 72);
            this.HoTen.Multiline = true;
            this.HoTen.Name = "HoTen";
            this.HoTen.Size = new System.Drawing.Size(245, 36);
            this.HoTen.TabIndex = 1;
            this.HoTen.TabStop = false;
            // 
            // MaNV
            // 
            this.MaNV.BackColor = System.Drawing.Color.White;
            this.MaNV.ForeColor = System.Drawing.Color.Black;
            this.MaNV.Location = new System.Drawing.Point(219, 21);
            this.MaNV.Multiline = true;
            this.MaNV.Name = "MaNV";
            this.MaNV.Size = new System.Drawing.Size(245, 36);
            this.MaNV.TabIndex = 0;
            this.MaNV.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(613, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(613, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(45, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bộ phận";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(44, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Số điện thoại";
            // 
            // BoPhan
            // 
            this.BoPhan.Location = new System.Drawing.Point(219, 138);
            this.BoPhan.Multiline = true;
            this.BoPhan.Name = "BoPhan";
            this.BoPhan.Size = new System.Drawing.Size(236, 33);
            this.BoPhan.TabIndex = 6;
            // 
            // SDT
            // 
            this.SDT.Location = new System.Drawing.Point(219, 215);
            this.SDT.Multiline = true;
            this.SDT.Name = "SDT";
            this.SDT.Size = new System.Drawing.Size(236, 34);
            this.SDT.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(45, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Họ tên";
            // 
            // Nu
            // 
            this.Nu.BackColor = System.Drawing.Color.White;
            this.Nu.Location = new System.Drawing.Point(921, 73);
            this.Nu.Name = "Nu";
            this.Nu.Size = new System.Drawing.Size(83, 35);
            this.Nu.TabIndex = 5;
            this.Nu.TabStop = true;
            this.Nu.Text = "Nữ";
            this.Nu.UseVisualStyleBackColor = false;
            this.Nu.CheckedChanged += new System.EventHandler(this.Nu_CheckedChanged);
            // 
            // Nam
            // 
            this.Nam.BackColor = System.Drawing.Color.White;
            this.Nam.Location = new System.Drawing.Point(782, 72);
            this.Nam.Name = "Nam";
            this.Nam.Size = new System.Drawing.Size(74, 33);
            this.Nam.TabIndex = 4;
            this.Nam.TabStop = true;
            this.Nam.Text = "Nam";
            this.Nam.UseVisualStyleBackColor = false;
            // 
            // Taomoi
            // 
            this.Taomoi.BackColor = System.Drawing.SystemColors.Highlight;
            this.Taomoi.Location = new System.Drawing.Point(129, 280);
            this.Taomoi.Name = "Taomoi";
            this.Taomoi.Size = new System.Drawing.Size(97, 52);
            this.Taomoi.TabIndex = 8;
            this.Taomoi.Text = "Tạo mới";
            this.Taomoi.UseVisualStyleBackColor = false;
            // 
            // Timkiem
            // 
            this.Timkiem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Timkiem.Location = new System.Drawing.Point(494, 280);
            this.Timkiem.Name = "Timkiem";
            this.Timkiem.Size = new System.Drawing.Size(92, 52);
            this.Timkiem.TabIndex = 10;
            this.Timkiem.Text = "Tìm kiếm";
            this.Timkiem.UseVisualStyleBackColor = false;
            this.Timkiem.Click += new System.EventHandler(this.Timkiem_Click);
            // 
            // Chinhsua
            // 
            this.Chinhsua.BackColor = System.Drawing.SystemColors.Highlight;
            this.Chinhsua.Location = new System.Drawing.Point(308, 280);
            this.Chinhsua.Name = "Chinhsua";
            this.Chinhsua.Size = new System.Drawing.Size(95, 52);
            this.Chinhsua.TabIndex = 9;
            this.Chinhsua.Text = "Chỉnh sửa";
            this.Chinhsua.UseVisualStyleBackColor = false;
            // 
            // Xoa
            // 
            this.Xoa.BackColor = System.Drawing.Color.Red;
            this.Xoa.Location = new System.Drawing.Point(861, 280);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(88, 52);
            this.Xoa.TabIndex = 12;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseVisualStyleBackColor = false;
            // 
            // Luu
            // 
            this.Luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Luu.Location = new System.Drawing.Point(681, 280);
            this.Luu.Name = "Luu";
            this.Luu.Size = new System.Drawing.Size(92, 52);
            this.Luu.TabIndex = 11;
            this.Luu.Text = "Lưu";
            this.Luu.UseVisualStyleBackColor = false;
            // 
            // NgaySinh
            // 
            this.NgaySinh.Location = new System.Drawing.Point(782, 21);
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Size = new System.Drawing.Size(298, 26);
            this.NgaySinh.TabIndex = 2;
            this.NgaySinh.ValueChanged += new System.EventHandler(this.NgaySinh_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 371);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(986, 302);
            this.dataGridView1.TabIndex = 21;
            // 
            // Quanlythuvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.pngtree_simple_literary_home_life_psd_layered_master_map_background_material_image_1492111;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1114, 685);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.NgaySinh);
            this.Controls.Add(this.Luu);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.Chinhsua);
            this.Controls.Add(this.Timkiem);
            this.Controls.Add(this.Taomoi);
            this.Controls.Add(this.Nam);
            this.Controls.Add(this.Nu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SDT);
            this.Controls.Add(this.BoPhan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MaNV);
            this.Controls.Add(this.HoTen);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Quanlythuvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý thư viện";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Quanlythuvien_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HoTen;
        private System.Windows.Forms.TextBox MaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BoPhan;
        private System.Windows.Forms.TextBox SDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton Nu;
        private System.Windows.Forms.RadioButton Nam;
        private System.Windows.Forms.Button Taomoi;
        private System.Windows.Forms.Button Timkiem;
        private System.Windows.Forms.Button Chinhsua;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Button Luu;
        private System.Windows.Forms.DateTimePicker NgaySinh;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

