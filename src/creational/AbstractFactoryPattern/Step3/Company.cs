namespace AbstractFactoryPattern.Step3
{
    public abstract class Company
    {
        public abstract Gpu CreateGpu();

        public abstract Monitor CreateMonitor();
    }
}
