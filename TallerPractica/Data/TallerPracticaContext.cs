using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TallerPractica.Models;

namespace TallerPractica.Data
{
    public class TallerPracticaContext : DbContext
    {
        public TallerPracticaContext (DbContextOptions<TallerPracticaContext> options)
            : base(options)
        {
        }

        public DbSet<TallerPractica.Models.Auto> Auto { get; set; } = default!;
        public DbSet<TallerPractica.Models.Motor> Motor { get; set; } = default!;
        public DbSet<TallerPractica.Models.Propietario> Propietario { get; set; } = default!;
    }
}
