using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Account
{
    public class DeleteAccountRequest
    {
        public int Id { get; set; } // Account Id
        public string Name { get; set; } // Customer Name
        public string LastName { get; set; } // Customer LastName
        public string NationIdentity { get; set; } // Account Creation Date
    }
}
