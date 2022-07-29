using Business.Configuration.Response;
using DTO.Account;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    /*
     * {Business Layer}
     * Account Service Interface 
     */
    public interface IAccountService
    {
        public IEnumerable<Account> getAll(); // Creating a Request which has Create Account Job
        public CommandResponse Insert(CreateAccountRequest request); // Creating a Request which has Create Account Job
        public CommandResponse Update(UpdateAccountRequest request); // Creating a Request which has Update Account Job
        public CommandResponse Delete(DeleteAccountRequest request); // Creating a Request which has Delete Account Job
    }
}
