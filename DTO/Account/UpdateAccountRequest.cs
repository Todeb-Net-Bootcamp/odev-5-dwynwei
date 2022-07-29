using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Account
{
    public class UpdateAccountRequest
    {
        public int Id { get; set; } // Account Id
        public string Name { get; set; } // Customer Name
        public string LastName { get; set; } // Customer LastName
        public string Address { get; set; } // Customer Contact Address
        public bool Status { get; set; } // Account Status -> Inactive or Active
        public int CardId { get; set; } // Connection between Card Model and Account Model
        public Card Cards { get; set; } // Card Model
    }
}
