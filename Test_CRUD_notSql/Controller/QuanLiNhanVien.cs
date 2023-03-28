using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_CRUD_notSql.Model;

namespace Test_CRUD_notSql.Controller
{
    internal class QuanLiNhanVien
    {
        private List<NhanVien> _lstNhanViens;
        public QuanLiNhanVien()
        {
            _lstNhanViens = new List<NhanVien>()
            {
                new NhanVien(){id = Guid.NewGuid(),ten = "Nhung",ma="PH30789",diaChi = "Hà Nội",thanhPho="abc",quocGia="Việt Nam",status= true},
                new NhanVien(){id = Guid.NewGuid(),ten = "Minh",ma="PH30668",diaChi = "Hà Nội",thanhPho="abc",quocGia="Việt Nam",status= false},
                new NhanVien(){id = Guid.NewGuid(),ten = "Hải",ma="PH30695",diaChi = "Hà Nội",thanhPho="abc",quocGia="Việt Nam",status= true},
            };
        }
        public List<NhanVien> GetNhanViens(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return _lstNhanViens;
            }
            return _lstNhanViens.FindAll(x => x.ma.Contains(input)|| x.ten.Contains(input)).ToList();

        }
        public List<String> GettCity()
        {
            return new List<string>() { "HN", "BG", "TN" };
        }
        public string Add(NhanVien obj)
        {
            foreach (var item in _lstNhanViens)
            {
                if (item.ma == obj.ma || item.id == obj.id)
                {
                    return "Mã nhân viên đã tồn tại";
                }

            }
            _lstNhanViens.Add(obj);
            return " thêm thành công";
        }
        public string Update(NhanVien obj)
        {
            foreach (var item in _lstNhanViens)
            {
                if (item.ma == obj.ma)
                {
                    return "Trùng mã nv";
                }
            }
            foreach (var x in _lstNhanViens)
            {
                if (obj.id == x.id)
                {
                    x.ten = obj.ten;
                    x.diaChi = obj.diaChi;
                    x.thanhPho = obj.thanhPho;
                    x.quocGia = obj.quocGia;
                    x.status = obj.status;
                    return " Sửa thành công";

                }
            }
            return " Không tìm thấy id ";
        }
        public string Delete(Guid id)
        {
            foreach (var x in _lstNhanViens)
            {
                if (id.Equals(x.id))
                {
                    _lstNhanViens.Remove(x);
                    return " Xóa thành công";

                }
            }
            return " Xóa thất bại";
        }
    }
}
