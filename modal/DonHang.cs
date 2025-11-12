using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_De_tai_7.modal
{
    public class DonHang
    {
        private string madonhang;
        private DateTime ngaytao;
        private string makhachgui;
        private string makhachnhan;
        private double khoiluong;//kg
        private string trangthai;
        public void setMaDH(string MaDH)
        {
            this.madonhang = MaDH;
        }
        public string getMaDH()
        {
            return this.madonhang;
        }
        public void setNgayTao(DateTime NgayTao)
        {
            this.ngaytao = NgayTao;
        }
        public DateTime getNgayTao()
        {
            return this.ngaytao;
        }
        public void setMaKhachGui(string MaKG)
        {
            this.makhachgui = MaKG;
        }
        public string getMaKhachGui()
        {
            return this.makhachgui;
        }
        public void setMaKhachNhan(string MaKN)
        {
            this.makhachnhan = MaKN;
        }
        public string getMaKhachNhan()
        {
            return this.makhachnhan;
        }
        public void setKhoiLuong(double KhoiLuong)
        {
            this.khoiluong = KhoiLuong;
        }
        public double getKhoiLuong()
        {
            return this.khoiluong;
        }
        public void setTrangThai(string TrangThai)
        {
            this.trangthai = TrangThai;
        }
        public string getTrangThai()
        {
            return this.trangthai;
        }
        public DonHang()
        {
            this.madonhang = "null";
            this.ngaytao = DateTime.Now;
            this.makhachgui = "null";
            this.makhachnhan = "null";
            this.khoiluong = 0.0;
            this.trangthai = "Đang xử lý";
        }

        public DonHang(string ma, DateTime date,string kg,string kn,double KL,string trangThai)
        {
            this.madonhang = ma;
            this.ngaytao = date;
            this.makhachgui = kg;
            this.makhachnhan = kn;
            this.khoiluong = KL;
            this.trangthai = trangThai;
        }
        public override string ToString()
        {
            return $"=== Đơn Hàng ===\n" +
                   $"Mã ĐH: {madonhang}\n" +
                   $"Ngày tạo: {ngaytao}\n" +
                   $"Mã Khách Gửi: {makhachgui}\n" +
                   $"Mã Khách Nhận: {makhachnhan}\n" +
                   $"Khối Lượng: {khoiluong} kg\n" +
                   $"Trạng Thái: {trangthai}\n";
        }
    }
}
