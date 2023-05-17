using EntityLayer.Concrete_Somut;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistinctiveLayer.RulesFluentValidation
{
    public class MessageValidator:AbstractValidator<Message>
    {
        public MessageValidator() { 
        RuleFor(x=>x.receiverMail).NotEmpty().WithMessage("Alıcı adresi boş bırakılamaz");
        RuleFor(x=>x.Subject).NotEmpty().WithMessage("Konu boş bırakılamaz");
        RuleFor(x=>x.MessageContent).MinimumLength(16).WithMessage("Lütfen bir mesaj yazınız");
        }
    }
}
