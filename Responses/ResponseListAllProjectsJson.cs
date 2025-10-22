using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDeProjetos.Api.Responses
{
    public class ResponseListAllProjectsJson
    {
        public List<ResponseProjectJson> Items { get; set; } = [];
        public int Page { get; set; }
        public int Total { get; set; }
    }
}