using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Winform_detai7.modal
{
    public class BuuCuc
    {
        private string mabc;
        private string tenbuucuc;
        private string diachi;
        private List<NhanVien> dsnv;

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
        public void Add_NhanVien(NhanVien NhanVien)
        {
            dsnv.Add(NhanVien);
        }
        public List<NhanVien> getDSNV()
        {
            return dsnv;
        }
        public BuuCuc()
        {
            this.mabc = "null";
            this.tenbuucuc = "null";
            this.diachi = "null";
            this.dsnv = new List<NhanVien>();
        }



        public BuuCuc(string ma, string ten, string dc)
        {
            this.mabc = ma;
            this.tenbuucuc = ten;
            this.diachi = dc;
            this.dsnv = new List<NhanVien>(); // nhớ khởi tạo danh sách để tránh null
        }
        public override string ToString()
        {
            return $"{mabc ?? "Chưa có mã"} - {tenbuucuc ?? "Chưa có tên"}";
        }
    
    }
}
