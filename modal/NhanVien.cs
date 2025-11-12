using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_De_tai_7.modal
{
    public class NhanVien
    {
        private string manv;
        private string tennv;
        private string sodienthoai;
        private string email;
        private string mabuucuc;
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
        public void setEmail(string Email)
        {
            this.email = Email;
        }
        public string getEmail()
        {
            return this.email;
        }
        public void setmaBC(string MaBC)
        {
            this.mabuucuc = MaBC;
        }
        public string getmaBC()
        {
            return this.mabuucuc;
        }
        
        public NhanVien()
        {
            this.manv = "null";
            this.tennv = "null";
            this.sodienthoai = "null";
            this.email = "null";
            this.mabuucuc="null";
        }
        public NhanVien(string ma, string ten, string sdt,string e, string MaBC)
        {
            this.manv = ma;
            this.tennv = ten;
            this.sodienthoai = sdt;
            this.email = e;
            this.mabuucuc = MaBC;
        }
        public override string ToString()
        {
            return "\nMã nhân viên: " + this.manv
                + "\nTên nhân viên: " + this.tennv
                + "\nSố điện thoại: " + this.sodienthoai
                + "\nEmail: " + this.email
                + "\nMã bưu cục: " + this.mabuucuc;
        }
    }
}
