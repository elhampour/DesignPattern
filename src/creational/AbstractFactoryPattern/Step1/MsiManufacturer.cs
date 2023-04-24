namespace AbstractFactoryPattern.Step1
{
    public class MsiManufacturer : Company
    {
        public override Gpu CreateGpu()
        {
            return new MsiGpu();
        }
    }
}
