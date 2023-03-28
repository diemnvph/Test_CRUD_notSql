namespace Test_CRUD_notSql
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
            this.label122 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgridTimkiem = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.tbxMa = new System.Windows.Forms.TextBox();
            this.tbxQuocgia = new System.Windows.Forms.TextBox();
            this.tbxTimkiem = new System.Windows.Forms.TextBox();
            this.tbxDiachi = new System.Windows.Forms.TextBox();
            this.tbxTen = new System.Windows.Forms.TextBox();
            this.rbtnHoatdong = new System.Windows.Forms.RadioButton();
            this.tbtnKohoatdong = new System.Windows.Forms.RadioButton();
            this.cmbThanhpho = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgridTimkiem)).BeginInit();
            this.SuspendLayout();
            // 
            // label122
            // 
            this.label122.AutoSize = true;
            this.label122.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label122.Location = new System.Drawing.Point(76, 37);
            this.label122.Name = "label122";
            this.label122.Size = new System.Drawing.Size(47, 22);
            this.label122.TabIndex = 0;
            this.label122.Text = "Mã :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tình Trạng :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quốc Gia :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Thành phố :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Đại chỉ :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(72, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tên :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tìm kiếm :";
            // 
            // dgridTimkiem
            // 
            this.dgridTimkiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridTimkiem.Location = new System.Drawing.Point(12, 402);
            this.dgridTimkiem.Name = "dgridTimkiem";
            this.dgridTimkiem.RowHeadersWidth = 51;
            this.dgridTimkiem.RowTemplate.Height = 24;
            this.dgridTimkiem.Size = new System.Drawing.Size(808, 142);
            this.dgridTimkiem.TabIndex = 7;
            this.dgridTimkiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridTimkiem_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(581, 52);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(99, 57);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(581, 210);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(99, 58);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(581, 136);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(99, 54);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // tbxMa
            // 
            this.tbxMa.Location = new System.Drawing.Point(152, 29);
            this.tbxMa.Multiline = true;
            this.tbxMa.Name = "tbxMa";
            this.tbxMa.Size = new System.Drawing.Size(196, 30);
            this.tbxMa.TabIndex = 11;
            // 
            // tbxQuocgia
            // 
            this.tbxQuocgia.Location = new System.Drawing.Point(152, 238);
            this.tbxQuocgia.Multiline = true;
            this.tbxQuocgia.Name = "tbxQuocgia";
            this.tbxQuocgia.Size = new System.Drawing.Size(196, 30);
            this.tbxQuocgia.TabIndex = 12;
            // 
            // tbxTimkiem
            // 
            this.tbxTimkiem.Location = new System.Drawing.Point(152, 353);
            this.tbxTimkiem.Multiline = true;
            this.tbxTimkiem.Name = "tbxTimkiem";
            this.tbxTimkiem.Size = new System.Drawing.Size(196, 30);
            this.tbxTimkiem.TabIndex = 13;
            this.tbxTimkiem.TextChanged += new System.EventHandler(this.tbxTimkiem_TextChanged);
            // 
            // tbxDiachi
            // 
            this.tbxDiachi.Location = new System.Drawing.Point(152, 128);
            this.tbxDiachi.Multiline = true;
            this.tbxDiachi.Name = "tbxDiachi";
            this.tbxDiachi.Size = new System.Drawing.Size(196, 30);
            this.tbxDiachi.TabIndex = 14;
            // 
            // tbxTen
            // 
            this.tbxTen.Location = new System.Drawing.Point(152, 79);
            this.tbxTen.Multiline = true;
            this.tbxTen.Name = "tbxTen";
            this.tbxTen.Size = new System.Drawing.Size(196, 30);
            this.tbxTen.TabIndex = 15;
            // 
            // rbtnHoatdong
            // 
            this.rbtnHoatdong.AutoSize = true;
            this.rbtnHoatdong.Location = new System.Drawing.Point(152, 309);
            this.rbtnHoatdong.Name = "rbtnHoatdong";
            this.rbtnHoatdong.Size = new System.Drawing.Size(123, 20);
            this.rbtnHoatdong.TabIndex = 16;
            this.rbtnHoatdong.TabStop = true;
            this.rbtnHoatdong.Text = "Đang hoạt động";
            this.rbtnHoatdong.UseVisualStyleBackColor = true;
            // 
            // tbtnKohoatdong
            // 
            this.tbtnKohoatdong.AutoSize = true;
            this.tbtnKohoatdong.Location = new System.Drawing.Point(306, 309);
            this.tbtnKohoatdong.Name = "tbtnKohoatdong";
            this.tbtnKohoatdong.Size = new System.Drawing.Size(129, 20);
            this.tbtnKohoatdong.TabIndex = 17;
            this.tbtnKohoatdong.TabStop = true;
            this.tbtnKohoatdong.Text = "Không hoạt động";
            this.tbtnKohoatdong.UseVisualStyleBackColor = true;
            // 
            // cmbThanhpho
            // 
            this.cmbThanhpho.FormattingEnabled = true;
            this.cmbThanhpho.Location = new System.Drawing.Point(152, 187);
            this.cmbThanhpho.Name = "cmbThanhpho";
            this.cmbThanhpho.Size = new System.Drawing.Size(196, 24);
            this.cmbThanhpho.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 543);
            this.Controls.Add(this.cmbThanhpho);
            this.Controls.Add(this.tbtnKohoatdong);
            this.Controls.Add(this.rbtnHoatdong);
            this.Controls.Add(this.tbxTen);
            this.Controls.Add(this.tbxDiachi);
            this.Controls.Add(this.tbxTimkiem);
            this.Controls.Add(this.tbxQuocgia);
            this.Controls.Add(this.tbxMa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgridTimkiem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label122);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgridTimkiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label122;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgridTimkiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox tbxMa;
        private System.Windows.Forms.TextBox tbxQuocgia;
        private System.Windows.Forms.TextBox tbxTimkiem;
        private System.Windows.Forms.TextBox tbxDiachi;
        private System.Windows.Forms.TextBox tbxTen;
        private System.Windows.Forms.RadioButton rbtnHoatdong;
        private System.Windows.Forms.RadioButton tbtnKohoatdong;
        private System.Windows.Forms.ComboBox cmbThanhpho;
    }
}

