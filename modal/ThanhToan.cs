using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Winform_detai7.modal
{
    public class ThanhToan
    {
        private string mathanhtoan;
        private DonHang madonhang;
        private double thanhtien;
        private string phuongthucthanhtoan;
        private DateTime ngaythanhtoan;
        private string trangthaithanhtoan;

        public void setMaTT(string matt)
        {
            this.mathanhtoan = matt;
        }
        public string getMaTT()
        {
            return this.mathanhtoan;
        }
        public void setMaDonHang(DonHang DH)
        {
            this.madonhang = DH;
        }
        public DonHang getMaDonHang()
        {
            return this.madonhang;
        }
        public void setThanhTien(double TT)
        {
            this.thanhtien = TT;
        }
        public double getThanhTien()
        {
            return this.thanhtien;
        }
        public void setPTTT(string PT)
        {
            this.phuongthucthanhtoan = PT;
        }
        public string getPTTT()
        {
            return this.phuongthucthanhtoan;
        }
        public void setNgayThanhToan(DateTime NgayThanhToan)
        {
            this.ngaythanhtoan = NgayThanhToan;
        }
        public DateTime getNgayThanhToan()
        {
            return this.ngaythanhtoan;
        }
        public void setTrangThaiTT(string TrangThaiTT)
        {
            this.trangthaithanhtoan = TrangThaiTT;
        }
        public string getTrangThaiTT()
        {
            return this.trangthaithanhtoan;
        }
        public ThanhToan()
        {
            this.mathanhtoan = "null";
            this.madonhang = new DonHang();
            this.thanhtien = 0;
            this.phuongthucthanhtoan = "null";
            this.ngaythanhtoan = DateTime.Now;
            this.trangthaithanhtoan = "null";
        }
        public ThanhToan(string MaTT, DonHang DH, string PhuongThucThanhToan, DateTime NgayThanhToan, string TrangThaiThanhToan)
        {
            this.mathanhtoan = MaTT;
            this.madonhang = DH;
            this.thanhtien = madonhang.getGTHH() + madonhang.getPhiVanChuyen();
            this.phuongthucthanhtoan = PhuongThucThanhToan;
            this.ngaythanhtoan = NgayThanhToan;
            this.trangthaithanhtoan = TrangThaiThanhToan;
        }
        public override string ToString()
        {
            return "Mã thanh toán: " + this.mathanhtoan + "\n" +
            "Mã đơn hàng: " + this.madonhang.ToString() + "\n" +
            "Thành tiền: " + this.thanhtien + "\n" +
            "Phương thức thanh toán: " + this.phuongthucthanhtoan + "\n" +
            "Ngày thanh toán: " + this.ngaythanhtoan.ToString("dd/MM/yyyy") + "\n" +
            "Trạng thái thanh toán: " + this.trangthaithanhtoan + "\n";
        }
    }
}
