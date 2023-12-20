
using DotnetYuzuncuYil.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYil.Repository
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Team>
    }
}
