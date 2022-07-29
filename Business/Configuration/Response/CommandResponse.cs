using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Configuration.Response
{
    /*
     * CommandResponse
     * It sets HTTP Status Codes with Messages
     * Status -> 200,201,400 etc.
     * Message -> Developer defined Messages which wants to shown users.
     */
    public class CommandResponse
    {
        public bool Status { get; set; }
        public string Message { get; set; }
    }
}
