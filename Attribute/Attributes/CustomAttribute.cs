namespace Attributes.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple =true) ]

    public class CustomAttribute : Attribute
    {
        public string description { get; set; }
        public string? type { get; set; }
        public CustomAttribute(string description, string type)
        {
            description = description;
            type = type;
        }
    }
}
