using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Winform_detai7.modal
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
        public KhachNhan(string ma, string ten, string sdt, string diaChiNhan) : base(ma, ten, sdt)
        {
            this.diachikhachnhan = diaChiNhan;
        }
        public override string InfoKhach()
        {
            return $"---Khách nhận--- \n" +
               $"Mã KH: {base.getMaKH()}\n" +
               $"Tên KH: {base.getTenKH()}\n" +
               $"SĐT: {base.getSDT()}\n" +
               $"Địa chỉ nhận: {this.diachikhachnhan}\n";
        }
    }
}
