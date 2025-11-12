using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_De_tai_7.modal
{
    public class KhachHang
    {
        private string makhachhang;
        private string tenkhachhang;
        private string sodienthoai;
        private string email;

        public KhachHang()
        {
            this.makhachhang = "null";
            this.tenkhachhang = "null";
            this.sodienthoai = "null";
            this.email = "null";
        }

        public KhachHang(string ma, string ten, string sdt,string E)
        {
            this.makhachhang = ma;
            this.tenkhachhang = ten;
            this.sodienthoai = sdt;
            this.email = E;
        }
        public void setMaKH(string MaKH)
        {
            this.makhachhang= MaKH;
        }
        public string getMaKH()
        {
            return this.makhachhang;
        }
        public void setTenKH(string TenKH)
        {
            this.tenkhachhang= TenKH;
        }
        public string getTenKH()
        {
            return this.tenkhachhang;
        }
        public void setSDT(string SDT)
        {
            this.sodienthoai= SDT;
        }
        public string getSDT()
        {
            return this.sodienthoai ;
        }
        public void setEmail(string E)
        {
            this.email = E;
        }
        public string getEmail()
        {
            return this.email;
        }
        public virtual string InfoKhach()
        {
            return $"---Khách Hàng--- \n" +
               $"Mã KH: {this.makhachhang}\n" +
               $"Tên KH: {this.tenkhachhang}\n" +
               $"SĐT: {this.sodienthoai}\n"+
               $"Email: {this.email}\n";
        }
    }
}
