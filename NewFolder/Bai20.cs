using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuanLab.NewFolder
{
    internal class Bai20
    {
        // Delegate

        public delegate void ShoLog(string message);

        static void Info(string message)
        {
            Console.WriteLine(message);
        }

        void Main(string[] args)
        {
            ShoLog log = null;
            //Gan cho delegate
            // Co the gan cho nhieu phuong thuc cho delegate
            log += Info;

            // Hai cach viet tuong tu nhau
            log.Invoke("Hi");

            Action action; // ~ delegate void khong tham so
            Action<string, int> action1; // ~ delegate void string int

            Func<int> func; // ~ delegate int
            Func<float, string, int> func2; // ~ delegate int (float, string)
        }
    }
}
