using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    class Car : Toy, IAccelerate
    {
        public int Speed { get; set; }

        public void Accelerate(int change)
        {
            this.Speed = change;
        }
    }
}
