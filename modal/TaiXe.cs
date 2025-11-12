using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_De_tai_7.modal
{
    public class TaiXe : NhanVien
    {
        private string bienSoXe;
        private string loaiXe;
        public void setBienSo(string bienSo)
        {
            this.bienSoXe = bienSo;
        }
        public string getBienSo() 
        {
            return this.bienSoXe; 
        }
        public void setLoaiXe(string LoaiXe)
        {
            this.loaiXe = LoaiXe;
        }
        public string getLoaiXe()
        {
            return this.loaiXe;
        }
        public TaiXe() : base()
        {
            this.bienSoXe = "null";
            this.loaiXe = "null";
        }
        public TaiXe(string ma, string ten, string sdt,string e, string bsx, string lx, string MaBC) : base(ma, ten, sdt,e,MaBC)
        {
            this.bienSoXe = bsx;
            this.loaiXe = lx;
        }
        public override string ToString()
        {
            return base.ToString()
                + "\nBiển số xe: " + this.bienSoXe
                + "Loại xe: " + this.loaiXe;
        }
    }
}
