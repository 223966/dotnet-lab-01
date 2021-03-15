using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    enum ToyInterface
    {
        [Description("IAccelerate")]
        IAccelerate = 1,
        [Description("IRise")]
        IRise = 2,
        [Description("IDive")]
        IDive = 3,
    }
}
