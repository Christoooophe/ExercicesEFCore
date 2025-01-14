using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ExercicesEFCore.Models;

namespace ExercicesEFCore.Data
{
    public class ExercicesEFCoreContext : DbContext
    {
        public ExercicesEFCoreContext (DbContextOptions<ExercicesEFCoreContext> options)
            : base(options)
        {
        }

        public DbSet<ExercicesEFCore.Models.ToDo> ToDo { get; set; } = default!;
    }
}
