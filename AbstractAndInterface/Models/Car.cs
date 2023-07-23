namespace AbstractAndInterface.Models
{
    public abstract class Car
    {
        public int TopSpeed { get; set; }
        public abstract int performance();
        public void SetTopSpeed(int speed)
        {
            TopSpeed= speed;
        }
        public int GetTopSpeed()
        {
            return TopSpeed;
        }
    }
}
