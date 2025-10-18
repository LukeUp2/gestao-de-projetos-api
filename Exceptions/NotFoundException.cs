using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDeProjetos.Api.Exceptions
{
    public class NotFoundException : ProjectManagerException
    {
        public NotFoundException(string message) : base(message)
        {

        }
    }
}