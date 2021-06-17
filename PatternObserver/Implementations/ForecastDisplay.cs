using PatternObserver.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternObserver.Implementations
{
    public class ForecastDisplay : IDisplayElement, IObserver
    {
        private double currentPressure;
        private double lastPressure;
        private Subject subject;

        public ForecastDisplay(Subject subject)
        {
            this.subject = subject;
            subject.RegisterObserver(this);
        }
        public void Update(double temperature, double humidity, double pressure)
        {
            lastPressure = currentPressure;
            currentPressure = pressure;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Forecast: ");
            if (currentPressure > lastPressure)
            {
                Console.WriteLine("Improving weather on the way!");
            }
            else if (currentPressure == lastPressure)
            {
                Console.WriteLine("More of the same");
            }
            Console.WriteLine("Watch out for cooler, rainy weather");
        }
    }
}
