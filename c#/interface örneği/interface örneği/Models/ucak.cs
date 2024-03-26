using interface_örneği.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_örneği.Models
{
    public class ucak : IArac
    {
        public ucak(string _isim,string _soyisim, string _baslangıc,string _bitis)
        {
            Name = _isim;
            surName = _soyisim;
            BaslangıcNoktası = _baslangıc;
            bitisNoktası = _bitis;
        }
        public string Name { get ; set; }
        public string surName { get; set; }
        public string BaslangıcNoktası { get ; set ; }
        public string bitisNoktası { get; set ; }
    }
}
