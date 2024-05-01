using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.ValidationRules
{
    public class MessagesValidator:AbstractValidator<Message>
    {
        public MessagesValidator() {

            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("alıcı mailini  boş geçemezsiniz");
            RuleFor(x => x.SenderMail).NotEmpty().WithMessage("gönderici mailini boş geçemezsiniz");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("min 3 karakter giriniz");
            RuleFor(x => x.MessagesContent).MinimumLength(20).WithMessage("MİN 20 karakter giriniz");
        }
    }
}
