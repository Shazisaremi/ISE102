using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Derived B = new Derived();
            B.DoWork();  // Calls the new method.

            Base A = (Base)B;
            A.DoWork();  // Calls the old method.
        }
    }
}
