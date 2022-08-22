using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Presistence
{
    public class DataContext : DbContext
    {
        public DataContext( DbContextOptions options ) : base(options)
        {

        }

        public DbSet<Activity> Activities { get; set; } //DbSet inside of DbContext and its a table in our database
    }
}
