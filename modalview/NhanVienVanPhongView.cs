using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Test_Winform_detai7.modal
{
    public class NhanVienVanPhongView
    {
        public string manv {  get; set; }
        public string tennv { get; set; }
        public string sodienthoai { get; set; }
        [Browsable(false)]
        public BuuCucView buucuc { get; set; }
        public string chucvu { get; set; }
        public string tenbuucuc
        {
            get
            {
                return buucuc != null ? buucuc.tenbuucuc : "Chưa có";
            }
        }
        public NhanVienVanPhongView()
        {
            this.manv ="";
            this.tennv = "";
            this.sodienthoai = "";
            this.buucuc = new BuuCucView();
            this.chucvu = "";
        }
        public NhanVienVanPhongView(NhanVienVanPhong nvvp)
        {
            NhanVien nv = new NhanVien();
            this.manv = nvvp.getMaNV();
            this.tennv = nvvp.getTenNV();
            this.sodienthoai = nvvp.getSDT();
            this.buucuc = new BuuCucView(nvvp.getBC()); 
            this.chucvu = nvvp.getCV();
        }
    }
}
