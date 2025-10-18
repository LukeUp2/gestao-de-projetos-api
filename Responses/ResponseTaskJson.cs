using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoDeProjetos.Api.Enums;

namespace GestaoDeProjetos.Api.Responses
{
    public class ResponseTaskJson
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public StatusEnum Status { get; set; }
        public PriorityEnum Priority { get; set; }
        public DateOnly DueDate { get; set; }
    }
}