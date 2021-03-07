using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Interfaces;

namespace WindowsFormsApp1.Classes
{
    class Submarine : Toy, IAccelerate, IDive
    {
        public int Speed { get; set; }

        public int Depth { get; set; }

        public void Accelerate(int change)
        {
            this.Speed += change;
        }

        public void Dive(int change)
        {
            this.Depth += change;
        }
    }
}
