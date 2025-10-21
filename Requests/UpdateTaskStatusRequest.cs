using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoDeProjetos.Api.Enums;

namespace GestaoDeProjetos.Api.Requests
{
    public class UpdateTaskStatusRequest
    {
        public StatusEnum Status { get; set; }
    }
}