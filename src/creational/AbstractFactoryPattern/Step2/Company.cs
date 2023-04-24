namespace AbstractFactoryPattern.Step2
{
    public abstract class Company
    {
        public abstract Component CreateComponent(string type);
    }
}
