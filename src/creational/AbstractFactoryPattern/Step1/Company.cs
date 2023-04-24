namespace AbstractFactoryPattern.Step1
{
    public abstract class Company
    {
        public Gpu AssembleGpu()
        {
            Gpu gpu = CreateGpu();
            gpu.Assemble();
            return gpu;
        }

        public abstract Gpu CreateGpu();
    }
}
