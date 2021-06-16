using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntExcercise1_VoDinhHieu
{
    public class Queen : Ant
    {
public Queen()
        { Name = "Queen"; }
        public override void Damage(int dmg)
        {
            Health = Health - dmg;
            if (Health <= 0) { Health = 0;}
            if (Health < 20) { Status = "Dead";}
        }
    }
}

