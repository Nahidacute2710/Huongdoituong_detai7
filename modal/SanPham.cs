using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_De_tai_7.modal
{
    public class SanPham
    {
        private string masanpham;
        private string tensanpham;
        private int soluong;
        private double giatri;
        private string tinhchat;
        private string madonhang;
        public void setMaSP(string MaSP)
        {
            this.masanpham = MaSP;
        }
        public string getMaSP()
        {
            return this.masanpham;
        }
        public void setTenSP(string TenSP)
        {
            this.tensanpham = TenSP;
        }
        public string getTenSP()
        {
            return this.tensanpham;
        }
        public void setSoLuong(int SL)
        {
            this.soluong = SL;
        }
        public int getSoLuong()
        {
            return this.soluong;
        }
        public void setGiaTri(double GT)
        {
            this.giatri = GT;
        }
        public double getGiaTri()
        {
            return giatri;
        }
        public void setTinhChat(string TC)
        {
            this.tinhchat = TC;
        }
        public string getTinhChat()
        {
            return tinhchat;
        }
        public void setMaDH(string MaDH)
        {
            this.madonhang = MaDH;
        }
        public string getMaDH()
        {
            return this.madonhang;
        }
        public SanPham()
        {
            this.masanpham = "null";
            this.tensanpham = "null";
            this.soluong = 0;
            this.giatri = 0;
            this.tinhchat = "null";
            this.madonhang = "null";
        }
        public SanPham(string ma, string ten, string TinhChat, int sl, double gia,string MaDH)
        {
            this.masanpham = ma;
            this.tensanpham = ten;
            this.tinhchat = TinhChat;
            this.soluong = sl;
            this.giatri = gia;
            this.madonhang = MaDH;
        }
        public override string ToString()
        {
            return $"-> Sản phẩm:\n" +
                   $"   Mã SP: {masanpham}\n" +
                   $"   Tên SP: {tensanpham}\n" +
                   $"   Tính chất : {tinhchat}\n" +
                   $"   Số lượng: {soluong}\n" +
                   $"   Giá trị: {giatri}\n" +
                   $"   Mã Đơn Hàng: {madonhang}\n";
        }
    }
}
