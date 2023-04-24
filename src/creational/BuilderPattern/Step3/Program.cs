namespace BuilderPattern.Step3
{
    public class Program
    {
        public void Do()
        {
            CarBuilder carBuilder = new CarBuilder();
            Car car1 = carBuilder
                .Id(212)
                .Brand("Bugatti")
                .Model("Chiron")
                .Color("Blue")
                .NumberDoors(2)
                .Height(115)
                .Weight(2500)
                .Build();
        }
    }
}
