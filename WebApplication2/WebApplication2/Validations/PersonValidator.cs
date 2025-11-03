using FluentValidation;
using WebApplication2.Models;

namespace WebApplication2.Validations
{
    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(person => person.FirstName)
                .NotEmpty().WithMessage("First name should not be empty")
                .MaximumLength(50).WithMessage("max 50 symbols");

            RuleFor(person => person.LastName)
                .NotEmpty().WithMessage("Last name should not be empty")
                .MaximumLength(50).WithMessage("max 50 symbols");

            RuleFor(person => person.JobPosition)
                .NotEmpty().WithMessage("Job position should not be empty")
                .MaximumLength(50).WithMessage("max 50 symbols");

            RuleFor(person => person.Salary)
                .ExclusiveBetween(0, 10000).WithMessage("Salary should be between 0 and 10000");

            RuleFor(person => person.WorkExperience)
                .NotEmpty().WithMessage("Work experience should not be empty");

            RuleFor(person => person.CreateDate)
                .LessThanOrEqualTo(DateTime.Today).WithMessage("Date cannot be in the future");
        }
    }
}
