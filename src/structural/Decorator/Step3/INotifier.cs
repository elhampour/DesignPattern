namespace Decorator.Step3
{
    public interface INotifier
    {
        void Send(string message);

        string GetUsername();
    }
}
