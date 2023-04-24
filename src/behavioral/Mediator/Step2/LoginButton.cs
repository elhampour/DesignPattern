namespace Mediator.Step2
{
    public class LoginButton : JButton, Component
    {
        private Mediator mediator;

        public LoginButton():base("Log in")
        {
        }

        public override void FireActionPerformed(ActionEvent actionEvent)
        {
            mediator.Login();
        }

        public string GetName()
        {
            return "LoginButton";
        }

        public void SetMediator(Mediator mediator)
        {
            this.mediator = mediator;
        }
    }
}
