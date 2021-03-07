using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Interfaces;

namespace WindowsFormsApp1.Classes
{
    class Plane : Toy, IAccelerate, IRise
    {
        public int Speed { get; set; }

        public int Height { get; set; }

        public void Accelerate(int change)
        {
            this.Speed += change;
        }

        public void Rise(int change)
        {
            this.Height += change;
        }
    }
}
