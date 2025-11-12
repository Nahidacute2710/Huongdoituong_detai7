using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_De_tai_7.modal;

namespace OOP_De_tai_7.modalview
{
    public class KhachNhanView
    {
        public string makh { get; set; }
        public string tenkh { get; set; }
        public string sodienthoai { get; set; }
        public string email { get; set; }
        public string diachikhachnhan { get; set; }
        public string pickhachnhan { get; set; }
        public KhachNhanView()
        {
            this.makh = "";
            this.tenkh = "";
            this.sodienthoai = "";
            this.email = "";
            this.diachikhachnhan = "";        }
        public KhachNhanView(KhachNhan KN)
        {
            this.makh = KN.getMaKH();
            this.tenkh = KN.getTenKH();
            this.sodienthoai = KN.getSDT();
            this.email = KN.getEmail();
            this.diachikhachnhan = KN.getDiaChiKhachNhan();
        }
    }
}
