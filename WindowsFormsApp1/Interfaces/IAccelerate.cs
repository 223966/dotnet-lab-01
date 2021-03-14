using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    interface IAccelerate
    {
        int Speed { get; set; }

        void Accelerate(int change);
    }
}
