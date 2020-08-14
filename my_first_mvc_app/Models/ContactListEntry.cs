using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace my_first_mvc_app.Models
{
    public class ContactListEntry
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public ContactType ContactType { get; set; }

        [Display(Name = "Contact Type")]
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }

        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(50)]
        public string PhoneNumber { get; set; }

        [Display(Name = "Email")]
        [StringLength(50)]
        public string Email { get; set; }
    }

    
}
