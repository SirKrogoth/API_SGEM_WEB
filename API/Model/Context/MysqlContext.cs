using API.Model.Class;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Model.Context
{
    public class MysqlContext : DbContext
    {
        public MysqlContext()
        {

        }

        public MysqlContext(DbContextOptions<MysqlContext> options) : base(options)
        {

        }

        public DbSet<Item> Item { get; set; }
    }
}
