using System;
using System.Collections.Generic;
using System.Linq;
using GestaoDeProjetos.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace GestaoDeProjetos.Api.Infra
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Entities.Task> Tasks { get; set; }
    }
}