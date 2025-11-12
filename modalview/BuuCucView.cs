using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_De_tai_7.modal;
namespace OOP_De_tai_7.modalview
{
    public class BuuCucView
    {
        public string mabc { get; set; }
        public string tenbuucuc { get; set; }
        public string diachi { get; set; }
        public string pickbuucuc { get; set; } 
        public BuuCucView()
        {
            this.mabc = "";
            this.tenbuucuc = "";
            this.diachi = "";
        }
        internal BuuCucView(BuuCuc bc)
        {
            this.mabc = bc.getMaBC();
            this.tenbuucuc = bc.getTenBuuCuc();
            this.diachi = bc.getDiaChi();
        }
    }
}
