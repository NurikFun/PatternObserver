using PatternObserver.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternObserver.Implementations
{
    public class StatisticsDisplay : IDisplayElement, IObserver
    {

        private double maxTemp = 0;
        private double minTemp = 200;
        private double tempSum = 0;
        private int numReadings = 0;
        private Subject subject;

        public StatisticsDisplay(Subject subject)
        {
            this.subject = subject;
            subject.RegisterObserver(this);
        }

        public void Update(double temperature, double humidity, double pressure)
        {
            tempSum += temperature;
            numReadings++;

            if (temperature > maxTemp)
            {
                maxTemp = temperature;
            }

            if (temperature < minTemp)
            {
                minTemp = temperature;
            }

            Display();
        }
        public void Display()
        {
            Console.WriteLine("Avg/Max/Min temperature = " + (tempSum / numReadings) + "/" + maxTemp + "/" + minTemp);
        }
    }
}
