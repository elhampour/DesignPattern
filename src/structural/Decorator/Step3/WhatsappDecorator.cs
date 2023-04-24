namespace Decorator.Step3
{
    public class WhatsappDecorator : BaseNotifierDecorator
    {
        public WhatsappDecorator(INotifier wrapped) : base(wrapped)
        {
        }

        public override void Send(string message)
        {
            base.Send(message);
            string phoneNumber = _databaseService.GetPhoneNumberFromUsername(GetUsername());
            Console.WriteLine($"Sending {message} by Whatsapp on {phoneNumber}");
        }
    }
}
