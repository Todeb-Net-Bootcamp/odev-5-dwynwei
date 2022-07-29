using DTO.Account;
using FluentValidation;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Configuration.Validator.FluentValidation
{
    /*
     * FluentValidation.dll
     * Updating Entities from table by Controlling via FluentValidation
     * In Construction of Validator.
     * 
     * FluentValidation must be inheritted as AbstractValidator<Request>
     */
    public class UpdateAccountRequestValidator : AbstractValidator<UpdateAccountRequest>
    {
        private UpdateAccountRequest _request;
        public UpdateAccountRequestValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).WithMessage("Account ID, 0 ve 0'dan Küçük Olamaz"); ;
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim Alanı Boş Olmamalıdır !");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Soyad Alanı Boş Olmamalıdır !");
            RuleFor(x => x.Address).MinimumLength(20).WithMessage("Geçerli bir Adres Giriniz !");
            RuleFor(x => x.Cards.CardNumber).NotEmpty().WithMessage("Geçerli bir Kart Numarası Giriniz !");
            RuleFor(x => x.Cards.ExpirationDate).NotEmpty().WithMessage("Geçersiz Tarih Formatı");
            RuleFor(x => x.Cards.TransactionId).GreaterThan(0).WithMessage("Transacion ID, 0 ve 0'dan Küçük Olamaz");
        }

        protected bool beAValidDate(DateTime val)
        {
            DateTime date;
            return DateTime.TryParse(val.ToString("MM.yy"), out date);
        }
    }
}
