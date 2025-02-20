using Observer.WeatherMonitoring.Interfaces;
using System;
using System.Collections.Generic;

namespace Observer.WeatherMonitoring.Subjects
{
    public class WeatherData : IObservable<WeatherData>
    {
        private readonly List<IObserver<WeatherData>> observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new List<IObserver<WeatherData>>();
        }

        public IDisposable Subscribe(IObserver<WeatherData> observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);
            return new Unsubscriber(observers, observer);
        }

        private class Unsubscriber : IDisposable
        {
            private readonly List<IObserver<WeatherData>> _observers;
            private readonly IObserver<WeatherData> _observer;

            public Unsubscriber(List<IObserver<WeatherData>> observers, IObserver<WeatherData> observer)
            {
                _observers = observers;
                _observer = observer;
            }

            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                    _observers.Remove(_observer);
            }
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.OnNext(this);
            }
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementsChanged();
        }

        public float GetTemperature() => temperature;

        public float GetHumidity() => humidity;

        public float GetPressure() => pressure;
    }
}