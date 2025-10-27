using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Winform_detai7.modal
{
    public class KhachNhanView
    {
        public string makh { get; set; }
        public string tenkh { get; set; }
        public string sodienthoai { get; set; }
        public string diachikhachnhan { get; set; }
        public string Loai { get; set; }
        public KhachNhanView()
        {
            this.makh = "";
            this.tenkh = "";
            this.sodienthoai = "";
            this.diachikhachnhan = "";
            this.Loai = "Nhận";
        }
        public KhachNhanView(KhachNhan KN)
        {
            this.makh = KN.getMaKH();
            this.tenkh = KN.getTenKH();
            this.sodienthoai = KN.getSDT();
            this.diachikhachnhan = KN.getDiaChiKhachNhan();
            this.Loai = "Nhận";
        }
    }
}
