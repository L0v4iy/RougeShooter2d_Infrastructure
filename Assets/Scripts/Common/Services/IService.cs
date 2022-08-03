namespace Common.Services
{
    public interface IService<in T>
    {
        void AddSubscriber(T subscriber);
        void RemoveSubscriber(T subscriber);
    }
}