
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AoD.Models
{
    public class AoDContext : DbContext
    {
        public AoDContext(DbContextOptions<AoDContext> options)
            : base(options)
        {
        }
    }
}