using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace GestaoDeProjetos.Api.Infra.Data.Repositories
{
    public class ProjectRepository
    {
        private readonly AppDbContext _dbContext;

        public ProjectRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create(Entities.Project project)
        {
            await _dbContext.Projects.AddAsync(project);
        }

        public async Task<List<Entities.Project>> ListAll()
        {
            return await _dbContext.Projects
                .AsNoTracking()
                .ToListAsync();
        }
    }
}