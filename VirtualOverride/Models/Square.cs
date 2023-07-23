namespace VirtualOverride.Models
{
    public class Square : Triangle
    {
        public override float area()
        {
            //return base.area();
            float result = 3*3;
            return result;
        }
    }
}
