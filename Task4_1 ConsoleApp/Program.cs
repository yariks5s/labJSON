using System;

namespace Task4_1_ConsoleApp
{
    interface IGeographicalObject
    {
        double X { get; set; }
        double Y { get; set; }
        string Name { get; set; }
        string Description { get;set; }
        void GetInfo();
    }

    class River : IGeographicalObject
    {
        public double StreamSpeed { get; set; }
        public double Length { get; set; }

        public double X { get; set; }
        public double Y { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public void GetInfo()
        {
            Console.WriteLine(" Coordinates : {0}, {1};\n" +
                              " name: {2};\n " +
                              "description: {3},\n " +
                              "speed of stream: {4},\n " +
                              "length: {5}", X, Y, Name, Description, StreamSpeed, Length);
        }
    }

    class Mountain : IGeographicalObject
    {
        public double HighestPeak { get; set; }
        
        public double X { get; set; }
        public double Y { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        public void GetInfo()
        {
            Console.WriteLine(" Coordinates : {0}, {1};\n name: {2};\n description: {3};\n highest peak: {4}", X, Y, Name, Description, HighestPeak);
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