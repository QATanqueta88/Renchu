using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PARCIAL_1.Models;

namespace Parcial1.Data
{
    public class ActorContext : DbContext
    {
        public ActorContext (DbContextOptions<ActorContext> options)
            : base(options)
        {
        }

        public DbSet<PARCIAL_1.Models.Actor> Actor { get; set; } = default!;
    }
}
