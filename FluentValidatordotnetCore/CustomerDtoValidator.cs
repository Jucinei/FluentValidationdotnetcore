using FluentValidation;
using FluentValidatordotnetCore.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FluentValidatordotnetCore
{
    public class CustomerDtoValidator : AbstractValidator<Customer>
    {
        public CustomerDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("O nome é obrigatório");
            RuleFor(x => x.Name).MaximumLength(100).WithMessage("O tamanho máximo é de 100 caracteres");
            RuleFor(x => x.Name).MinimumLength(10).WithMessage("O tamanho minimo é de 10 caracteres");

            RuleFor(x => x.Email).EmailAddress().WithMessage("Email invalido");
        }
    }
}
