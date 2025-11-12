using OOP_De_tai_7.modal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_De_tai_7.modalview
{
    public class NhanVienVanPhongView
    {
        public string manv { get; set; }
        public string tennv { get; set; }
        public string sodienthoai { get; set; }
        public string email { get; set; }   
        public string mabuucuc { get; set; }
        public string chucvu { get; set; }
        public string picnvvp { get; set; }    
        public NhanVienVanPhongView()
        {
            this.manv = "";
            this.tennv = "";
            this.sodienthoai = "";
            this.email = "";
            this.mabuucuc = "";
            this.chucvu = "";
        }
        public NhanVienVanPhongView(NhanVienVanPhong nvvp)
        {
            this.manv = nvvp.getMaNV();
            this.tennv = nvvp.getTenNV();
            this.sodienthoai = nvvp.getSDT();
            this.email = nvvp.getEmail();
            this.mabuucuc = nvvp.getmaBC();
            this.chucvu = nvvp.getCV();
        }
    }
}
