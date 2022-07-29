using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Account
{
    public class CreateAccountRequest
    {
        public string Name { get; set; } // Customer Name
        public string LastName { get; set; } // Customer LastName
        public string NationIdentity { get; set; } // Turkish Citizen ID
        public string Address { get; set; } // Address
        public bool Status { get; set; } // Shows that Account is Active or Passive
    }
}
