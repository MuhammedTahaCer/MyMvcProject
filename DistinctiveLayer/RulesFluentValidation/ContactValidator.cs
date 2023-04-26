using EntityLayer.Concrete_Somut;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistinctiveLayer.RulesFluentValidation
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator() { 
            RuleFor(x=>x.UserMail).NotEmpty().WithMessage("Mail adresi boş bırakılamaz");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu Adı  boş bırakılamaz");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı Adı  boş bırakılamaz");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Yeterl karakter sayısı (3) girilmedi");
            RuleFor(x => x.UserName).MinimumLength(3).WithMessage("Yeterl karakter sayısı (3) girilmedi");
            RuleFor(x => x.Subject).MaximumLength(50).WithMessage("Karakter sınırı (50) aşıldı...");
        }
    }
}
