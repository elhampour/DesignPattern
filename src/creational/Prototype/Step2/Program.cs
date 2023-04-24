namespace Prototype.Step2
{
    internal class Program
    {
        public void DoBefore(List<Vehicle> vehicles)
        {
            List<Vehicle> copyList = new List<Vehicle>();
            foreach (Vehicle item in vehicles)
            {
                if (item.GetType() == typeof(Car))
                {
                    //Add copy logic of car
                }
                else if (item.GetType() == typeof(Bus))
                {

                }
            }
        }

        public void DoAfter(List<Vehicle> vehicles)
        {
            List<Vehicle> copyList = new List<Vehicle>();
            foreach (Vehicle item in vehicles)
            {
                copyList.Add(item.Clone());
            } 
        }
    }
}
