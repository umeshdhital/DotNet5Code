using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;
using DotNet5Code.Model;
using Microsoft.EntityFrameworkCore;

namespace DotNet5Code.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        private DbSet<Contact> Contracts { get; set; }
    }
}
