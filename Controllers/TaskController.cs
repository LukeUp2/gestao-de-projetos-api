using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoDeProjetos.Api.Requests;
using GestaoDeProjetos.Api.UseCases.Tasks.Create;
using GestaoDeProjetos.Api.UseCases.Tasks.Delete;
using GestaoDeProjetos.Api.UseCases.Tasks.Get;
using GestaoDeProjetos.Api.UseCases.Tasks.UpdateStatus;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;

namespace GestaoDeProjetos.Api.Controllers
{
    [ApiController]
    [Route("api/tasks")]
    public class TaskController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] TaskRouteFilterRequest queryRequest, [FromServices] GetTaskByProjectIdUseCase useCase)
        {
            var result = await useCase.Execute(queryRequest);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateTaskRequestJson request, [FromServices] CreateTaskUseCase useCase)
        {
            await useCase.Execute(request);
            return Created(string.Empty, "Task criada com sucesso!");
        }

        [HttpPut("{taskId}/status")]
        public async Task<IActionResult> UpdateStatus([FromRoute] long taskId, [FromBody] UpdateTaskStatusRequest request, [FromServices] UpdateTaskStatusUseCase useCase)
        {
            var result = await useCase.Execute(request, taskId);
            return Ok(result);
        }

        [HttpDelete("{taskId}")]
        public async Task<IActionResult> Delete([FromRoute] long taskId, [FromServices] DeleteTaskUseCase useCase)
        {
            await useCase.Execute(taskId);
            return Ok();
        }
    }
}