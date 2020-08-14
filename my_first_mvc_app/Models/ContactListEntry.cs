using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_first_mvc_app.Models
{
    public class ContactListEntry
    {
        public int Id { get; set; }

        public ContactType ContactType { get; set; }

        public string Name { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }
    }

    
}
