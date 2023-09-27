using entity.conti;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bussineslayer.validationrules
{
    public class blogvalidator: AbstractValidator<blog>
    {
        public blogvalidator()
        {
            RuleFor(x => x.title).NotEmpty().WithMessage("blog başlığını bğoş geçemessin");
            RuleFor(x => x.blogcontent).NotEmpty().WithMessage("içeriği boş geçemesin");
            RuleFor(x => x.blogbüyükresim).NotEmpty().WithMessage("resmi eklmeden geçemesin");
        }

    }
}
