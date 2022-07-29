using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Configuration.Exception
{
    /*
     * Exceptions For Validations
     * It can be reproducible by needs of project
     * Static Defined
     */
    public static class ValidatorException
    {
        public static void ValidationException(this FluentValidation.Results.ValidationResult validationResult)
        {
            if (validationResult.IsValid)
                return;
            var msg = string.Join(',', validationResult.Errors.Select(x => x.ErrorMessage));
            throw new ValidationException(msg);
        }
    }
}
