using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.dulieu
{
    class dulieu
    {
        public  List<Chitiethoadon> dsChitietHD()
        {
            return new List<Chitiethoadon>()
            {
                new Chitiethoadon(){ mathang="cua cà mau hấp",soluong=3,donvi="kg",gia=600000 },
                new Chitiethoadon(){ mathang="tôm hấp",soluong=3,donvi="kg",gia=600000},
                new Chitiethoadon(){ mathang="cua hoàng đế hấp",soluong=3,donvi="kg",gia=600000},
                new Chitiethoadon(){ mathang="mũ ni hấp",soluong=3,donvi="kg",gia=600000},

        };
        }
      
        public static List<hoadon> dshoadon()
        {
            return new List<hoadon>() {
                new hoadon(){ mahoadon="HD0001",ngaylap="10/10/2018 22:20:10",nhanvienlap="nguyen van bay",tongtien="300000",phong="Phòng số 1",tienkm="2000",tienphong="30000"},
                new hoadon(){ mahoadon="HD0002",ngaylap="10/10/2018 22:20:12",nhanvienlap="nguyen van bay",tongtien="300000",phong="Phòng số 1",tienkm="2000",tienphong="30000"},
                new hoadon(){ mahoadon="HD0003",ngaylap="10/10/2018 22:20:15",nhanvienlap="nguyen van bay",tongtien="300000",phong="Phòng số 1",tienkm="2000",tienphong="30000"},
                new hoadon(){ mahoadon="HD0004",ngaylap="10/10/2018 22:20:18",nhanvienlap="nguyen van bay",tongtien="300000",phong="Phòng số 1",tienkm="2000",tienphong="30000"},
            };
        }
        public static List<hoadon> dshoadon2()
        {
            return new List<hoadon>() {
                new hoadon(){ mahoadon="HD0005",ngaylap="10/10/2018",nhanvienlap="nguyen van bay",tongtien="3200000",phong="Phòng số 1",tienkm="2000",tienphong="30000"},
                new hoadon(){ mahoadon="HD00058",ngaylap="10/10/2018",nhanvienlap="nguyen van bay",tongtien="32100000",phong="Phòng số 1",tienkm="2000",tienphong="30000"},
                new hoadon(){ mahoadon="HD00053",ngaylap="10/10/2018",nhanvienlap="nguyen van bay",tongtien="3005000",phong="Phòng số 1",tienkm="2000",tienphong="30000"},
                new hoadon(){ mahoadon="HD00045",ngaylap="10/10/2018",nhanvienlap="nguyen van bay",tongtien="3000500",phong="Phòng số 1",tienkm="2000",tienphong="30000"},
            };
        }
        public static List<Chitiethoadon> dsChitietHD2()
        {
            return new List<Chitiethoadon>()
            {
                new Chitiethoadon(){ mathang="cua cà mau hấp",soluong=3,donvi="kg",gia=600000 },
                new Chitiethoadon(){ mathang="tôm hấp",soluong=3,donvi="kg",gia=600000},
                new Chitiethoadon(){ mathang="cua hoàng đế hấp",soluong=3,donvi="kg",gia=600000},
                new Chitiethoadon(){ mathang="mũ ni hấp",soluong=3,donvi="kg",gia=600000},

        };
        }
        public static List<nguyenlieu> dsnguyenlieu()
        {
            return new List<nguyenlieu>()
            {
             new nguyenlieu(){manguyenlieu="B100",tennguyenlieu="Bia ha noi",donvi="chai",soluong=17000, giaban=20000,hinhanh="biahanoi.jpg",loainguyenlieu="Bia"},
             new nguyenlieu(){manguyenlieu="B101",tennguyenlieu="Bia ba ba",donvi="chai",soluong=17000, giaban=25000,hinhanh="biababa.jpg",loainguyenlieu="Bia"},
             new nguyenlieu(){manguyenlieu="B102",tennguyenlieu="Bia bus swist",donvi="chai",soluong=17000, giaban=29000,hinhanh="biabus.jpg",loainguyenlieu="Bia"},
             new nguyenlieu(){manguyenlieu="B103",tennguyenlieu="Bia heiniken",donvi="chai",soluong=17000, giaban=28000,hinhanh="biahei.jpg",loainguyenlieu="Bia"}
        };
        }
        public static List <hangnhap> dshangnhap()
        {
            return new List<hangnhap>() {
                new hangnhap(){danhmuc="đồ uống",donvi="lon",gianhap=20000,loaihang="bia",madon="DH0001",ngaynhap=DateTime.Now,soluong=300,tenmathang="bia sài gòn"},
                new hangnhap(){danhmuc="đồ uống",donvi="lon",gianhap=20000,loaihang="bia",madon="DH0002",ngaynhap=DateTime.Now,soluong=300,tenmathang="bia sài gòn"},
                new hangnhap(){danhmuc="đồ uống",donvi="lon",gianhap=20000,loaihang="bia",madon="DH0003",ngaynhap=DateTime.Now,soluong=300,tenmathang="bia tiger"},
                new hangnhap(){danhmuc="đồ uống",donvi="lon",gianhap=20000,loaihang="bia",madon="DH0004",ngaynhap=DateTime.Now,soluong=300,tenmathang="bia bababa"},
                new hangnhap(){danhmuc="đồ uống",donvi="lon",gianhap=20000,loaihang="bia",madon="DH0005",ngaynhap=DateTime.Now,soluong=300,tenmathang="bia bababa"}
            };
        }
        public static List<loainguyenlieu> dsloainguyenlieu()
        {
            return new List<loainguyenlieu>() {
                new loainguyenlieu(){maloai="LDU001",mota="bia ", tenloai="bia"},
                new loainguyenlieu(){maloai="LDU002",mota="các loại nước ngọt: coca, bí đao ", tenloai="nước ngọt"},
                new loainguyenlieu(){maloai="LDU003",mota="các loại nước khoáng: fina,.. ", tenloai="nước khoáng"},
                new loainguyenlieu(){maloai="LDU004",mota="các loại trà: trà đào, trà xanh..", tenloai="trà"},
            };
        }
      

    }
}
