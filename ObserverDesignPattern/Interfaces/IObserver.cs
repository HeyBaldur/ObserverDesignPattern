namespace ObserverDesignPattern.Interfaces
{
    public interface IObserver
    {
        /// <summary>
        /// Trigger an update in each subscriber.
        /// </summary>
        void Update();
    }
}
