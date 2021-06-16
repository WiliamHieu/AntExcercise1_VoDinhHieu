using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntExcercise1_VoDinhHieu
{
    public class Drone : Ant
    {
public Drone()
        { Name = "Drone"; }
        public override void Damage(int dmg)
        {
            Health = Health - dmg;
            if (Health <= 0) { Health = 0;}
            if (Health < 50) { Status = "Dead";}
        }
    }
}

