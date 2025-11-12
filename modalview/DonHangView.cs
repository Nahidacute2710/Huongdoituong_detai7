using OOP_De_tai_7.modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_De_tai_7.modalview
{
    public class DonHangView
    {
        public string madonhang { get; set; }
        public DateTime ngaytao { get; set; }
        public string makhachgui { get; set; }
        public string makhachnhan { get; set; }
        public double khoiluong { get; set; }
        public string TrangThai { get; set; }
        //them cai nay
        public List<SanPhamView> danhsachsanpham { get; set; } = new List<SanPhamView>();
        public DonHangView()
        {
            this.madonhang = "";
            this.ngaytao = DateTime.Now;
            this.makhachgui = "";
            this.makhachnhan = "";
            this.khoiluong = 0.0;
            this.TrangThai = "Đang xử lý";
        }
        public DonHangView(DonHang dh)
        {
            this.madonhang = dh.getMaDH();
            this.ngaytao = dh.getNgayTao();
            this.makhachgui = dh.getMaKhachGui();
            this.makhachnhan = dh.getMaKhachNhan();
            this.khoiluong = dh.getKhoiLuong();
            this.TrangThai = dh.getTrangThai();
        }
        public DonHang ToModel()
        {
            DonHang dh = new DonHang(
                this.madonhang,
                this.ngaytao,
                this.makhachgui,
                this.makhachnhan,
                this.khoiluong,
                this.TrangThai
            );
            return dh;
        }

    }
}
