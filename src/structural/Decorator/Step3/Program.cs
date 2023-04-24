namespace Decorator.Step3
{
    public class Program
    {
        public void Do()
        {
            INotifier notifier = new FacebookDecorator(new WhatsappDecorator(new Notifier("Ehsan")));

            notifier.Send("Like and Subscribe.");
        }
    }
}
