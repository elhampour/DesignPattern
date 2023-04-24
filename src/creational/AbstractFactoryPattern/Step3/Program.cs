namespace AbstractFactoryPattern.Step3
{
    public class Program
    {
        void Do()
        {
            Company msi = new MsiManufacturer();
            Gpu msiGpu = msi.CreateGpu();
            Monitor msiMonitor = msi.CreateMonitor();

            Company asus = new MsiManufacturer();
            Gpu asusGpu = msi.CreateGpu();
            Monitor asusMonitor = msi.CreateMonitor();
        }
    }
}
