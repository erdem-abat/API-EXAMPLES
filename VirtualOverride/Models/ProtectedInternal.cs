using ClassModifiers.Models;

namespace VirtualOverride.Models
{
    public class ProtectedInt: ProtectedInternal
    {
        public string GetName()
        {
            return Name;
        }
    }
}
