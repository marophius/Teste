using FluentValidation;
using Teste.WebApi.DTOs;

namespace Teste.WebApi.Validators
{
    public class UsuarioValidator : AbstractValidator<UsuarioDTO>
    {
        public UsuarioValidator()
        {
            RuleFor(u => u.Email)
                .NotEmpty().WithMessage("{PropertyName} não pode ser vazio")
                ;
        }
    }
}
