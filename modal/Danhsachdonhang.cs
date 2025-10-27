using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Test_Winform_detai7.modal
{
    public class Danhsachdonhang
    {
        private static string path = "donhang.json";
        private static List<DonHangView> dsDonHang = new List<DonHangView>();

        static Danhsachdonhang()
        {
            dsDonHang = JsonActivity.ReadFromJsonFile<DonHangView>(path);
    
        }

        public static List<DonHangView> LayDanhSach()
        {
            dsDonHang = JsonActivity.ReadFromJsonFile<DonHangView>(path);
            return dsDonHang;
        }

        public static void Luu()
        {
            string json = JsonConvert.SerializeObject(dsDonHang, Formatting.Indented);
            File.WriteAllText(path, json);

        }

        public static void Them(DonHangView dh)
        {
            dsDonHang.Add(dh);
            Luu();
        }
    }
}
