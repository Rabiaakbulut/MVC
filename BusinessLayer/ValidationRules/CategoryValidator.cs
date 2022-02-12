using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("kategori adını boş geçemezsiniz");
            RuleFor(x=>x.CategoryDescription).NotEmpty().WithMessage("açıklamayı boş geçemezsiniz");
            RuleFor(x=>x.CategoryName).MinimumLength(3).WithMessage("lütfen en az 3 karakter girişi yapın");
            RuleFor(x=>x.CategoryName).MaximumLength(20).WithMessage("en fazla 20 karakter girin");
        }
    }
}
