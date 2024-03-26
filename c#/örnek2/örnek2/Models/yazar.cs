using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek2.Models
{
    public class yazar
    {
        // property neyi var
        public string yazarIsmi { get; set; }
        public string yazarSoyismi { get; set; }

        //metod ne yapabilir?
        public void yaz(string kitapadi)
        {
            MessageBox.Show($"{kitapadi} adlı kitap {yazarIsmi} {yazarSoyismi} adlı yazarın eseridir ");
        }
    }
}
