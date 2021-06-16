using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntExcercise1_VoDinhHieu

{
    public class Ant
    {
        public int Health { get; set; } = 100;
         public string Status { get; set; } = "ALIVE";
        public string Name { get; set; }
        public virtual void Damage(int dmg) { }

    }
}