using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneCompositions
{
    internal class Helikopter
    {
        private string kuyrukNo;
        private Motor motor1;
        private Depo depo1;
        private Pervane pervane1;

        public Helikopter(string kuyrukNo, Motor motor1, Depo depo1, Pervane pervane1)
        {
            this.kuyrukNo = kuyrukNo;
            this.motor1 = motor1;
            this.depo1 = depo1;
            this.pervane1 = pervane1;
        }

        public string KuyrukNo { get => kuyrukNo; set => kuyrukNo = value; }
        internal Motor Motor1 { get => motor1; set => motor1 = value; }
        internal Depo Depo1 { get => depo1; set => depo1 = value; }
        internal Pervane Pervane1 { get => pervane1; set => pervane1 = value; }
        
        public void helikopteriCalistir()
        {
            this.motor1.motoruCalistir();
        }

        public void helikopteriDurdur()
        {
            this.motor1.motoruDurdur();
        }

    }   
}
