namespace Decorator.Step2
{
    public class DatabaseService
    {
        public string GetMailFromUsername(string username)
        {
            return $"{username}@Mail";
        }

        public string GetPhoneNumberFromUsername(string username)
        {
            return $"{username}@Phone";
        }

        public string GetFacebookNameFromUsername(string username)
        {
            return $"{username}@Facebook";
        }
    }
}
