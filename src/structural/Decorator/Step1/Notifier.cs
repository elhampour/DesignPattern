namespace Decorator.Step1
{
    public class Notifier
    {
        public string Username { get; set; }

        private readonly DatabaseService _databaseService;

        public Notifier(string username, string mail)
        {
            Username = username;
            _databaseService = new DatabaseService();
        }

        public void Send(string message)
        {
            string mail = _databaseService.GetMailFromUsername(Username);
            Console.WriteLine($"Sending {message} by mail to {mail}");
        }
    }
}
