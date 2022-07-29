using DTO.Account;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Configuration.Validator.FluentValidation
{
    /*
     * FluentValidation.dll
     * Creating Entities to table by Controlling via FluentValidation
     * In Construction of Validator.
     * 
     * FluentValidation must be inheritted as AbstractValidator<Request>
     */
    public class CreateAccountRequestValidator : AbstractValidator<CreateAccountRequest>
    {
        public CreateAccountRequestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim Alanı Boş Olmamalıdır !");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Soyad Alanı Boş Olmamalıdır !");
            RuleFor(x => x.NationIdentity).MinimumLength(11).MaximumLength(11).WithMessage("TC Kimlik Alanı 11 Haneli Olmalıdır !");
            RuleFor(x => x.Address).MinimumLength(20).WithMessage("Geçerli bir Adres Giriniz !");
        }
    }
}
