using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoDeProjetos.Api.Requests;
using GestaoDeProjetos.Api.UseCases.Project.Create;
using GestaoDeProjetos.Api.UseCases.Project.ListAll;
using Microsoft.AspNetCore.Mvc;

namespace GestaoDeProjetos.Api.Controllers
{
    [ApiController]
    [Route("api/projects")]
    public class ProjectController : ControllerBase
    {
        [HttpGet]
        //TODO - Paginação
        public async Task<IActionResult> GetAll([FromServices] ListAllProjectsUseCase useCase, [FromQuery] PaginationQueryRequest query)
        {
            var result = await useCase.Execute(query);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromServices] CreateProjectUseCase useCase, [FromBody] CreateProjectRequestJson request)
        {
            await useCase.Execute(request);
            return Created(string.Empty, "Projeto criado com sucesso :)");
        }
    }
}