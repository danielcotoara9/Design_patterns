using System;
using System.Timers;
using Abstract_Factory.Abstractization;
using Abstract_Factory.Client;
using Abstract_Factory.Concrete_Factory;
using Adapter.Abstractization;
using Adapter.Concretion;
using Command.Version_1;
using Command.Version_1.Concrete_Commands;
using Command.Version_1.Invokers;
using Command.Version_2.Invoker;
using Decorator;
using Decorator.Decorators;
using Facade;
using Factory_Method.Abstractization_Product;
using Factory_Method.Concrete_Creator;
using Factory_Method.Creator;
using Observer.Interfaces;
using Observer.Observable;
using Observer.Observer;
using Singleton;
using Adapter = Adapter.Concretion.Adapter;

namespace X_Design_Patterns_Console_X
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n                                          !!!!!   Hello Design Patterns   !!!!!\n\n");
            Console.ForegroundColor = ConsoleColor.White;

            //Decorator();
            //Observer();
            //FactoryMethod();
            //AbstractFactory();
            //Singleton();
            //Command();
            //Adapter();
            Facade();


            //var southAfrica = new Countries();
            //southAfrica.Display("12");

            Console.ReadKey();
        }

        // Specify what you want to happen when the Elapsed event is raised.
        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            Console.WriteLine("Hello World!");
        }

        #region Helpers

        public static void Decorator()
        {
            Console.WriteLine("-------------------------------------------------- Decorator_Pattern -----------------------------------------------\n");
            Decorator_Pattern();
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------\n");
        }

        public static void Observer()
        {
            Console.WriteLine("-------------------------------------------------- Observer_Pattern ------------------------------------------------\n");
            Observer_Pattern();
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------\n");
        }

        public static void FactoryMethod()
        {
            Console.WriteLine("-------------------------------------------------- Factory_Method_Pattern ------------------------------------------------\n");
            Factory_Method_Pattern();
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------\n");
        }

        private static void AbstractFactory()
        {
            Console.WriteLine("-------------------------------------------------- Absrtact_Factory_Pattern ------------------------------------------------\n");
            Abstract_Factory_Pattern();
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------\n");
        }

        private static void Singleton()
        {
            Console.WriteLine("-------------------------------------------------- Singleton_Pattern ------------------------------------------------\n");
            Singleton_Pattern();
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------\n");
        }

        private static void Command()
        {
            Console.WriteLine("-------------------------------------------------- Command_Pattern_1 ------------------------------------------------\n");
            Command_Pattern_1();
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------\n\n\n");

            Console.WriteLine("-------------------------------------------------- Command_Pattern_2 ------------------------------------------------\n");
            Command_Pattern_2();
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------\n");
        }

        private static void Adapter()
        {
            Console.WriteLine("-------------------------------------------------- Adapter_Pattern ------------------------------------------------\n");
            Adapter_Pattern();
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------\n\n\n");
        }

        private static void Facade()
        {
            Console.WriteLine("-------------------------------------------------- Facade_Pattern ------------------------------------------------\n");
            Facade_Pattern();
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------\n\n\n");
        }
        #endregion

        #region Desing Patterns

        private static void Decorator_Pattern()
        {
            // TODO attaches additional responsibilities to an object dynamically
            // TODO provide a flexibility alternative to subclassing for extending functionality => To Espresso we attache Caramel
            //                                                                              => To Espresso and Caramel we attache Vanilla

            Console.WriteLine(nameof(Constants.Espresso_Cost) + " {0}", Constants.Espresso_Cost);
            Console.WriteLine(nameof(Constants.Caramel_Cost) + " {0}", Constants.Caramel_Cost);
            Console.WriteLine(nameof(Constants.Vanilla_Cost) + " {0}", Constants.Vanilla_Cost);


            var caramelDecorator = new Caramel(new Espresso());
            var totalCaramelCost = caramelDecorator.Cost();
            var vanillaDecorator = new Vanilla(caramelDecorator);
            var totalVanillaCost = vanillaDecorator.Cost();

            Console.WriteLine("Total cost = [ new Caramel(new Espresso()).Cost() ] = {0}", totalCaramelCost);
            Console.WriteLine("Total cost = [ new Vanilla(new Caramel(new Espresso())).Cost() ] = {0}", totalVanillaCost);

            Console.WriteLine("\n");

        }

        private static void Observer_Pattern()
        {
            // TODO The Observer pattern defines one to many dependencies between objects so that when one object changes its state
            // TODO all of its dependencies are notified and updated automatically

            var weatherStation = new WeatherStation();
            IObserver phoneDisplay = new PhoneDisplay(weatherStation);
            IObserver tabletDisplay = new TabletDisplay(weatherStation);

            // push the observer in the list
            weatherStation.Add(phoneDisplay);
            weatherStation.Add(tabletDisplay);

            Console.WriteLine("Observable Weather Station received new Temperature so it will update the observers");
            //poll the date from observable for each observer in the list
            weatherStation.Notify();
        }

        private static void Factory_Method_Pattern()
        {
            // TODO when you are about to instantiate lets encapsulate that instantiation so that we can make uniform in all places ->
            // TODO -> you can use the factory when you want to instantiate and the factory is responsible to instantiate appropriately

            CardFactory factory = null;

            Console.Write("Enter the card type you would like to visit: ");
            string card = Console.ReadLine();

            switch (card.ToLower())
            {
                case "moneyback":
                    factory = new MoneyBackFactory(50000, 0);
                    break;
                case "titanium":
                    factory = new TitaniumFactory(100000, 500);
                    break;
                case "platinum":
                    factory = new PlatinumFactory(500000, 1000);
                    break;
                default:
                    break;
            }

            CreditCard creditCard = factory.GetCreditCard();
            Console.WriteLine("\nYour card details are below : \n");
            Console.WriteLine("Card Type: {0}\nCredit Limit: {1}\nAnnual Charge: {2}",
                creditCard.CardType, creditCard.CreditLimit, creditCard.AnnualCharge);
            Console.ReadKey();

        }

        private static void Abstract_Factory_Pattern()
        {
            // Definition = The abstract factory pattern provide an interface for creating families of related or dependent objects without specifying their concrete classes
            // TODO similar with Factory Method Pattern => Abstract Factory is a set of factory methods, Abstract Factory makes use of multiple factory methods

            IMobilePhone nokiaMobilePhone = new Nokia();
            MobileClient nokiaClient = new MobileClient(nokiaMobilePhone);

            Console.WriteLine("********* NOKIA **********");
            Console.WriteLine(nokiaClient.GetSmartPhoneModelDetails());
            Console.WriteLine(nokiaClient.GetNormalPhoneModelDetails());

            IMobilePhone samsungMobilePhone = new Samsung();
            MobileClient samsungClient = new MobileClient(samsungMobilePhone);

            Console.WriteLine("******* SAMSUNG **********");
            Console.WriteLine(samsungClient.GetSmartPhoneModelDetails());
            Console.WriteLine(samsungClient.GetNormalPhoneModelDetails());

            Console.ReadKey();
        }

        private static void Singleton_Pattern()
        {
            // Definition : The Singleton Pattern ensures that a class has only one instance and provide a global point to access to it.
            // TODO When ask for an instance you will get the same instance if one is already created

            Calculate.GetInstance().ValueOne = 10.5;
            Calculate.GetInstance().ValueTwo = 5.5;
            Console.WriteLine("Addition : " + Calculate.GetInstance().Addition());
            Console.WriteLine("Subtraction : " + Calculate.GetInstance().Subtraction());
            Console.WriteLine("Multiplication : " + Calculate.GetInstance().Multiplication());
            Console.WriteLine("Division : " + Calculate.GetInstance().Division());

            Console.WriteLine("\n----------------------\n");

            Calculate.GetInstance().ValueTwo = 10.5;
            Console.WriteLine("Addition : " + Calculate.GetInstance().Addition());
            Console.WriteLine("Subtraction : " + Calculate.GetInstance().Subtraction());
            Console.WriteLine("Multiplication : " + Calculate.GetInstance().Multiplication());
            Console.WriteLine("Division : " + Calculate.GetInstance().Division());
        }

        public static void Command_Pattern_1()
        {
            // a light that supports turn on/off dean up/down
            var light = new Light();

            // list of commands that will be provided to the invoker, that is actually the remote
            var lightOnCommand = new LightOnCommand(light);
            var lightOffCommand = new LightOffCommand(light);
            var lightUpCommand = new LightUpCommand(light);
            var lightDownCommand = new LightDownCommand(light);

            // a remote with 4 buttons
            var invoker = new Invoker(lightOnCommand, lightOffCommand, lightUpCommand, lightDownCommand);

            Console.WriteLine("Lets click all the four buttons of the application\n");

            invoker.ClikOn();
            invoker.ClikOff();
            invoker.ClikUp();
            invoker.ClikDown();
        }

        public static void Command_Pattern_2()
        {
            // Create user and let her compute
            User user = new User();

            // User presses calculator buttons
            Console.WriteLine("Default Value = 0\n");

            user.Compute('+', 100);
            user.Compute('-', 50);
            user.Compute('*', 10);
            user.Compute('/', 2);

            // Undo 4 commands
            user.Undo(4);

            // Redo 3 commands
            user.Redo(3);
        }

        public static void Adapter_Pattern()
        {
            var adaptee = new Adaptee();
            ITarget target = new global::Adapter.Concretion.Adapter(adaptee);

            Console.WriteLine("Adaptee interface is incompatible with the client.");
            Console.WriteLine("But with adapter client can call it's method.");

            Console.WriteLine(target.GetRequest());
        }

        public static void Facade_Pattern()
        {
            var carFacade = new CarFacade();
            carFacade.CreateCompleteCar();
        }
        #endregion

    }

    public class Countries
    {
        public void Display(string countryId)
        {
            Console.WriteLine("Country ID is " + countryId);
        }

        public void Display(int countryId)
        {
            Console.WriteLine("Country ID is " + countryId);
        }
    }

}
