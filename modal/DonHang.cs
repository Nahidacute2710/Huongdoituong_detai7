using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Winform_detai7.modal
{
    public class DonHang
    {
        private string madonhang;
        private DateTime ngaytao;
        private List<SanPhamView> danhsachsanpham;
        private double chiphivanchuyen;
        private double giatrihanghoa;
        private string makhachgui;
        private string makhachnhan; 
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
        public void setDSSP(List<SanPhamView> Dssp)
        {
            this.danhsachsanpham = Dssp;
        }
        public List<SanPhamView> getDSSP()
        {
            return this.danhsachsanpham;
        }
        public void setGTHH(double gthh)
        {
            this.giatrihanghoa = gthh;
        }
        public double getGTHH()
        {
            return giatrihanghoa;
        }
        public void setMaKhachNhan(string makh)
        {
            this.makhachnhan = makh;
        }
        public string getMaKhachNhan()
        {
            return this.makhachnhan;
        }
        public void setPhiVanChuyen(double phiVanChuyen)
        {
            this.chiphivanchuyen = phiVanChuyen;
        }
        public double getPhiVanChuyen()
        {
            return chiphivanchuyen;
        }

        public void setTrangThai(string tt)
        {
            this.trangthai = tt;
        }
        public string getTrangThai()
        {
            return this.trangthai;
        }
        public string getMaKhachGui()
        {
            return this.makhachgui;
        }
        public void setMaKhachGui(string makh)
        {
            this.makhachgui = makh;
        }
        public DonHang()
        {
            this.madonhang = "null";
            this.ngaytao = DateTime.Now;
            this.danhsachsanpham = new List<SanPhamView>();
            this.chiphivanchuyen = 0;
            this.giatrihanghoa = 0;
            this.makhachgui = "null";
            this.makhachnhan = "null";
            this.trangthai = "null";
        }


        public DonHang(string ma, DateTime date, List<SanPhamView> ds, double phi,string makhachgui,string makhachnhan, string tt)
        {
            this.madonhang = ma;
            this.ngaytao = date;
            this.danhsachsanpham = ds;
            this.chiphivanchuyen = phi;
            this.makhachgui = makhachgui;
            this.makhachnhan = makhachnhan;
            this.trangthai = tt;
            foreach (SanPhamView pham in ds)
            {
                this.giatrihanghoa += pham.giatri * pham.soluong;
            }
        }
        public override string ToString()
        {
            string dsSp = "";
            foreach (var sp in danhsachsanpham)
            {
                dsSp += sp.ToString();
            }

            return $"=== Đơn Hàng ===\n" +
                   $"Mã ĐH: {madonhang}\n" +
                   $"Ngày tạo: {ngaytao}\n" +
                   $"Phí vận chuyển: {chiphivanchuyen}\n" +
                   $"Giá trị đơn hàng : {giatrihanghoa}\n" +
                   $"Danh sách sản phẩm:\n{dsSp}";
        }
    }
}
