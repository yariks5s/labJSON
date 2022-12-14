using System;

namespace Homework4
{
    abstract class GeographicalObject
    {
        public double X { get; set; }
        public double Y { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual void GetInfo()
        {
            Console.WriteLine("Coordinates : {0}, {1};\n name: {2};\n description: {3}", X, Y, Name, Description);
        }
    }

    class River : GeographicalObject
    {
        private double StreamSpeed { get; set; }
        private double Length { get; set; }

        public override void GetInfo()
        {
            Console.WriteLine(" Coordinates : {0}, {1};\n name: {2};\n description: {3},\n speed of stream: {4},\n length: {5}", X, Y, Name, Description, StreamSpeed, Length);
        }
    }

    class Mountain : GeographicalObject
    {
        public double HighestPeak { get; set; }
        public override void GetInfo()
        {
            Console.WriteLine(" Coordinates : {0}, {1};\n name: {2};\n description: {3},\n highest peak: {4}", X, Y, Name, Description, HighestPeak);
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Mountain hoverla = new Mountain()
            {
                Name = "Hoverla", Description = "highest mountain in Ukraine", X = 51.20231, Y = 67.13156,
                HighestPeak = 2061
            };
            hoverla.GetInfo();
        }
    }
}