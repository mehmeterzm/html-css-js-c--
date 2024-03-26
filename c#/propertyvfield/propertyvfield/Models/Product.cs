using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propertyvfield.Models
{
    public class Product
    {
        int b; //field = localden farklı olarak erişim belirleyicisi alır eklenmezse kendisi (private) olarak atar ve public olarak kullanmayız OOPye ters

        int _c;

        //propertyler hiç bir zaman içerilerinde veri tutmazlar
        public int c //property
        {
            get // getirmek
            {
                return _c;
            }
            set // set etmek atamak güncellemek
            {
                _c = value;
            }
        }
        public int d { get; set; }

        public Product()
        {
            int a = 25; //local variable = constructor içine tanımlanan değişken başına public vs bir erişim belirleyici konulmaz sadece kendi constructorun içinde var olur

            c = 12;
        }
    }
}
