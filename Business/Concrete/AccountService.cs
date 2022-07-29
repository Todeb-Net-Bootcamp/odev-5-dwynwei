using AutoMapper;
using Business.Abstract;
using Business.Configuration.Exception;
using Business.Configuration.Response;
using Business.Configuration.Validator.FluentValidation;
using DAL.Abstract;
using DTO.Account;
using FluentValidation;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    /*
     * 
     * {Business Layer}
     * Account Service
     * 
     */
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository; // DI for Account Repository
        private IMapper _mapper; // DI for AutoMapper

        public AccountService(IAccountRepository accountRepository, IMapper mapper)
        {
            _accountRepository = accountRepository; // Constructed Variable for Account Repository
            _mapper = mapper; // Constructed Variable for AutoMapper
        }

        /*
         * Delete Account Request
         */
        public CommandResponse Delete(DeleteAccountRequest request)
        {
            
            var entity = _mapper.Map<Account>(request);
            var validator = new DeleteAccountRequestValidator();
            validator.Validate(request).ValidationException();
            _accountRepository.Delete(entity);
            return new CommandResponse
            {
                Status = true,
                Message = $"Account Information Has Been Deleted | Name: {request.Name}, Last Name: {request.LastName}"
            };
        }
        /*
         * Get All Data From Account Table
         */
        public IEnumerable<Account> getAll()
        {
            return _accountRepository.getAll();
        }
        /*
         * Insert Data To Account Table
         */
        public CommandResponse Insert(CreateAccountRequest request)
        {
            var entity = _mapper.Map<Account>(request);
            var validator = new CreateAccountRequestValidator();
            validator.Validate(request).ValidationException();
            _accountRepository.Insert(entity);

            return new CommandResponse
            {
                Status = true,
                Message = $"Account Information Has Been Added | Name: {request.Name}, Last Name: {request.LastName}"
            };
        }
        /*
         * Update data on Account Table
         */
        public CommandResponse Update(UpdateAccountRequest request)
        {
            var entity = _mapper.Map<Account>(request);
            var validator = new UpdateAccountRequestValidator();
            validator.Validate(request).ValidationException();
            _accountRepository.Update(entity);
            
            return new CommandResponse
            {
                Status = true,
                Message = $"Account Information Has Been Updated | Name: {request.Name}, Last Name: {request.LastName}"
            };
        }
    }
}
