using System.Collections.Generic;
using Fornecedores.Api.Model;
using Microsoft.EntityFrameworkCore;
namespace Fornecedores.Api.Data
{
    public class FornecedorContext : DbContext
    {
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public FornecedorContext(DbContextOptions options)
              : base(options)
        {

        }
    }

}
