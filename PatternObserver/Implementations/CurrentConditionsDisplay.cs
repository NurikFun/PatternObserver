using PatternObserver.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternObserver.Implementations
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private Subject subject;
        private double temperature;
        private double humidity;

        public CurrentConditionsDisplay(Subject subject)
        {
            this.subject = subject;
            subject.RegisterObserver(this);
        }

        public void Update(double temperature, double humidity, double pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            Display();
        }
        public void Display()
        {
            Console.WriteLine("Current conditions: " + temperature + "F degrees and " + humidity + "% humidity");
        }
    }
}
