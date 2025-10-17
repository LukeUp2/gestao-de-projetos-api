using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDeProjetos.Api.Exceptions
{
    public class ErrorOnValidationException : ProjectManagerException
    {
        public IList<string> ErrorMessages { get; set; }

        public ErrorOnValidationException(IList<string> errors) : base(string.Empty)
        {
            ErrorMessages = errors;
        }


    }
}