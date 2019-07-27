using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Chitiethoadon
    {
        public static string tenban;
        public static int cohieu;
        public static string mauban;
        public string mathang { get; set; }
        public int soluong { set; get; }
        public string donvi { get; set; }
       
        public int gia { get; set; }
        public int thanhtien { get => soluong*gia; set => thanhtien = value; }
    }
}
