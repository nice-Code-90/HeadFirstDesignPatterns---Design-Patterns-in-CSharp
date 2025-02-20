using System;
using Observer.WeatherMonitoring.Interfaces;
using Observer.WeatherMonitoring.Subjects;

namespace Observer.WeatherMonitoring.Observers
{
    public class CurrentConditionsDisplay : IObserver<WeatherData>, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private IDisposable subscription;

        public CurrentConditionsDisplay()
        {
        }

        public void Subscribe(IObservable<WeatherData> provider)
        {
            if (provider != null)
                subscription = provider.Subscribe(this);
        }

        public void OnNext(WeatherData value)
        {
            this.temperature = value.GetTemperature();
            this.humidity = value.GetHumidity();
            Display();
        }

        public void OnError(Exception error)
        {
            // Error handling
        }

        public void OnCompleted()
        {
            // Cleanup
        }

        public void Display()
        {
            Console.WriteLine($"Current conditions: {temperature}F degrees and {humidity}% humidity");
        }

        public void Unsubscribe()
        {
            subscription?.Dispose();
        }
    }
}