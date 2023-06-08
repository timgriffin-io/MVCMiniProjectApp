using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MVCMiniProject.Models
{
    public class AddressModel
    {
        [Required]
        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }

        [Required]
        public string City { get; set; }
        
        [Required]
        public string State { get; set; }
        
        [Required]
        [Display(Name = "Zip Code")]
        [StringLength(maximumLength: 10, MinimumLength =5)]
        public string ZipCode { get; set; }

    }
}
