using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Winform_detai7.modal
{
    public class SanPhamView
    {
        public string masanpham { get; set; }
        public string tensanpham { get; set; }
        public int soluong { get; set; }
        public double giatri { get; set; }
        public string tinhchat { get; set; }

        public SanPhamView()
        {
            this.masanpham = "";
            this.tensanpham = "";
            this.soluong= 0;    
            this.giatri = 0;
            this.tinhchat = "";
        }
        public SanPhamView(SanPham sp)
        {
            this.masanpham = sp.getMaSP();
            this.tensanpham = sp.getTenSP();
            this.soluong = sp.getSoLuong();
            this.giatri = sp.getGiaTri();
            this.tinhchat= sp.getTinhChat();    
        }
        public SanPhamView(string ma, string ten, double giaTri, int soLuong, string tinhChat)
        {
            masanpham = ma;
            tensanpham = ten;
            giatri = giaTri;
            soluong = soLuong;
            tinhchat = tinhChat;
        }
        public SanPham ToSanPham()
        {
            return new SanPham(masanpham, tensanpham, tinhchat, soluong, giatri);
        }
    }
}
