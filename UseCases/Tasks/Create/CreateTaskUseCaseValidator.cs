using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using GestaoDeProjetos.Api.Enums;
using GestaoDeProjetos.Api.Requests;

namespace GestaoDeProjetos.Api.UseCases.Tasks.Create
{
    public class CreateTaskUseCaseValidator : AbstractValidator<CreateTaskRequestJson>
    {
        public CreateTaskUseCaseValidator()
        {
            RuleFor(task => task.Title)
                .NotEmpty().WithMessage("You must provide a name for the task")
                .MinimumLength(5).WithMessage("The task title must have at least 5 characters")
                .MaximumLength(150).WithMessage("Title characters limit exceeded");

            RuleFor(task => task.Description)
                .NotEmpty().WithMessage("You must provide a description for the task")
                .MaximumLength(500).WithMessage("Description characters limit exceeded");

            RuleFor(task => task.DueDate)
              .GreaterThanOrEqualTo(DateOnly.FromDateTime(DateTime.Today))
              .WithMessage("The due date cannot be in the past");

            RuleFor(task => task.ProjectId)
                .NotEmpty().WithMessage("Invalid project");

            RuleFor(task => task.Priority)
                .IsInEnum()
                .WithMessage("Priority value is not valid, please provide a valid one (LOW, MEDIUM, HIGH)");

            RuleFor(task => task.Status)
                .IsInEnum()
                .WithMessage("Status value is not valid, please provide a valid one (TODO, DOING, DONE)");
        }
    }
}