/* Inheritance is not code-sharing Instead, use methods.
 * Is-a relationship 
 * Need to share common logic
 * Sharing just properties or method signatures is not enough
 * Inheritance can put you in a corner, 
 * You need to ask the question: What is the point?
 * 
 */
using System;
 
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public enum CarType
    {
        Hatchback,
        Sedan,
        Compact
    }

    public class RentalCar : RentalVehicle
    {

    }
    public class RentalVehicle
    {
        public int RentalId { get; set; }
        public string CurrentRenter { get; set; }
        public decimal PricePerDay { get; set; }
        public int NumberOfPassengers { get; set; }
        public CarType Style { get; set; }
        public void StartEngine()
        {
            Console.WriteLine("Turn Key to ignition setting");
            Console.WriteLine("Turn key to on");
        }
        public void StopEngine()
        {
            Console.WriteLine("Turn key to off");
        }
    }
}
