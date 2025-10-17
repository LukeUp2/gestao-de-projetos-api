using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDeProjetos.Api.Exceptions
{
    public class ProjectManagerException : Exception
    {
        public ProjectManagerException(string message) : base(message) { }

    }
}