using EntityLayer.Concrete_Somut;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistinctiveLayer.RulesFluentValidation
{
    public class WritersValidator : AbstractValidator<Writer>
    {
        public WritersValidator()
        {
            // RuleFor(x => x.CategoryName).NotEmpty().WithMessage("....");
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Bu alan Boş Bırakılamaz.");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Bu alan Boş Bırakılamaz.");
            RuleFor(x => x.About).NotEmpty().WithMessage("Bu alan Boş Bırakılamaz.");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Bu alan Boş Bırakılamaz.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Bu alan Boş Bırakılamaz.");
            RuleFor(x => x.Mail).Matches("@").WithMessage("Lütfen uygun formatta mail adresi giriniz");
        }
    }
}
