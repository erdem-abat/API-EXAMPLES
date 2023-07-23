namespace ClassModifiers.Models
{
    public class Private
    {
        private int cost { get; set; }
        private int getPrice()
        {
            return cost;
        }
    }
}
