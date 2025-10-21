using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoDeProjetos.Api.Enums;

namespace GestaoDeProjetos.Api.Responses
{
    public class ResponseTaskUpdatedJson
    {
        public string Title { get; set; } = string.Empty;
        public StatusEnum Status { get; set; }
        public bool IsUpdateSucess { get; set; }
    }
}