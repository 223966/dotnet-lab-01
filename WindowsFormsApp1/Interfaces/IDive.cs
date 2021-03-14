using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Interfaces
{
    interface IDive
    {
        int Depth { get; set; }

        void Dive(int change);
    }
}
