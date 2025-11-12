using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_De_tai_7.modal
{
    public class KhachNhan : KhachHang
    {
        private string diachikhachnhan;
        public void setDiaChiKhachNhan(string DiaChiKhachNhan)
        {
            this.diachikhachnhan = DiaChiKhachNhan;
        }
        public string getDiaChiKhachNhan()
        {
            return this.diachikhachnhan;
        }
        public KhachNhan() : base()
        {
            this.diachikhachnhan = "null";
        }
        public KhachNhan(string ma, string ten, string sdt,string E, string diaChiNhan) : base(ma, ten, sdt,E)
        {
            this.diachikhachnhan = diaChiNhan;
        }
        public override string InfoKhach()
        {
            return $"---Khách nhận--- \n" +
               $"Mã KH: {base.getMaKH()}\n" +
               $"Tên KH: {base.getTenKH()}\n" +
               $"SĐT: {base.getSDT()}\n" +
               $"Email: {base.getEmail()}\n" +
               $"Địa chỉ nhận: {this.diachikhachnhan}\n";
        }
    }
}
