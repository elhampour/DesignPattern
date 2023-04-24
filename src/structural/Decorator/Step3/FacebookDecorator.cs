namespace Decorator.Step3
{
    public class FacebookDecorator : BaseNotifierDecorator
    {
        public FacebookDecorator(INotifier wrapped) : base(wrapped)
        {
        }

        public override void Send(string message)
        {
            base.Send(message);
            string facebookName = _databaseService.GetFacebookNameFromUsername(GetUsername());
            Console.WriteLine($"Sending {message} on Facebook to {facebookName}");
        }
    }
}
