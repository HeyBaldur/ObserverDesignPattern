using ObserverDesignPattern.Interfaces;
using System;
using System.Collections.Generic;

namespace ObserverDesignPattern
{
    public class YoutubeChannel : IObservable, IVideo
    {
        private readonly HashSet<IObserver> _observers = new HashSet<IObserver>();
        public string LastVideoPosted = string.Empty;

        public void AddVideo(string title)
        {
            LastVideoPosted = title;
            Notify();
            Console.WriteLine("New video posted!!!");
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
            Console.WriteLine("Subscriber added");
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
            Console.WriteLine("One subcriber has been removed");
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }
    }
}
