using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReposltoryAndEf.Domian
{
   public class ReposltoryAndEfContext:DbContext, IUnitOfWord
    {
        public ReposltoryAndEfContext() : base("sqlConnection") { }
        public DbSet<Sys_User> Sys_User { get; set; }
    }
}
