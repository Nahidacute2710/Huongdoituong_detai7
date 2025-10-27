using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Winform_detai7.modal
{
    public static class DanhSachSanPham
    {
        private static string path = "hanghoa.json";
        public static List<SanPhamView> danhSachSanPham = new List<SanPhamView>();

        static DanhSachSanPham()
        {
            danhSachSanPham = JsonActivity.ReadFromJsonFile<SanPhamView>(path);
            if (danhSachSanPham == null || danhSachSanPham.Count == 0)
            {
                TaoDuLieuMau();
                JsonActivity.WriteToJsonFile(path, danhSachSanPham);
            }
        }

        public static void TaoDuLieuMau()
        {
            danhSachSanPham = new List<SanPhamView>()
            {
                new SanPhamView("SP01", "Laptop Dell XPS 13", 32000000, 10, "Điện tử"),
                new SanPhamView("SP02", "Chuột Logitech G Pro", 700000, 25, "Phụ kiện"),
                new SanPhamView("SP03", "Bàn phím Razer BlackWidow", 1500000, 15, "Phụ kiện"),
                new SanPhamView("SP04", "Tai nghe Sony WH-1000XM5", 2000000, 12, "Âm thanh"),
                new SanPhamView("SP05", "Màn hình LG UltraWide 29''", 6500000, 5, "Điện tử")
            };
        }

        public static void Luu()
        {
            JsonActivity.WriteToJsonFile(path, danhSachSanPham);
        }

        public static void Them(SanPhamView hh)
        {
            danhSachSanPham.Add(hh);
            Luu();
        }

        public static void Xoa(string ma)
        {
            SanPhamView sanPhamCanXoa = danhSachSanPham.FirstOrDefault(sp => sp.masanpham == ma);
            if (sanPhamCanXoa != null)
            {
                danhSachSanPham.Remove(sanPhamCanXoa);
                Luu();
            }
        }

        public static void Sua(SanPhamView sanPhamMoi)
        {
            SanPhamView sanPhamCu = danhSachSanPham.FirstOrDefault(sp => sp.masanpham == sanPhamMoi.masanpham);

            if (sanPhamCu != null)
            {
                sanPhamCu.tensanpham = sanPhamMoi.tensanpham;
                sanPhamCu.soluong = sanPhamMoi.soluong;
                sanPhamCu.giatri = sanPhamMoi.giatri;
                sanPhamCu.tinhchat = sanPhamMoi.tinhchat;

                Luu();
            }
        }

        public static List<SanPhamView> LayDanhSach()
        {
            danhSachSanPham = JsonActivity.ReadFromJsonFile<SanPhamView>(path);
            return danhSachSanPham;
        }

        public static SanPhamView TimTheoMa(string ma)
        {
            return danhSachSanPham.FirstOrDefault(x => x.masanpham == ma);
        }
    }
}

