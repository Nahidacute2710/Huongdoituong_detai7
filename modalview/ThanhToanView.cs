using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Winform_detai7.modal
{
    public class ThanhToanView
    {
        public string mathanhtoan { get; set; }
        public string madonhang { get; set; }
        public double thanhtien { get; set; }
        public string phuongthucthanhtoan { get; set; }
        public DateTime ngaythanhtoan { get; set; }
        public string trangthaithanhtoan { get; set; }
        

        public ThanhToanView()
        {
            this.mathanhtoan = "";
            this.madonhang = "";
            this.thanhtien= 0;
            this.phuongthucthanhtoan = "";
            this.ngaythanhtoan=DateTime.Now;
            this.trangthaithanhtoan = "";
        }
        public ThanhToanView(ThanhToan tt)
        {
            this.mathanhtoan=tt.getMaTT();
            this.madonhang=tt.getMaDonHang().getMaDH();
            this.thanhtien=tt.getThanhTien();
            this.phuongthucthanhtoan = tt.getPTTT();
            this.ngaythanhtoan=tt.getNgayThanhToan();
            this.trangthaithanhtoan=tt.getTrangThaiTT();
        }
    }
}
