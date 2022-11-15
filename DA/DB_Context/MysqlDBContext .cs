using DA.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DA.DB_Context
{
    public partial class MysqlDBContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }

        public MysqlDBContext(DbContextOptions<MysqlDBContext> options) : base(options)
        {
        }

        
    }
}
