using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoDeProjetos.Api.Requests;
using GestaoDeProjetos.Api.UseCases.Project.Create;
using Microsoft.AspNetCore.Mvc;

namespace GestaoDeProjetos.Api.Controllers
{
    [ApiController]
    [Route("api/projects")]
    public class ProjectController : ControllerBase
    {
        [HttpGet]
        public void Get()
        {

        }

        [HttpPost]
        public IActionResult Create([FromServices] CreateProjectUseCase useCase, [FromBody] CreateProjectRequestJson request)
        {
            useCase.Execute(request);
            return Ok();
        }
    }
}