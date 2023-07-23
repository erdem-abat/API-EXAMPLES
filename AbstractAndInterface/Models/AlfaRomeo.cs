using AbstractAndInterface.Data;

namespace AbstractAndInterface.Models
{
    public class AlfaRomeo : Car, IRacable
    {
        public string Model = "Giulia";
        
        public override int performance()
        {
            SetTopSpeed(320);

            return GetTopSpeed() / 3;
        }

        public void Race(Car car)
        {
            Console.WriteLine(Model + car.performance() + car.GetTopSpeed());
        }
    }
}
