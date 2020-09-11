using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            //DONE Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            var lot = new CarLot();

           
            

            //DONE Create a seperate class file called Car
            //DONE Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //DONE Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //DONEThe methods should take one string parameter: the respective noise property            


            //DONE Now that the Car class is created we can instanciate 3 new cars
            //DONE Set the properties for each of the cars
            //DONE Call each of the methods for each car


            //Instantiation 1 - using dot notation
            var firstCar = new Car();
            firstCar.Make = "Toyota";
            firstCar.Model = "Corolla";
            firstCar.Year = 2005;
            firstCar.EngineNoise = "vroom";
            firstCar.HonkNoise = "hooonk";
            firstCar.IsDriveable = false;

            lot.Cars.Add(firstCar);



            //Instantiation 2 - using dot notation
            var secondCar = new Car();
            secondCar.Make = "Chrevolet";
            secondCar.Model = "Malibu";
            secondCar.Year = 2007;
            secondCar.EngineNoise = "vroom";
            secondCar.HonkNoise = "beeeep";
            secondCar.IsDriveable = true;

            lot.Cars.Add(secondCar);

           

            //Instantiation 3 - object initializer syntax
            var thirdCar = new Car()
            {
                Make = "Kia",
                Model = "Soul",
                Year = 2016,
                EngineNoise = "vroom",
                HonkNoise = "tooot",
                IsDriveable = true
            };

            lot.Cars.Add(thirdCar);

            //Instantiation 4 - using the constructor to allow parameter values to be placed inside properties
            //all values for each parameter but be included using this syntax
            var fourthCar = new Car(2015, "Volkswagen", "Beetle", "vroooooooom", "ahroooogahh", true);

            lot.Cars.Add(fourthCar);

           //Calling methods
            firstCar.MakeEngineNoise(firstCar.EngineNoise);
            firstCar.MakeHonkNoise(firstCar.HonkNoise);

            secondCar.MakeEngineNoise(secondCar.EngineNoise);
            secondCar.MakeHonkNoise(secondCar.HonkNoise);

            thirdCar.MakeEngineNoise(thirdCar.EngineNoise);
            thirdCar.MakeHonkNoise(thirdCar.HonkNoise);

            fourthCar.MakeEngineNoise(fourthCar.EngineNoise);
            fourthCar.MakeHonkNoise(fourthCar.HonkNoise);





            //*************BONUS*************//

            // DONE Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //DONE Create a CarLot class
            //DONE It should have at least one property: a List of cars
            
            //DONE At the end iterate through the list printing each of car's Year, Make, and Model to the console

            foreach(var car in lot.Cars)
            {
                Console.WriteLine($"Year: { car.Year} Make: { car.Make} Model: {car.Model}");
            }
        }
    }
}
