using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoDeProjetos.Api.Enums;

namespace GestaoDeProjetos.Api.Entities
{
    public class Task
    {
        public long Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public StatusEnum Status { get; set; }
        public PriorityEnum Priority { get; set; }
        public DateOnly DueDate { get; set; }

        //Relationship
        public long ProjectId { get; set; }
        public Project Project { get; set; } = null!; //“Sim, eu sei que estou atribuindo null aqui, mas confie em mim, essa propriedade não será nula em tempo de execução. - Isso que eu estou dizendo para o compilador”

    }
}