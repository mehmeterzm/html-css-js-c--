using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism.Models
{
    public abstract class Karakter
    {
        public virtual void Saldir()
        {
            MessageBox.Show("Normal saldırı yap");
        }
    }
}
