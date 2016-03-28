using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CodeFirstSample.Models
{
    public class PeopleContext : DbContext
    {
        public DbSet<People> Peoples { get; set; }
    }
}