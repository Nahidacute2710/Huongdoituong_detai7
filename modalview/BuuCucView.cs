using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Winform_detai7.modal
{
    public class BuuCucView
    {
        public string mabc {  get; set; }
        public string tenbuucuc {  get; set; }
        public string diachi {  get; set; }
        public List<NhanVien> dsnv {  get; set; }

        public BuuCucView()
        {
            this.mabc = "";
            this.tenbuucuc = "";
            this.diachi = "";
            this.dsnv = new List<NhanVien>();
        }
        internal BuuCucView(BuuCuc bc)
        {
            this.mabc=bc.getMaBC();
            this.tenbuucuc=bc.getTenBuuCuc();
            this.diachi=bc.getDiaChi();
            this.dsnv=bc.getDSNV();
        }
    }
}
