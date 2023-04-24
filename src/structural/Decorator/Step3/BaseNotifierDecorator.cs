namespace Decorator.Step3
{
    public abstract class BaseNotifierDecorator : INotifier
    {
        private readonly INotifier wrapped;
        protected readonly DatabaseService _databaseService;

        public BaseNotifierDecorator(INotifier wrapped)
        {
            this.wrapped = wrapped;
            _databaseService = new DatabaseService();
        }

        public virtual void Send(string message)
        {
            wrapped.Send(message);
        }

        public virtual string GetUsername()
        {
            return wrapped.GetUsername();
        }
    }
}
