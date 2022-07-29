using Business.Abstract;
using DTO.Account;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Entities;

namespace TodebAPI.Controllers
{
    /*
     * 
     * This is Controller Class which recieves
     * the request from API
     * 
     */
    [Route("api/[controller]")] // EndPoint
    [ApiController] 
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService; // DI Account Service from BUSINESS LAYER

        public AccountController(IAccountService accountService) // Constructor for Account Controller
        {
            _accountService = accountService;
        }
        /*
         * Rest Are HttpMethods which are related with
         * ACCOUNT Model used via ACCOUNT SERVICE
         */
        [HttpGet]
        public IActionResult Get() 
        {
            var datas = _accountService.getAll();
            return Ok(datas);
        }
        
        [HttpPost]
        public IActionResult Post(CreateAccountRequest account)
        {
            var response=_accountService.Insert(account);
            return Ok(response);
        }

        [HttpPut]
        public IActionResult Update(UpdateAccountRequest request)
        {
            var response = _accountService.Update(request);
            return Ok(response);
        }

        [HttpDelete]
        public IActionResult Delete(DeleteAccountRequest request)
        {
            var response = _accountService.Delete(request);
            return Ok(response);
        }

    }
}
