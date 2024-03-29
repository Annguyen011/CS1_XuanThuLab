﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuanLab.NewFolder
{
    internal class Bai14
    {
        // Tinh ke thuc class B : A
        public class Animal
        {
            protected int legs;
            protected int weight;

            protected virtual void ShowLegs()
            {
                Console.WriteLine(legs);
            }
        }

        // Niem phong sealed

        sealed class Cat : Animal
        {
            private void Init(int leg, int weight)
            {
                legs = leg;
                this.weight = weight;
            }

            protected override void ShowLegs()
            {
                base.ShowLegs();
            }
        }
    }
}
