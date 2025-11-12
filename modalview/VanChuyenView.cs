using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_De_tai_7.modal;
using OOP_De_tai_7.modalview;

namespace OOP_De_tai_7.modalview
{
    public class VanChuyenView
    {
        public string mavc { get; set; }
        public string madonhang { get; set; }
        public string trangThaiDh { get; set; }
        public string mataixe { get; set; }
        public string trangThaiTx { get; set; }
        public string makhachgui { get; set; }
        public string makhachnhan { get; set; }
        public string hanhtrinh { get; set; }
        public DateTime ngaybatdau { get; set; }
        public DateTime ngayketthucdukien { get; set; }
        public string takenote { get; set; }
        public VanChuyenView()
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
        public VanChuyenView(VanChuyen vc)
        {
            this.mavc = vc.getMaVC();
            this.madonhang = vc.getmaDonHang();
            this.trangThaiDh = vc.getTrangThaiDh();
            this.mataixe = vc.getMaTaiXe();
            this.trangThaiTx = vc.getTrangThaiTx();
            this.makhachgui=vc.getMaKhachGui();
            this.makhachnhan = vc.getMaKhachNhan();
            this.hanhtrinh = vc.getHanhTrinh();
            this.ngaybatdau = vc.getNgayBatDau();
            this.ngayketthucdukien = vc.getNgayKetThuc();
            this.takenote = vc.getTakeNote();
        }
    }
}
