using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Winform_detai7.modal
{
    public class TaiXeView
    {
        public string manv { get; set; }
        public string tennv { get; set; }
        public string sodienthoai { get; set; }
        [Browsable(false)]
        public BuuCucView buucuc { get; set; }
        public string bienSoXe {  get; set; }
        public string loaiXe {  get; set; }
        public string tenbuucuc
        {
            get
            {
                return buucuc != null ? buucuc.tenbuucuc : "Chưa có";
            }
        }
        public TaiXeView()
        {
            this.manv = "";
            this.tennv = "";
            this.sodienthoai = "";
            this.buucuc = new BuuCucView();
            this.bienSoXe = "";
            this.loaiXe = "";
        }
        public TaiXeView(TaiXe tx)
        {
            this.manv = tx.getMaNV();
            this.tennv=tx.getTenNV();
            this.sodienthoai=tx.getSDT();
            this.buucuc = new BuuCucView(tx.getBC());
            this.bienSoXe=tx.getBienSo();
            this.loaiXe=tx.getLoaiXe();
        }

    }
}
