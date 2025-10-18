using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoDeProjetos.Api.Entities;
using GestaoDeProjetos.Api.Requests;

namespace GestaoDeProjetos.Api.Extensions
{
    public static class ProjectExtension
    {
        public static Project ToEntity(this CreateProjectRequestJson request)
        {
            return new Project
            {
                Name = request.Name,
                Description = request.Description ?? string.Empty,
                StartDate = request.StartDate,
                EndDate = request.EndDate,
            };
        }
    }
}