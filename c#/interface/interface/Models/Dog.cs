using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Models
{
    public class Dog:BaseClass, IAnimal
    {
      public void Ses()
        {
            MessageBox.Show("HAVHAV");
        }
    }
}
