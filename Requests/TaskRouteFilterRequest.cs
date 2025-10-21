using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoDeProjetos.Api.Enums;

namespace GestaoDeProjetos.Api.Requests
{
    public class TaskRouteFilterRequest
    {
        public long ProjectId { get; set; }
        public StatusEnum? Status { get; set; }
        public PriorityEnum? Priority { get; set; }
    }
}