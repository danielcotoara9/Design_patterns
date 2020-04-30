using System.Collections.Generic;
using Observer.Interfaces;

namespace Observer.Observable
{
    public class WeatherStation : IObservable
    {
        List<IObserver> observers = new List<IObserver>();
        private int Temperature;

        public void Add(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Remove(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }

        public int GetTemparature()
        {
            return GetSensorTemperature();
        }

        private int  GetSensorTemperature()
        {
            // reads temperature from somewhere
            return 40;
        }

    }
}
