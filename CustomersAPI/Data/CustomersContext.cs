using CustomersAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomersAPI.Data
{
    public class CustomersContext: DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public CustomersContext(DbContextOptions<CustomersContext> options) : base(options)
        {
            
        }
    }
}
