using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
        // DONE Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        // DONE Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()

        public Car()
        {

        }

        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
        }


        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine("The engine makes a " + engineNoise + " noise.");
        }

        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine("The horn makes a " + honkNoise + " noise.");
        }
    }
}
