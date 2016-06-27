using ProjetoDDD.Domain.Entities;
using System.Data.Entity;

namespace ProjetoDDD.Infra.Data.Entity
{
    public class BancoDeDados : DbContext
    {

        public BancoDeDados() : base("ProjetoDDD_DataBase")
        {
                
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }

    }
}
