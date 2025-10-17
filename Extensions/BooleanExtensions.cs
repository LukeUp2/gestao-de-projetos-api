using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDeProjetos.Api.Extensions
{
    public static class BooleanExtensions
    {
        public static bool IsFalse(this bool value) => !value;
    }
}