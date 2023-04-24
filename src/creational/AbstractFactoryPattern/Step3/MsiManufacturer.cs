namespace AbstractFactoryPattern.Step3
{
    public class MsiManufacturer : Company
    {
        public override Gpu CreateGpu()
        {
            return new MsiGpu();
        }

        public override Monitor CreateMonitor()
        {
            return new MsiMonitor();
        }
    }
}
