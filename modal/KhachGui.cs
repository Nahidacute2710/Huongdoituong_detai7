using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace Test_Winform_detai7.modal
{
    internal class KhachGui : KhachHang
    {
        private string diachikhachgui;
        public void setDiaChiKhachGui(string DiaChiKhachGui)
        {
            this.diachikhachgui = DiaChiKhachGui;
        }
        public string getDiaChiKhachGui()
        {
            return this.diachikhachgui;
        }
        
        public KhachGui() : base()
        {
            this.diachikhachgui = "null";
        }
        public KhachGui(string ma, string ten, string sdt, string diaChiGui)  :base(ma,ten,sdt)
        {
            this.diachikhachgui = diaChiGui;
        }
        public override string InfoKhach()
        {
            return $"---Khách gửi--- \n" +
               $"Mã KH: {base.getMaKH()}\n" +
               $"Tên KH: {base.getTenKH()}\n" +
               $"SĐT: {base.getSDT()}\n" +
               $"Địa chỉ gửi: {this.diachikhachgui}\n";
        }
        
    }
}
