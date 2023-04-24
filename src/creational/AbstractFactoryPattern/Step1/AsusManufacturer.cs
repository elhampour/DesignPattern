namespace AbstractFactoryPattern.Step1
{
    public class AsusManufacturer : Company
    {
        public override Gpu CreateGpu()
        {
            return new AsusGpu();
        }
    }
}
