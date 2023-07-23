using System.ComponentModel.DataAnnotations;

namespace Dispose.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
