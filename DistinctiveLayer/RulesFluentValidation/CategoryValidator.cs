using EntityLayer.Concrete_Somut;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistinctiveLayer.RulesFluentValidation
{
    public class CategoryValidator:AbstractValidator<Category>
    {

        public CategoryValidator()
        {
           // RuleFor(x => x.CategoryName).NotEmpty().WithMessage("....");
        }

    }
}
