using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaProject.Data
{
    public class LivrariaProjectContext : DbContext
    {
        public LivrariaProjectContext(DbContextOptions<LivrariaProjectContext> options) 
            : base(options)
        {
        }


    }
}
