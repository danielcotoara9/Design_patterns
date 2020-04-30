using System;
using Observer.Interfaces;
using Observer.Observable;

namespace Observer.Observer
{
    public class PhoneDisplay : IObserver
    {
        private WeatherStation _weatherStation;
        public PhoneDisplay(WeatherStation weatherStation)
        {
            _weatherStation = weatherStation;
        }
        public void Update()
        {
            var temperature = _weatherStation.GetTemparature(); 
            Console.WriteLine("PhoneDisplay show new Temperature = {0}", temperature);
            // do other things with this temperature
        }
    }
}
