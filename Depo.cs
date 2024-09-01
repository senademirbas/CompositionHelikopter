using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneCompositions
{
    internal class Depo
    {
        private int hacim;


        //hacim sağ click kapsülle ile hızlı oluşturduk
        public int Hacim { get => hacim; set => hacim = value; } 

        
        //hacim sağ click oluşturucusunu üret ile hızlı oluşturduk
        public Depo(int hacim)
        {
            this.hacim = hacim;
        }

      
    }
}
