using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_De_tai_7.modal
{
    public class NhanVienVanPhong : NhanVien
    {
        private string chucvu;
        public void setCV(string ChucVu)
        {
            this.chucvu = ChucVu;
        }
        public string getCV()
        {
            return this.chucvu;
        }
        public NhanVienVanPhong() :base() 
        {
            this.chucvu = ""; 
        }
        public NhanVienVanPhong(string ma, string ten, string sdt,string e,string CV,string MaBC) : base(ma, ten, sdt,e, MaBC)
        {
            this.chucvu = CV;
        }
        public override string ToString()
        {
            return base.ToString()
                + "Chức vụ : " + this.chucvu;
        }
    }
}
