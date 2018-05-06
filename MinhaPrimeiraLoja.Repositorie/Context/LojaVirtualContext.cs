using MinhaPrimeiraLojaVirtual.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Text;
using System.Threading.Tasks;
using MinhaPrimeiraLoja.Repositorie.Configuration;

namespace MinhaPrimeiraLoja.Repositorie.Context
{
    public class LojaVirtualContext : DbContext
    {
        public LojaVirtualContext() : base("LojaVirtualContext")
        {

        }

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Converção
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            //Configuration
            modelBuilder.Configurations.Add(new ProdutoConfiguration());
        }
    }
}
