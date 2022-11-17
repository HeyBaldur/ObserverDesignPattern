using ObserverDesignPattern.Interfaces;
using System;

namespace ObserverDesignPattern
{
    public class Subscriber : IObserver
    {
        private readonly IObservable _observable;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="observable"></param>
        public Subscriber(IObservable observable)
        {
            this._observable = observable;
        }

        /// <summary>
        /// Concrete Observers react to the updates issued by the Subject they had
        /// been attached to.
        /// </summary>
        public void Update()
        {
            // Let subscriber know about the changes or updates
            Console.WriteLine($"Hey!! There is a new video posted: {(_observable as YoutubeChannel).LastVideoPosted}");
        }
    }
}
