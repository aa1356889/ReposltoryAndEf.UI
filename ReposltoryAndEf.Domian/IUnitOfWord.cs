using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReposltoryAndEf.Domian
{
   public interface IUnitOfWord:IDisposable
    {
        int SaveChanges();
    }
}
