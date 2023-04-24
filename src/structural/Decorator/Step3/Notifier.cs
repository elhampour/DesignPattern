namespace Decorator.Step3
{
    public class Notifier : INotifier
    {
        private readonly string username;

        public readonly DatabaseService _databaseService;

        public Notifier(string username)
        {
            this.username = username;
            _databaseService = new DatabaseService();
        }

        public virtual void Send(string message)
        {
            string mail = _databaseService.GetMailFromUsername(username);
            Console.WriteLine($"Sending {message} by mail to {mail}");
        }

        public virtual string GetUsername()
        {
            return username;
        }
    }
}
