using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_De_tai_7.modalview;

namespace OOP_De_tai_7.DataManagerClass
{
    public class DataManager
    {
        public List<SanPhamView> danhsach_sanpham { get; set; } = new List<SanPhamView>();
        public List<DonHangView> danhsach_donhang { get; set; } = new List<DonHangView>();
        public List<KhachGuiView> danhsach_khachgui { get; set; } = new List<KhachGuiView>();
        public List<KhachNhanView> danhsach_khachnhan { get; set; } = new List<KhachNhanView>();
        public List<BuuCucView> danhsach_buucuc { get; set; } = new List<BuuCucView>();  
        public List<TaiXeView> danhsach_taixe { get; set; } = new List<TaiXeView>();
        public List<NhanVienVanPhongView> danhsach_nhanvienvanphong { get; set; } = new List<NhanVienVanPhongView>();
        public List<ThanhToanView> danhsach_thanhtoan { get; set; } = new List<ThanhToanView>();
        public List<VanChuyenView> danhsach_vanchuyen { get; set; } = new List<VanChuyenView>();
        public DataManager()
        {
            danhsach_buucuc = new List<BuuCucView>();
            danhsach_khachgui = new List<KhachGuiView>();
            danhsach_khachnhan = new List<KhachNhanView>();
            danhsach_nhanvienvanphong = new List<NhanVienVanPhongView>();
            danhsach_taixe = new List<TaiXeView>();
            danhsach_sanpham= new List<SanPhamView>();
            danhsach_donhang = new List<DonHangView>();
            danhsach_thanhtoan = new List<ThanhToanView>();
            danhsach_vanchuyen = new List<VanChuyenView>();
        }
        public DataManager(List<SanPhamView> sp,List<DonHangView> dh,List<KhachGuiView> kg,List<KhachNhanView> kn, List<BuuCucView> bc,List<TaiXeView> tx,List<NhanVienVanPhongView> nvvp, List<ThanhToanView> tt, List<VanChuyenView> vc)
        {
            danhsach_sanpham = sp;
            danhsach_donhang = dh;
            danhsach_khachgui = kg;
            danhsach_khachnhan = kn;
            danhsach_buucuc = bc;
            danhsach_taixe = tx;
            danhsach_nhanvienvanphong = nvvp;
            danhsach_thanhtoan = tt;
            danhsach_vanchuyen = vc;
        }
    }
}
