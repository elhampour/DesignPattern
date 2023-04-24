namespace Mediator.Step1
{
    public class LoginButton : JButton
    {
        private readonly TextBox userText;
        private readonly TextBox passText;

        public LoginButton(TextBox userText, TextBox passText)
        {
            this.userText = userText;
            this.passText = passText;
        }

        public override void FireActionPerformed(ActionEvent actionEvent)
        {
            string userName = userText.GetText();
            string password = passText.GetText();
            //valiates username and password
            //logs in the user or pops error message
        }
    }
}
