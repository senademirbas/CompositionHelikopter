using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneCompositions
{
    internal class Pervane
    {
        private int uzunluk;
        private int rpm;

        public Pervane(int uzunluk, int rpm)
        {
            this.uzunluk = uzunluk;
            this.rpm = rpm;
        }

        public int Uzunluk { get => uzunluk; set => uzunluk = value; }
        public int Rpm { get => rpm; set => rpm = value; }
    }
}
