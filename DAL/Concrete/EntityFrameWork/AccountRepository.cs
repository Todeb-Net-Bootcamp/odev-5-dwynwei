using DAL.Abstract;
using DAL.DBContexts;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    /*
     * Entity Framework Structure
     * This Layer operates datas between Database Layer and Business
     */
    public class AccountRepository : IAccountRepository
    {
        private TODEBAccountDbContext _context;
        public AccountRepository(TODEBAccountDbContext context) // Construction for AccountRepository
        {
            _context = context; // Gets DbContext {EntityFrameworkCore.dll}
        }

        public void Delete(Account account) //Delete Operation
        {
            _context.Remove(account);
            _context.SaveChanges();
        }

        public IEnumerable<Account> getAll() // Read Operation
        {
            return _context.Accounts.ToList();
        }

        public void Insert(Account account) // Insert Operation
        {
            _context.Accounts.Add(account);
            _context.SaveChanges();
        }

        public void Update(Account account) // Update Operation
        {
            _context.Accounts.Update(account);
            _context.SaveChanges();
        }
    }
}
