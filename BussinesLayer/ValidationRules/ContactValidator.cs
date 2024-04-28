using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.ValidationRules
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator() {
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Mail Adresin Boş");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("konuyu boş geçemezsiniz");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("kullanıcı adını boş geçemezsiniz");
            RuleFor(x => x.UserName).MinimumLength(3).WithMessage("min 3 karakter giriniz");
            RuleFor(x => x.Subject).MaximumLength(50).WithMessage("max 50 karakter giriniz");
            RuleFor(x => x.Message).MinimumLength(20).WithMessage("min 20 karakter giriniz");
        }
    }
}
