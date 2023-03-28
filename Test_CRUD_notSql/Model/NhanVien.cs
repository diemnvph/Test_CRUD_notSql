using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_CRUD_notSql.Model
{
    internal class NhanVien
    {
        public Guid id { get; set; }
        public string ten { get; set; }
        public string ma { get; set; }
        public string diaChi { get; set; }
        public string thanhPho { get; set; }
        public string quocGia { get; set; }
        public bool status { get; set; }

    }
}
