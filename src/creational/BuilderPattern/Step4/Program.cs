namespace BuilderPattern.Step4
{
    public class Program
    {
        public void Do()
        {
            CarDirector carDirector = new CarDirector();    
            CarBuilder carBuilder = new CarBuilder();
            carDirector.BuildBugattyi(carBuilder);
            Car car1 = carBuilder.Build();
        }
    }
}
