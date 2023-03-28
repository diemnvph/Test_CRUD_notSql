using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test_CRUD_notSql.Controller;
using Test_CRUD_notSql.Model;

namespace Test_CRUD_notSql
{
    public partial class Form1 : Form
    {
        QuanLiNhanVien _qlyNhanVien = new QuanLiNhanVien();
        Guid _idWhenClick;
        public Form1()
        {
            InitializeComponent();
            _qlyNhanVien = new QuanLiNhanVien();
            GetdataCity();
            GetdataNV(null);

        }
        public void GetdataCity()
        {
            foreach (var item in _qlyNhanVien.GettCity())
            {
                cmbThanhpho.Items.Add(item);
            }
        }
        public void GetdataNV(string input)
        {
            int stt = 1;
            Type type = typeof(NhanVien);
            //gán số cột của đối tượng = số thuộc tính của đối tượng + 1
            DataTable dt = new DataTable();
            dt.Columns.Add("STT",typeof(int));
            dt.Columns.Add("Id",typeof(Guid));
            dt.Columns.Add("Mã",typeof(string));
            dt.Columns.Add("Tên",typeof(string));
            dt.Columns.Add("địa chỉ",typeof(string));
            dt.Columns.Add("thành phố",typeof(string));
            dt.Columns.Add("quốc gia",typeof(string));
            dt.Columns.Add("status",typeof(string));
            foreach (var x in _qlyNhanVien.GetNhanViens(input))
            {
               dt.Rows.Add(stt++,x.id,x.ma,x.ten,x.diaChi,x.thanhPho,x.quocGia,x.status == true ? " Đang Hoạt động" : " Không hoạt động");
            }
            dgridTimkiem.DataSource = dt;
        }

        private void dgridTimkiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // kích hoạt 3 button
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            // lấy index
            int index = e.RowIndex;
            // check nếu ngoài phạm vi
            if (index == -1 || index >= _qlyNhanVien.GetNhanViens(null).Count)
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                return;
            }
            // lấy khóa của rows
            _idWhenClick = Guid.Parse(dgridTimkiem.Rows[index].Cells[1].Value.ToString());

            // Tạo đối tượng với id trung với id trong list
            var obj = _qlyNhanVien.GetNhanViens(null).FirstOrDefault(x=>x.id == _idWhenClick);

            //gán thuộc tính
            tbxMa.Text = obj.ma;
            tbxTen.Text = obj.ten;
            tbxDiachi.Text = obj.diaChi;
            cmbThanhpho.Text = obj.thanhPho;
            tbxQuocgia.Text = obj.quocGia;
            // gán giá trị cho radio
            if (obj.status == true)
            {
                rbtnHoatdong.Checked = true;
            }
            else
            {
                tbtnKohoatdong.Checked = true;
            }
        }

        private void tbxTimkiem_TextChanged(object sender, EventArgs e)
        {
            string input = tbxTimkiem.Text;
            GetdataNV(input);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var obj = new NhanVien();
            obj.id = Guid.NewGuid();
            obj.ma = tbxMa.Text;
            obj.ten = tbxTen.Text;
            obj.diaChi = tbxDiachi.Text;
            obj.thanhPho = cmbThanhpho.Text;
            obj.quocGia = tbxQuocgia.Text;
            if (rbtnHoatdong.Checked == true)
            {
                obj.status = true;
            }
            else
            {
                obj.status = false;
            }
            MessageBox.Show(_qlyNhanVien.Add(obj));
            GetdataNV(null);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var obj = new NhanVien();
            obj.id = _idWhenClick;
            obj.ma = tbxMa.Text;
            obj.ten = tbxTen.Text;
            obj.diaChi = tbxDiachi.Text;
            obj.thanhPho = cmbThanhpho.Text;
            obj.quocGia = tbxQuocgia.Text;
            if (rbtnHoatdong.Checked == true)
            {
                obj.status = true;
            }
            else
            {
                obj.status = false;
            }
            MessageBox.Show(_qlyNhanVien.Update(obj));
            GetdataNV(null);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Guid id = _idWhenClick;
            MessageBox.Show(_qlyNhanVien.Delete(id));
            GetdataNV(null);
        }
    }
}
