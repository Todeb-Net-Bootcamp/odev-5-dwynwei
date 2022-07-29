using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public interface IAccountRepository
    {
        public IEnumerable<Account> getAll(); //Accessing to get all datas from Account Table {Needs to Access By Business Interface}
        public void Insert(Account account);  //Accessing to Insert datas to Account Table {Needs to Access By Business Interface}
        public void Update(Account account);  //Accessing to Update datas from Account Table {Needs to Access By Business Interface}
        public void Delete(Account account);  //Accessing to Delete datas from Account Table {Needs to Access By Business Interface}
    }
}
