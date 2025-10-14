using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDeProjetos.Api.Entities
{
    public class Project
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateOnly StartDate { get; set; } = DateOnly.FromDateTime(DateTime.UtcNow);
        public DateOnly? EndDate { get; set; }

        //Relationship
        public List<Task> Tasks { get; set; } = [];
    }
}