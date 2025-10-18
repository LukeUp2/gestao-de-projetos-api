using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoDeProjetos.Api.Requests;
using GestaoDeProjetos.Api.UseCases.Tasks.Create;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;

namespace GestaoDeProjetos.Api.Controllers
{
    [ApiController]
    [Route("api/tasks")]
    public class TaskController : ControllerBase
    {
        [HttpGet]
        public void Get()
        {

        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateTaskRequestJson request, [FromServices] CreateTaskUseCase useCase)
        {
            await useCase.Execute(request);
            return Ok("Task criada com sucesso!");
        }

        [HttpPut]
        public void UpdateStatus()
        {

        }

        [HttpDelete]
        public void Delete()
        {

        }
    }
}