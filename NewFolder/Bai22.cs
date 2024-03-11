using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuanLab.NewFolder
{
    internal class Bai22
    {
        /*
         *  publier -> phat su kien 
         *  sub -> Nhan su kien 
         *  Huy dang ki su kien neu co hai su kien dang ki
         */

        public delegate void suKienNhapSo(int x);

        public class UserInput
        {
            public event EventHandler suKienNhapSo;
            //public event suKienNhapSo suKienNhapSo;

            public void Input()
            {
                int i = 12;
                // Publicser
                suKienNhapSo?.Invoke(this, new DuLieuNhap(i));
            }
        }

        public class DuLieuNhap : EventArgs
        {
            public int data { get; set; }

            public DuLieuNhap(int data)
            { this.data = data; }
        }

        public class TinhToan
        {

            public void Sub(UserInput input)
            {
                // Sub
                input.suKienNhapSo += Can;
            }

            public void Can(object sender, EventArgs e)
            {
                DuLieuNhap duLieu = (DuLieuNhap)e;
                int a = duLieu.data;
            }
        }

    }
}
