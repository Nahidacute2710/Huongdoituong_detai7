using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_De_tai_7.modal;
using OOP_De_tai_7.modalview;

namespace OOP_De_tai_7.modalview
{
    public class ThanhToanView
    {
        public string mathanhtoan { get; set; }
        public string madonhang { get; set; }
        public string phuongthucthanhtoan { get; set; }
        public DateTime ngaythanhtoan { get; set; }
        public string trangthaithanhtoan { get; set; }


        public ThanhToanView()
        {
            this.mathanhtoan = "";
            this.madonhang = "";
            this.phuongthucthanhtoan = "";
            this.ngaythanhtoan = DateTime.Now;
            this.trangthaithanhtoan = "";
        }
        public ThanhToanView(ThanhToan tt)
        {
            this.mathanhtoan = tt.getMaTT();
            this.madonhang = tt.getMaDonHang();
            this.phuongthucthanhtoan = tt.getPTTT();
            this.ngaythanhtoan = tt.getNgayThanhToan();
            this.trangthaithanhtoan = tt.getTrangThaiTT();
        }
    }
}
