using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore; 
using API.Entities;


namespace API.Data
{
    public class DataEntities : DbContext
    {
        public DataEntities (DbContextOptions options) : base (options)
        {
        }

        public DbSet <Product> Products { get; set; }
    }
}