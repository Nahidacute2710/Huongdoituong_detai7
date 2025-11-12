using OOP_De_tai_7.modal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_De_tai_7.modalview
{
    public class TaiXeView
    {
        public string manv { get; set; }
        public string tennv { get; set; }
        public string sodienthoai { get; set; }
        public string email { get; set; }   
        public string mabuucuc { get; set; }
        public string bienSoXe { get; set; }
        public string loaiXe { get; set; }
        public string pictaixe { get; set; }
        public TaiXeView()
        {
            this.manv = "";
            this.tennv = "";
            this.sodienthoai = "";
            this.email = "";
            this.mabuucuc = "";
            this.bienSoXe = "";
            this.loaiXe = "";
        }
        public TaiXeView(TaiXe tx)
        {
            this.manv = tx.getMaNV();
            this.tennv = tx.getTenNV();
            this.sodienthoai = tx.getSDT();
            this.email = tx.getEmail();
            this.mabuucuc = tx.getmaBC();
            this.bienSoXe = tx.getBienSo();
            this.loaiXe = tx.getLoaiXe();
        }

    }
}
