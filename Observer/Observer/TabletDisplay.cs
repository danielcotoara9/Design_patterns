using System;
using Observer.Interfaces;
using Observer.Observable;

namespace Observer.Observer
{
    public class TabletDisplay : IObserver
    {
        private readonly WeatherStation _weatherStation;

        public TabletDisplay(WeatherStation weatherStation)
        {
            _weatherStation = weatherStation;
        }
        public void Update()
        {
            var temperature = _weatherStation.GetTemparature();
            Console.WriteLine("TabletDisplay show new Temperature = {0}", temperature);
            // do other things with this temperature
        }
    }
}
