using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.IO;
using System.Threading.Tasks;

namespace Test_Winform_detai7.modal
{
    public class KhachGuiView
    {
        public string makh { get; set; }
        public string tenkh { get; set; }
        public string sodienthoai { get; set; }
        public string diachikhachgui { get; set; }
        public string Loai { get; set; }
        public KhachGuiView()
        {
            this.makh = "";
            this.tenkh = "";
            this.sodienthoai = "";
            this.diachikhachgui = "";
            this.Loai = "Gửi";
        }
        internal KhachGuiView(KhachGui KG)
        {
            this.makh = KG.getMaKH();
            this.tenkh = KG.getTenKH();
            this.sodienthoai = KG.getSDT();
            this.diachikhachgui = KG.getDiaChiKhachGui();
            this.Loai = "Gửi";
        }
    }
}
