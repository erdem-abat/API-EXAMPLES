using Attributes.Attributes;
using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Attributes.Models
{
    public class Payment
    {
        [Required]
        public int cost { get; set; }
    }
}
