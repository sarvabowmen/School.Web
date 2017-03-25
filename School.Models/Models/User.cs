using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    public class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string DisplayID { get; set; }

        public Status Status { get; set; }

        public ICollection<UserSections> UserSections { get; set; }
    }

    public enum Status
    {
        Active = 1,
        InActive = 0
    }
}
