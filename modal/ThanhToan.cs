using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_De_tai_7.modal
{
    public class ThanhToan
    {
        private string mathanhtoan;
        private string madonhang;
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
        public void setMaDonHang(string MaDH)
        {
            this.madonhang = MaDH;
        }
        public string getMaDonHang()
        {
            return this.madonhang;
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
            this.madonhang = "null";
            this.phuongthucthanhtoan = "null";
            this.ngaythanhtoan = DateTime.Now;
            this.trangthaithanhtoan = "null";
        }
        public ThanhToan(string MaTT, string MaDH, string PhuongThucThanhToan, DateTime NgayThanhToan, string TrangThaiThanhToan)
        {
            this.mathanhtoan = MaTT;
            this.madonhang = MaDH;
            this.phuongthucthanhtoan = PhuongThucThanhToan;
            this.ngaythanhtoan = NgayThanhToan;
            this.trangthaithanhtoan = TrangThaiThanhToan;
        }
        public override string ToString()
        {
            return "Mã thanh toán: " + this.mathanhtoan + "\n" +
            "Dơn hàng: " + this.madonhang + "\n" +
            "Phương thức thanh toán: " + this.phuongthucthanhtoan + "\n" +
            "Ngày thanh toán: " + this.ngaythanhtoan.ToString("dd/MM/yyyy") + "\n" +
            "Trạng thái thanh toán: " + this.trangthaithanhtoan + "\n";
        }
    }
}
