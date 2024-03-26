using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction.Models
{
    public abstract class GeometrikSekil //burda kullandık artık sadece verileri aktarıyor
    {
        public int kenar { get; set; }
        public int alan { get; set; }
        public int uzunluk { get; set; }
    }
}
