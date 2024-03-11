using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuanLab.NewFolder
{
    internal class Bai16
    {
        // Nap chong phuong thuc voi cac ham cung ten nhung khac tham so 
        // hoac la khac phuong thuc
        // 
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        
        static void Swap(ref float a, ref float b)
        {
            float temp = a;
            a = b;
            b = temp;
        }
        
        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        
    }
}
