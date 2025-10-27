using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Winform_detai7.modal
{
    public class DonHangView
    {
        public string madonhang { get; set; }
        public DateTime ngaytao { get; set; }
        public List<SanPhamView> danhsachsanpham { get; set; } = new List<SanPhamView>();

        public double chiphivanchuyen { get; set; }
        public double giatrihanghoa { get; set; }
        public string makhachgui { get; set; }
        public string makhachnhan { get; set; }
        public string TrangThai { get; set; }
        public DonHangView()
        {
            this.madonhang = "";
            this.ngaytao = DateTime.Now;
            this.danhsachsanpham = new List<SanPhamView>();
            this.chiphivanchuyen = 0;
            this.giatrihanghoa = 0;
            this.makhachgui = "";
            this.makhachnhan = "";
            TrangThai = "Đang xử lý";
        }
        public DonHangView(DonHang dh)
        {
            this.madonhang = dh.getMaDH();
            this.ngaytao = dh.getNgayTao();
            this.danhsachsanpham = dh.getDSSP();
            this.chiphivanchuyen = dh.getPhiVanChuyen();
            this.giatrihanghoa = dh.getGTHH();
            this.makhachnhan = dh.getMaKhachNhan();
            this.TrangThai = dh.getTrangThai();
            this.makhachgui = dh.getMaKhachGui();
            this.makhachnhan = dh.getMaKhachNhan();
            this.TrangThai = dh.getTrangThai();
        }
        public DonHang ToModel()
        {
            DonHang dh = new DonHang(
                this.madonhang,
                this.ngaytao,
                this.danhsachsanpham,
                this.chiphivanchuyen,
                this.makhachgui,
                this.makhachnhan,
                this.TrangThai
            );
            // GTHH đã được tính tự động trong constructor của DonHang
            return dh;

        }
    }
}
