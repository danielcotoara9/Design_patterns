using System;
using Facade.SubSystems;

namespace Facade
{
    /// <summary>
    /// The 'Facade' class. Use this class that will be busy with doing all the needed things
    /// </summary>
    public class CarFacade
    {
        private CarModel model;
        private CarEngine engine;
        private CarBody body;
        private CarAccessories accessories;

        public CarFacade()
        {
            model = new CarModel();
            engine = new CarEngine();
            body = new CarBody();
            accessories = new CarAccessories();
        }

        public void CreateCompleteCar()
        {
            Console.WriteLine("******** Creating a Car **********\n");
            model.SetModel();
            engine.SetEngine();
            body.SetBody();
            accessories.SetAccessories();

            Console.WriteLine("\n******** Car creation complete **********");
        }
    }
}
