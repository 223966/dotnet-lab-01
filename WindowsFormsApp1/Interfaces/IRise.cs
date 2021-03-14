using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Interfaces
{
    interface IRise
    {
        int Height { get; set; }

        void Rise(int change);
    }
}
