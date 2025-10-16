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

        DbSet<Project> Projects { get; set; }
        DbSet<Entities.Task> Tasks { get; set; }
    }
}