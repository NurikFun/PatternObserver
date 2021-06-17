using PatternObserver.Interfaces;
using System;
using System.Collections.Generic;

namespace PatternObserver.Implementations
{
    public class Subject : ISubject
    {
        private List<IObserver> observers;

        private double temperature;
        private double humidity;
        private double pressure;
        public double Temperature 
        {
            get { return temperature; }
        }
        public double Humidity
        {
            get { return humidity; }
        }
        public double Pressure
        {
            get { return pressure; }
        }
        public Subject()
        {
            observers = new List<IObserver>();
        }
        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }
        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(temperature, humidity, pressure);
            }
        }

        public void SetValues(double temperature, double humidity, double pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementsChanged();
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

    }
}
