using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace dispose.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
