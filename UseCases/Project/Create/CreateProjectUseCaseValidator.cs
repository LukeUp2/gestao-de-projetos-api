using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using GestaoDeProjetos.Api.Requests;

namespace GestaoDeProjetos.Api.UseCases.Project.Create
{
    public class CreateProjectUseCaseValidator : AbstractValidator<CreateProjectRequestJson>
    {
        public CreateProjectUseCaseValidator()
        {
            RuleFor(project => project.Name)
                .NotEmpty().WithMessage("You must provide a project name.")
                .MinimumLength(3).WithMessage("The project name must have at least 3 characters")
                .MaximumLength(100).WithMessage("The project name shouldn't have more than 100 characters");

            RuleFor(project => project.Description)
                .MaximumLength(500).WithMessage("The project description shouldn't have more than 500 characters")
                .When(project => !string.IsNullOrWhiteSpace(project.Description));

            RuleFor(project => project.StartDate)
                .NotEmpty()
                .WithMessage("You must provide a start date for the project");

            RuleFor(project => project.EndDate)
                .GreaterThan(project => project.StartDate)
                .WithMessage("The end data must be higher than the start date of the project")
                .When(project => project.EndDate.HasValue);
        }
    }
}