using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_De_tai_7.modal
{
    public class BuuCuc
    {
        private string mabc;
        private string tenbuucuc;
        private string diachi;
        public void setMaBC(string MaBC)
        {
            this.mabc = MaBC;
        }
        public string getMaBC()
        {
            return mabc;
        }
        public void setTenBuuCuc(string TenBuuCuc)
        {
            this.tenbuucuc = TenBuuCuc;
        }
        public string getTenBuuCuc()
        {
            return tenbuucuc;
        }
        public void setDiaChi(string DiaChi)
        {
            this.diachi = DiaChi;
        }
        public string getDiaChi()
        {
            return this.diachi;
        }
        public BuuCuc()
        {
            this.mabc = "null";
            this.tenbuucuc = "null";
            this.diachi = "null";
        }

        public BuuCuc(string ma, string ten, string dc)
        {
            this.mabc = ma;
            this.tenbuucuc = ten;
            this.diachi = dc;
        }
        public override string ToString()
        {
            string in4 = $"Mã Bưu Cục: {this.mabc}, Tên Bưu Cục: {this.tenbuucuc}, Địa Chỉ: {this.diachi}\n";
            return in4;
        }
    }
}
