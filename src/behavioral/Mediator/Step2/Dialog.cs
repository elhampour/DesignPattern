namespace Mediator.Step2
{
    public class Dialog : Mediator
    {
        private TextBox userTextBox;
        private TextBox passwordTextBox;
        private LoginButton button;

        public void Login()
        {
            string username = userTextBox.GetText();
            string password = passwordTextBox.GetText();

            //validate usernmae and password
            //logs in the user or pops error message
        }
    }
}
