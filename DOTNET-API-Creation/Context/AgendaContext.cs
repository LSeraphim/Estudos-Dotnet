using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Creation_API_With_DotNet.Entities;
using Microsoft.EntityFrameworkCore;

namespace Creation_API_With_DotNet.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {

        }

        public DbSet<Contato> Contatos{get; set;}
    }
}