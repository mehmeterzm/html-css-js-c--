using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propertyType.Models
{
    public class Personel
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        //public string Brans { get; set; }
        public Brans brans { get; set; } // bir sınıfı değişken olarak kullandık !!!!!!!!!!!!!!!
    }
}
