using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Winform_detai7.modal
{
    internal class VanChuyenView
    {
        public string mavc {  get; set; }
        public KhachGui khachgui {  get; set; }
        public KhachNhan khachnhan {  get; set; }
        public string hanhtrinh {  get; set; }
        public DonHang dh {  get; set; }
        public string trangThaiDh {  get; set; }
        public TaiXe tx {  get; set; }
        public string trangThaiTx {  get; set; }
        public DateTime ngaybatdau {  get; set; }
        public DateTime ngayketthucdukien {  get; set; }
        public string takenote {  get; set; }
        public VanChuyenView()
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
        public VanChuyenView(VanChuyen vc)
        {
            this.mavc = vc.getMaVC();
            this.khachgui = vc.getKhachGui();
            this.khachnhan = vc.getKhachNhan();
            this.hanhtrinh = vc.getHanhTrinh();
            this.dh = vc.getDonHang();
            this.trangThaiDh = vc.getTrangThaiDh();
            this.tx = vc.getTaiXe();
            this.trangThaiTx =vc.getTrangThaiTx();
            this.ngaybatdau = vc.getNgayBatDau();
            this.ngayketthucdukien =vc.getNgayKetThuc();
            this.takenote = vc.getTakeNote();
        }
    }
}
