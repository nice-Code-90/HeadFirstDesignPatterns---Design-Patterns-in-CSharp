using System;
using Observer.WeatherMonitoring.Interfaces;
using Observer.WeatherMonitoring.Subjects;

namespace Observer.WeatherMonitoring.Observers
{
    public class ForecastDisplay : IObserver<WeatherData>, IDisplayElement
    {
        private float currentPressure = 29.92f;
        private float lastPressure;
        private IDisposable subscription;

        public ForecastDisplay()
        {
        }

        public void Subscribe(IObservable<WeatherData> provider)
        {
            if (provider != null)
                subscription = provider.Subscribe(this);
        }

        public void OnNext(WeatherData value)
        {
            lastPressure = currentPressure;
            currentPressure = value.GetPressure();
            Display();
        }

        public void OnError(Exception error)
        {
        }

        public void OnCompleted()
        {
        }

        public void Display()
        {
            Console.Write("Forecast: ");
            if (currentPressure > lastPressure)
            {
                Console.WriteLine("Improving weather on the way!");
            }
            else if (currentPressure == lastPressure)
            {
                Console.WriteLine("More of the same");
            }
            else if (currentPressure < lastPressure)
            {
                Console.WriteLine("Watch out for cooler, rainy weather");
            }
        }

        public void Unsubscribe()
        {
            subscription?.Dispose();
        }
    }
}