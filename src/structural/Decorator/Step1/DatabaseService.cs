namespace Decorator.Step1
{
    public class DatabaseService
    {
        public string GetMailFromUsername(string username)
        {
            return $"{username}@Mail";
        }
    }
}
