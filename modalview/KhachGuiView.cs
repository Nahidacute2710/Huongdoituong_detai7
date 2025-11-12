using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_De_tai_7.modal;

namespace OOP_De_tai_7.modalview
{
    public class KhachGuiView
    {
        public string makh { get; set; }
        public string tenkh { get; set; }
        public string sodienthoai { get; set; }
        public string email { get; set; }
        public string diachikhachgui { get; set; }
        public string pickhachgui { get; set; }
        public KhachGuiView()
        {
            this.makh = "";
            this.tenkh = "";
            this.sodienthoai = "";
            this.email = "";
            this.diachikhachgui = "";
        }
        internal KhachGuiView(KhachGui KG)
        {
            this.makh = KG.getMaKH();
            this.tenkh = KG.getTenKH();
            this.sodienthoai = KG.getSDT();
            this.email = KG.getEmail();
            this.diachikhachgui = KG.getDiaChiKhachGui();
        }
    }
}
