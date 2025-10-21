using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoDeProjetos.Api.Requests;
using Microsoft.EntityFrameworkCore;

namespace GestaoDeProjetos.Api.Infra.Data.Repositories
{
    public class TaskRepository
    {
        private readonly AppDbContext _dbContext;

        public TaskRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create(Entities.Task task)
        {
            await _dbContext.Tasks.AddAsync(task);
        }

        public async Task<List<Entities.Task>> GetTaskByProjectId(TaskRouteFilterRequest request)
        {
            var query = _dbContext.Tasks.AsQueryable()
                .Where(t => t.ProjectId == request.ProjectId);

            if (request.Status.HasValue)
            {
                query = query.Where(x => x.Status == request.Status.Value);
            }
            if (request.Priority.HasValue)
            {
                query = query.Where(x => x.Priority == request.Priority.Value);
            }

            return await query.ToListAsync();
        }
    }
}