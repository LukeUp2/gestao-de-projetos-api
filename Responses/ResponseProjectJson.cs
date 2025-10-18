using System;
using System.Collections.Generic;
using System.Linq;

namespace GestaoDeProjetos.Api.Responses
{
    public class ResponseProjectJson
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateOnly StartDate { get; set; }
        public DateOnly? EndDate { get; set; }

        public List<ResponseTaskJson> Tasks { get; set; } = [];
    }
}