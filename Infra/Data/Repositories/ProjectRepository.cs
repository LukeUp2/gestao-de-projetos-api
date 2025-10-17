using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDeProjetos.Api.Infra.Data.Repositories
{
    public class ProjectRepository
    {
        private readonly AppDbContext _dbContext;

        public ProjectRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}