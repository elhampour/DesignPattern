namespace AbstractFactoryPattern.Step2
{
    public class AsusManufacturer : Company
    {
        public override Component CreateComponent(string type)
        {
            Component component = null;
            if (type == "GPU")
            {
                component = new AsusGpu();
            }
            else
            {
                component = new AsusMonitor();
            }
            return component;
        }
    }
}
