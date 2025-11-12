using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_De_tai_7.modal
{
    public class VanChuyen
    {
        private string mavc;
        private string madonhang;
        private string trangThaiDh;
        private string mataixe;
        private string trangThaiTx;
        private string makhachgui;
        private string makhachnhan;
        private string hanhtrinh;
        private DateTime ngaybatdau;
        private DateTime ngayketthucdukien;
        private string takenote;
        public void setMaVC(string maVC)
        {
            this.mavc = maVC;
        }
        public string getMaVC()
        {
            return this.mavc;
        }
        public void setmaDonHang(string maDH)
        {
            this.madonhang = maDH;
        }
        public string getmaDonHang()
        {
            return this.madonhang;
        }
        public void setTrangThaiDh(string TTDH)
        {
            this.trangThaiDh = TTDH;
        }
        public string getTrangThaiDh()
        {
            return this.trangThaiDh;
        }
        public void setMaTaiXe(string maTX)
        {
            this.mataixe = maTX;
        }
        public string getMaTaiXe()
        {
            return this.mataixe;
        }
        public void setTrangThaiTx(string TTTX)
        {
            this.trangThaiTx = TTTX;
        }
        public string getTrangThaiTx()
        {
            return this.trangThaiTx;
        }
        public void setMaKhachGui(string maKG)
        {
            this.makhachgui = maKG;
        }
        public string getMaKhachGui()
        {
            return this.makhachgui;
        }
        public void setMaKhachNhan(string maKN)
        {
            this.makhachnhan = maKN;
        }
        public string getMaKhachNhan()
        {
            return this.makhachnhan;
        }
        public void setHanhTrinh(string HanhTrinh)
        {
            this.hanhtrinh = HanhTrinh;
        }
        public string getHanhTrinh()
        {
            return this.hanhtrinh;
        }
        public void setNgayBatDau(DateTime NgayBatDau)
        {
            this.ngaybatdau = NgayBatDau;
        }
        public DateTime getNgayBatDau()
        {
            return this.ngaybatdau;
        }
        public void setNgayKetThuc(DateTime NgayKetThuc)
        {
            this.ngayketthucdukien = NgayKetThuc;
        }
        public DateTime getNgayKetThuc()
        {
            return this.ngayketthucdukien;
        }
        public void setTakeNote(string note)
        {
            this.takenote = note;
        }
        public string getTakeNote()
        {
            return this.takenote;
        }
        public VanChuyen()
        {
            this.mavc = "null";
            this.madonhang = "null";
            this.trangThaiDh = "null";
            this.mataixe = "null";
            this.trangThaiTx = "null";
            this.makhachgui = "null";
            this.makhachnhan = "null";
            this.hanhtrinh = "null";
            this.ngaybatdau = DateTime.Now;
            this.ngayketthucdukien = DateTime.Now;
            this.takenote = "null";
        }
        public VanChuyen(string maVC,string MaDH,string TTDH,string MaTX,string TTTX,string MaKG,string MaKN,string HanhTrinh, DateTime NgayBatDau, DateTime NgayKetThuc, string note)
        {
            this.mavc = maVC;
            this.madonhang = MaDH;
            this.trangThaiDh = TTDH;
            this.mataixe = MaTX;
            this.trangThaiTx = TTTX;
            this.makhachgui = MaKG;
            this.makhachnhan = MaKN;
            this.hanhtrinh = HanhTrinh;
            this.ngaybatdau = NgayBatDau;
            this.ngayketthucdukien = NgayKetThuc;
            this.takenote = note;
        }
        public override string ToString()
        {
            return $"Mã Vận Chuyển: {this.mavc} \n" +
                   $"Đơn Hàng: {this.madonhang} \n " +
                   $"Trạng Thái Đơn Hàng: {this.trangThaiDh}\n " +
                   $"Tài Xế: {this.mataixe} \n" +
                   $"Trạng Thái Tài Xế: {this.trangThaiTx}\n " +
                   $"Mã Khách Gửi: {this.makhachgui} \n " +
                   $"Mã Khách Nhận: {this.makhachnhan} \n " +
                   $"Hành Trình: {this.hanhtrinh} \n " +
                   $"Ngày Bắt Đầu: {ngaybatdau.ToString("dd/MM/yyyy")}," +
                   $"Ngày Kết Thúc (dự kiến): {ngayketthucdukien.ToString("dd/MM/yyyy")} \n " +
                   $"Ghi Chú: {this.takenote}";
        }
    }
}
