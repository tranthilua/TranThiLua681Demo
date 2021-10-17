using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TranThiLua0681.Models;
namespace TranThiLua0681.Data{
  public class ApplicationContext : DbContext
    {
        public ApplicationContext (DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<TranThiLua0681.Models.PersonTTL0681> PersonTTL0681 { get; set; }

        public DbSet<TranThiLua0681.Models.TTL50681> TTL50681 { get; set; }
    }

}

    