namespace Decorator.Step2
{
    public class FacebookNotifier : Notifier
    {
        public FacebookNotifier(string username) :base(username)
        {
        }

        public override void Send(string message)
        {
            string facebookName = _databaseService.GetFacebookNameFromUsername(Username);
            Console.WriteLine($"Sending {message} on Facebook to {facebookName}");
        }
    }
}
