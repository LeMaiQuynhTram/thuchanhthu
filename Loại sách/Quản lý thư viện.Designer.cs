namespace Loại_sách
{
    partial class LoaiSach
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
            this.Taomoi = new System.Windows.Forms.Button();
            this.Chinhsua = new System.Windows.Forms.Button();
            this.Timkiem = new System.Windows.Forms.Button();
            this.Luu = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MaLS = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Taomoi
            // 
            this.Taomoi.BackColor = System.Drawing.SystemColors.Highlight;
            this.Taomoi.Location = new System.Drawing.Point(64, 238);
            this.Taomoi.Name = "Taomoi";
            this.Taomoi.Size = new System.Drawing.Size(77, 46);
            this.Taomoi.TabIndex = 0;
            this.Taomoi.Text = "Tạo mới";
            this.Taomoi.UseVisualStyleBackColor = false;
            // 
            // Chinhsua
            // 
            this.Chinhsua.BackColor = System.Drawing.SystemColors.Highlight;
            this.Chinhsua.Location = new System.Drawing.Point(221, 238);
            this.Chinhsua.Name = "Chinhsua";
            this.Chinhsua.Size = new System.Drawing.Size(104, 46);
            this.Chinhsua.TabIndex = 1;
            this.Chinhsua.Text = "Chỉnh sửa";
            this.Chinhsua.UseVisualStyleBackColor = false;
            // 
            // Timkiem
            // 
            this.Timkiem.BackColor = System.Drawing.SystemColors.Highlight;
            this.Timkiem.Location = new System.Drawing.Point(414, 238);
            this.Timkiem.Name = "Timkiem";
            this.Timkiem.Size = new System.Drawing.Size(87, 46);
            this.Timkiem.TabIndex = 2;
            this.Timkiem.Text = "Tìm kiếm";
            this.Timkiem.UseVisualStyleBackColor = false;
            // 
            // Luu
            // 
            this.Luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Luu.Location = new System.Drawing.Point(581, 238);
            this.Luu.Name = "Luu";
            this.Luu.Size = new System.Drawing.Size(75, 46);
            this.Luu.TabIndex = 3;
            this.Luu.Text = "Lưu";
            this.Luu.UseVisualStyleBackColor = false;
            // 
            // Xoa
            // 
            this.Xoa.BackColor = System.Drawing.Color.Red;
            this.Xoa.Location = new System.Drawing.Point(749, 238);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(72, 46);
            this.Xoa.TabIndex = 4;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(51, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên loại sách";
            // 
            // MaLS
            // 
            this.MaLS.AutoSize = true;
            this.MaLS.BackColor = System.Drawing.Color.Transparent;
            this.MaLS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MaLS.Location = new System.Drawing.Point(59, 59);
            this.MaLS.Name = "MaLS";
            this.MaLS.Size = new System.Drawing.Size(134, 25);
            this.MaLS.TabIndex = 6;
            this.MaLS.Text = "Mã loại sách";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(237, 42);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 42);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(237, 112);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(209, 39);
            this.textBox2.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 317);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(809, 295);
            this.dataGridView1.TabIndex = 9;
            // 
            // LoaiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Loại_sách.Properties.Resources.pngtree_simple_literary_home_life_psd_layered_master_map_background_material_image_1492111;
            this.ClientSize = new System.Drawing.Size(890, 641);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.MaLS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.Luu);
            this.Controls.Add(this.Timkiem);
            this.Controls.Add(this.Chinhsua);
            this.Controls.Add(this.Taomoi);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoaiSach";
            this.Text = "Loại sách";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Taomoi;
        private System.Windows.Forms.Button Chinhsua;
        private System.Windows.Forms.Button Timkiem;
        private System.Windows.Forms.Button Luu;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MaLS;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

