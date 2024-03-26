using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interhaceÖ.Models
{
    public class BaseClass
    {
        public string name { get; set; }
        public DateTime kayittarihi { get; set; }
        private string Deneme;
        public BaseClass()
        {
            kayittarihi = DateTime.Now;
        }
    }
}
