using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoDeProjetos.Api.Entities;
using GestaoDeProjetos.Api.Requests;
using GestaoDeProjetos.Api.Responses;

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

        public static ResponseProjectJson ToResponse(this Project project)
        {
            return new ResponseProjectJson
            {
                Name = project.Name,
                Description = project.Description ?? string.Empty,
                StartDate = project.StartDate,
                EndDate = project.EndDate,
                Tasks = project.Tasks.Select(x => x.ToResponse()).ToList(),
            };
        }
    }
}