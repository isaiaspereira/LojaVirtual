using MinhaPrimeiraLojaVirtual.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaPrimeiraLoja.Repositorie.Context
{
    class LivrariaContext:DbContext
    {
        public LivrariaContext():base("LojaVirtualContext")
        {

        }

        public DbSet<Produto> produtos{ get; set; }
    }
}
