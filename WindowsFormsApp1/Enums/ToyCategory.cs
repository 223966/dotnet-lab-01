using System;
using System.ComponentModel;

namespace WindowsFormsApp1
{
    enum ToyCategory
    {
        [Description("Car")]
        Car = 1,
        [Description("Plane")]
        Plane = 2,
        [Description("Submarine")]
        Submarine = 3,
        [Description("Computer")]
        Computer = 4,
    }
}
