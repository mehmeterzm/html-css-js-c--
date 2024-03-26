using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace çalışma3.Models
{
    public class Buyucu
    {
        //bu sınıfın neyi var
        public string oyuncuIsmi { get; set; }
        public string Brans { get; set; }
        public string Irk { get; set; }
        public string Silah { get; set; }
        public int SaldiriGucu { get; set; }

        //büyücüm ne yapabilir
        public void Saldir()
        {
            switch (Brans)
            {
                case "Karabüyü":
                    SaldiriGucu = 50; break;
                case "Defansif":
                    SaldiriGucu = 10; break;
                default: SaldiriGucu = 30 ; break;
            }
        }
    }
}
