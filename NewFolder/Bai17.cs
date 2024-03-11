using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuanLab.NewFolder
{
    internal class Bai17
    {
        // Anonymous - kieu du lieu vo danh
        // Object - Thuoc tinh - chi doc

        class SinhVien
        {
            string hoTen { get; set; }
            int namSinh { get; set; }

            void Main(string[] args)
            {
                var sanPham = new
                {
                    Ten = "Iphone",
                    Gia = 1000,
                    NamSX = 2000
                };
                //Chi duoc doc khong duoc ghi
                string ten = sanPham.Ten;

                List<SinhVien> sv = new List<SinhVien>()
                {
                    new SinhVien()
                    {
                        hoTen = "A",
                        namSinh = 2000
                    },
                    new SinhVien()
                    {
                        hoTen = "B",
                        namSinh = 2001
                        }
                };

                // LinQ
                var ketQua = from sinhVien in sv
                             where sinhVien.namSinh >= 2000
                             select new
                             {
                                 Ten = sinhVien.hoTen,
                                 NamSInh = sinhVien.namSinh
                             };

                foreach (var s in ketQua)
                {
                    Console.WriteLine(s.NamSInh);

                }
            }
        }
    }
}
