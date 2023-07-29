using Aspect_Oriented_Programming.Attributes;

namespace Aspect_Oriented_Programming.Models
{
    public class Student
    {
        public int No { get; set; }
        public string Name { get; set; }
        [Logger]
        [PerformanceAspect]
        public string GetName()
        {
            return Name;
        }
    }
}
