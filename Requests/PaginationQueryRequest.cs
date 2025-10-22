using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDeProjetos.Api.Requests
{
    public class PaginationQueryRequest
    {
        public int? Page { get; set; }
        public int? PerPage { get; set; }
    }
}