using System;

namespace ObserverDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CallObserverDesignPattern();
        }

        /// <summary>
        /// This is how we can implement the observer design pattern
        /// </summary>
        public static void CallObserverDesignPattern()
        {
            YoutubeChannel channel = new YoutubeChannel(); // Observable 

            Subscriber subscriber = new Subscriber(channel); // Observer

            channel.Attach(subscriber); // Subscription

            channel.AddVideo("Observer design pattern implemented"); // Logic of what we need to do
        }
    }
}
