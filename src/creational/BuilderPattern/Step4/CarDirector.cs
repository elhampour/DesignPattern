namespace BuilderPattern.Step4
{
    public class CarDirector
    {
        public void BuildBugattyi(CarBuilder builder)
        {
            builder
                .Id(212)
                .Brand("Bugatti")
                .Model("Chiron")
                .Color("Blue")
                .NumberDoors(2)
                .Height(115)
                .Weight(2500)
                .Build();
        }

        public void BuildLambo(CarBuilder builder)
        {
            builder
                .Id(212)
                .Brand("Lamborgini")
                .Model("Aventador")
                .Color("Yellow")
                .NumberDoors(2)
                .Height(115)
                .Weight(2500)
                .Build();
        }
    }
}
