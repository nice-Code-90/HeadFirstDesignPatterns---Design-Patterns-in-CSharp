using System;
using Observer.WeatherMonitoring.Interfaces;
using Observer.WeatherMonitoring.Subjects;

namespace Observer.WeatherMonitoring.Observers
{
    public class StatisticsDisplay : IObserver<WeatherData>, IDisplayElement
    {
        private float maxTemp = 0.0f;
        private float minTemp = 200f;
        private float tempSum = 0.0f;
        private int numReadings;
        private IDisposable subscription;

        public StatisticsDisplay()
        {
        }

        public void Subscribe(IObservable<WeatherData> provider)
        {
            if (provider != null)
                subscription = provider.Subscribe(this);
        }

        public void OnNext(WeatherData value)
        {
            float temperature = value.GetTemperature();
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

        public void OnError(Exception error)
        {
        }

        public void OnCompleted()
        {
        }

        public void Display()
        {
            Console.WriteLine($"Avg/Max/Min temperature = {tempSum / numReadings:F1}/{maxTemp:F1}/{minTemp:F1}");
        }

        public void Unsubscribe()
        {
            subscription?.Dispose();
        }
    }
}