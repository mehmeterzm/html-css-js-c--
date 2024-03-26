using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interhace_kalıtım_.Models
{
    public class Character
    {
        public string characterName { get; set; }
        public int damage { get; set; }
        public int armor { get; set; }
        
        public void Walk()
        {
            MessageBox.Show("kırlarda yürüyorum");
        }
    }
}
