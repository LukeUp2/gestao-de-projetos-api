using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoDeProjetos.Api.Exceptions;
using GestaoDeProjetos.Api.Extensions;
using GestaoDeProjetos.Api.Requests;

namespace GestaoDeProjetos.Api.UseCases.Project.Create
{
    public class CreateProjectUseCase
    {
        public void Execute(CreateProjectRequestJson request)
        {
            Validate(request);


        }

        private static void Validate(CreateProjectRequestJson request)
        {
            var validator = new CreateProjectUseCaseValidator();
            var result = validator.Validate(request);

            if (result.IsValid.IsFalse())
            {
                throw new ErrorOnValidationException(result.Errors.Select(e => e.ErrorMessage).ToList());
            }
        }
    }
}