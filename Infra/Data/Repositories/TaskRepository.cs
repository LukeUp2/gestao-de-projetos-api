using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDeProjetos.Api.Infra.Data.Repositories
{
    public class TaskRepository
    {
        private readonly AppDbContext _dbContext;

        public TaskRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}