using MinhaPrimeiraLojaVirtual.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaPrimeiraLoja.Repositorie.Configuration
{
    public class ProdutoConfiguration : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfiguration()
        {
            HasKey(k => k.ProdutoId);

            Property(p => p.Nome)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            Property(p => p.Descricao)
                .HasColumnType("varchar")
                .HasMaxLength(500)
                .IsRequired();

            Property(p => p.Preco)
                .HasPrecision(16, 2);
        }
    }
}
