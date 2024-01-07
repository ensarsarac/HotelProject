using FluentValidation;
using HotelProjectWebUI.Dtos.GuestDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProjectWebUI.ValidationRules.GuestValidationRules
{
    public class UpdateGuestDtoValidator : AbstractValidator<UpdateGuestDto>
    {
        public UpdateGuestDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş bırakılamaz.");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad alanı boş bırakılamaz.");
            RuleFor(x => x.City).NotEmpty().WithMessage("Şehir alanı boş bırakılamaz.");
        }
    }
}
