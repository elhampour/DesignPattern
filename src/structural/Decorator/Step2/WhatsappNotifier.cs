namespace Decorator.Step2
{
    public class WhatsappNotifier : Notifier
    {
        public WhatsappNotifier(string username) : base(username)
        {
        }

        public override void Send(string message)
        {
            string phoneNumber = _databaseService.GetPhoneNumberFromUsername(Username);
            Console.WriteLine($"Sending {message} by Whatsapp on {phoneNumber}");
        }
    }
}
