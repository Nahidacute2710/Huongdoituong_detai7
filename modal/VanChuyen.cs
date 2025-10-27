using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Winform_detai7.modal
{
    internal class VanChuyen
    {
        private string mavc;
        private KhachGui khachgui;
        private KhachNhan khachnhan;
        private string hanhtrinh;
        private DonHang dh;
        private string trangThaiDh;
        private TaiXe tx;
        private string trangThaiTx;
        private DateTime ngaybatdau;
        private DateTime ngayketthucdukien;
        private string takenote;
        public VanChuyen()
        {
            this.mavc = "null";
            this.khachgui = new KhachGui();
            this.khachnhan = new KhachNhan();
            this.hanhtrinh = "null";
            this.dh = new DonHang();
            this.trangThaiDh = "null";
            this.tx = new TaiXe();
            this.trangThaiTx = "null";
            this.ngaybatdau = DateTime.Now;
            this.ngayketthucdukien = DateTime.Now;
            this.takenote = "null";
        }
        public VanChuyen(string maVC, KhachHang KG, KhachHang KN, string HanhTrinh, DonHang DH, string TTDH, TaiXe TX, string TTTX, DateTime NgayBatDau, DateTime NgayKetThuc, string note)
        {
            this.mavc = maVC;
            this.khachgui = (KhachGui)KG;
            this.khachnhan = (KhachNhan)KN;
            this.hanhtrinh = HanhTrinh;
            this.dh = DH;
            this.trangThaiDh = TTDH;
            this.tx = TX;
            this.trangThaiTx = TTTX;
            this.ngaybatdau = NgayBatDau;
            this.ngayketthucdukien = NgayKetThuc;
            this.takenote = note;
        }
        public void setMaVC(string maVC)
        {
            this.mavc = maVC;
        }
        public string getMaVC()
        {
            return this.mavc;
        }
        public void setKhachGui(KhachGui KG)
        {
            this.khachgui = KG;
        }
        public KhachGui getKhachGui()
        {
            return this.khachgui;
        }
        public void setKhachNhan(KhachNhan KN)
        {
            this.khachnhan = KN;
        }
        public KhachNhan getKhachNhan()
        {
            return this.khachnhan;
        }
        public void setHanhTrinh(string HanhTrinh)
        {
            this.hanhtrinh = HanhTrinh;
        }
        public string getHanhTrinh()
        {
            return this.hanhtrinh;
        }
        public void setDonHang(DonHang DH)
        {
            this.dh = DH;
        }
        public DonHang getDonHang()
        {
            return this.dh;
        }
        public void setTaiXe(TaiXe TX)
        {
            this.tx = TX;
        }
        public TaiXe getTaiXe()
        {
            return this.tx;
        }
        public void setTrangThaiDh(string TTDH)
        {
            this.trangThaiDh = TTDH;
        }
        public string getTrangThaiDh()
        {
            return this.trangThaiDh;
        }
        public void setTrangThaiTx(string TTTX)
        {
            this.trangThaiTx = TTTX;
        }
        public string getTrangThaiTx()
        {
            return this.trangThaiTx;
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
        public override string ToString()
        {
            return $"Mã Vận Chuyển: {this.mavc} \n" +
                   $"Khách Gửi: {this.khachgui.InfoKhach()} \n " +
                   $"Khách Nhận: {this.khachnhan.InfoKhach()} \n " +
                   //$"Hành Trình: ->{this.khachnhan.getDiaChiNhan()}\n" +
                   $"Tài Xế: {this.tx.ToString()} \n" +
                   $"Trạng Thái Tài Xế: {this.trangThaiTx}\n " +
                   $"Đơn Hàng: {this.dh.ToString()} \n " +
                   $"Trạng Thái Đơn Hàng: {this.trangThaiDh}\n " +
                   $"Ngày Bắt Đầu: {ngaybatdau.ToString("dd/MM/yyyy")}, Ngày Kết Thúc (dự kiến): {ngayketthucdukien.ToString("dd/MM/yyyy")} \n " +
                   $"Ghi Chú: {this.takenote}";
        }
    }
}
