using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    class ToyFactory
    {
        public static Toy Create(string toyCategory)
        {
            ToyCategory toyCategoryEnum = (ToyCategory)Enum.Parse(typeof(ToyCategory), toyCategory);
            switch (toyCategoryEnum)
            {
                case ToyCategory.Car:
                    return new Car() { };
                case ToyCategory.Plane:
                    return new Plane() { };
                case ToyCategory.Submarine:
                    return new Submarine() { };
                case ToyCategory.Computer:
                    return new Computer() { };
                default:
                    throw new Exception($"Class of type {toyCategory} not implemented");
            }
        }
    }
}
