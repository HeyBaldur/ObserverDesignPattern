namespace ObserverDesignPattern.Interfaces
{
    public interface IVideo
    {
        /// <summary>
        /// Usually, the subscription logic is only a fraction of what a Subject
        /// can really do. Subjects commonly hold some important business logic,
        /// that triggers a notification method whenever something important is
        /// about to happen(or after it).
        /// </summary>
        /// <param name="title"></param>
        void AddVideo(string title);
    }
}
