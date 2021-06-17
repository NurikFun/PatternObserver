using PatternObserver.Implementations;
using PatternObserver.Interfaces;
using System;

namespace PatternObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(subject);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(subject);
            ForecastDisplay forecastDisplay = new ForecastDisplay(subject);

            subject.SetValues(80, 65, 30.4);
            subject.SetValues(82, 70, 29.2);
            subject.SetValues(78, 90, 29.2);


            subject.RemoveObserver(forecastDisplay);
            subject.SetValues(62, 90, 28.1);

            Console.ReadKey();
        }
    }
}
