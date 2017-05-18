using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace testmvc5.Models
{
    public class SearchDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<SearchRequest> SearchRequests { get; set; }
    }
}