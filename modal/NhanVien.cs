using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Winform_detai7.modal
{
    public class NhanVien
    {
        private string manv;
        private string tennv;
        private string sodienthoai;
        public BuuCuc buucuc { get; private set; }

        public void setMaNV(string MaNV)
        {
            this.manv = MaNV;
        }
        public string getMaNV()
        {
            return this.manv;
        }
        public void setTenNV(string TenNV)
        {
            this.tennv = TenNV;
        }
        public string getTenNV()
        {
            return this.tennv;
        }
        public void setSDT(string SDT)
        {
            this.sodienthoai = SDT;
        }
        public string getSDT()
        {
            return this.sodienthoai;
        }
        public void setBC(BuuCuc BuuCuc)
        {
            this.buucuc = BuuCuc;
        }
        public BuuCuc getBC()
        {
            return this.buucuc;
        }
        
        public NhanVien()
        {
            this.manv = "null";
            this.tennv = "null";
            this.sodienthoai = "null";
            this.buucuc = new BuuCuc();
        }
        public NhanVien(string ma, string ten, string sdt, BuuCuc BC)
        {
            this.manv = ma;
            this.tennv = ten;
            this.sodienthoai = sdt;
            this.buucuc = BC;
        }
        
        public override string ToString()
        {
            return "\nMã nhân viên: " + this.manv
                + "\nTên nhân viên: " + this.tennv
                + "\nSố điện thoại: " + this.sodienthoai
                + $"\nBưu cục : {buucuc.getMaBC()} ở {buucuc.getTenBuuCuc()}";
        }
        //Cần thêm bưu cục
    }
}
