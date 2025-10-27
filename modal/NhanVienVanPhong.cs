using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Winform_detai7.modal
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
        public NhanVienVanPhong() :base() { this.chucvu = ""; }
        public NhanVienVanPhong(string ma, string ten, string sdt, BuuCuc BC,string CV) : base(ma, ten, sdt, BC)
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
