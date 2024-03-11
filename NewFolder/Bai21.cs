using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuanLab.NewFolder
{
    internal class Bai21
    {
        /*
         * 1) 
         * (Tham so) => bieuThuc
         * 
         * 2)
         * (Tham so) => 
         * {
         *  cac bieu thuc
         *  return kieu tra ve
           }
        */
        void Main()
        {
            Action<string> s1 = s => Console.WriteLine(s); 
            Action<string> s2 = (string s) => Console.WriteLine(s); 
        
            Action action = () => Console.WriteLine("Hello");

            int[] arr = {1, 2, 3 };
        

            var change = arr.Select( x => 
            {
                return Math.Sqrt(x);
            });
        }   
    }
}
