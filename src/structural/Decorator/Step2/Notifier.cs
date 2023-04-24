namespace Decorator.Step2
{
    public class Notifier
    {
        public string Username { get; set; }

        public readonly DatabaseService _databaseService;

        public Notifier(string username)
        {
            Username = username;
            _databaseService = new DatabaseService();
        }

        public virtual void Send(string message)
        {
            string mail = _databaseService.GetMailFromUsername(Username);
            Console.WriteLine($"Sending {message} by mail to {mail}");
        }
    }
}
