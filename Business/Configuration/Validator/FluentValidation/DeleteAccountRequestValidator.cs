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
     * Deleting Entities from table by Controlling via FluentValidation
     * In Construction of Validator.
     * 
     * FluentValidation must be inheritted as AbstractValidator<Request>
     */
    public class DeleteAccountRequestValidator : AbstractValidator<DeleteAccountRequest>
    {
        public DeleteAccountRequestValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).WithMessage("ID, 0'dan büyük olmalıdır.");
            RuleFor(x=>x.Name).NotEmpty().WithMessage("İsim Boş Olamaz");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Soyisim Boş Olamaz");
            RuleFor(x => x.NationIdentity).Length(11).WithMessage("Vatandaşlık Numarası 11 Haneli Olmalıdır.");
        }
    }
}
