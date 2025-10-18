using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoDeProjetos.Api.Enums;
using GestaoDeProjetos.Api.Responses;

namespace GestaoDeProjetos.Api.Extensions
{
    public static class TaskExtension
    {
        public static ResponseTaskJson ToResponse(this Entities.Task task)
        {
            return new ResponseTaskJson
            {
                Title = task.Title,
                Description = task.Description,
                DueDate = task.DueDate,
                Priority = task.Priority,
                Status = task.Status
            };
        }
    }
}