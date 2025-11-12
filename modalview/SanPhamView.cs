
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_De_tai_7.modal;

namespace OOP_De_tai_7.modalview
{
    public class SanPhamView
    {
        public string masanpham { get; set; }
        public string tensanpham { get; set; }
        public int soluong { get; set; }
        public double giatri { get; set; }
        public string tinhchat { get; set; }
        public string madonhang { get; set; }
        public string picSanpham { get; set; }
        public SanPhamView()
        {
            this.masanpham = "";
            this.tensanpham = "";
            this.soluong = 0;
            this.giatri = 0;
            this.tinhchat = "";
            this.madonhang = "";
        }
        public SanPhamView(SanPham sp)
        {
            this.masanpham = sp.getMaSP();
            this.tensanpham = sp.getTenSP();
            this.soluong = sp.getSoLuong();
            this.giatri = sp.getGiaTri();
            this.tinhchat = sp.getTinhChat();
            this.madonhang = sp.getMaDH();
        }
    }
}
