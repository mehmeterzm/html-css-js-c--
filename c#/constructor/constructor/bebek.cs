using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor 
{
    public class bebek
    {
        //public bebek()
        //{
        //    birthDate = DateTime.Now;
        //}
        public bebek(string _Name)
        {
            name = _Name;
            birthDate =DateTime.Now;
        }

        public string name { get; set; }
        public DateTime birthDate { get; set; }
    }
}
