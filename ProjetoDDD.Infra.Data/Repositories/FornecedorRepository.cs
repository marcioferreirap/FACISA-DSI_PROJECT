using ProjetoDDD.Domain.Entities;
using ProjetoDDD.Domain.Interfaces.Repository;
using ProjetoDDD.Infra.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoDDD.Infra.Data.Repositories
{
    public class FornecedorRepository : IFornecedorRepository
    {
        private BancoDeDados bd = new BancoDeDados();

        public void AdicionaFornecedor(Fornecedor fornecedor)
        {
            bd.Fornecedores.Add(fornecedor);
            bd.SaveChanges();
        }

        public void AtualizaFornecedor(Fornecedor fornecedor)
        {
            throw new NotImplementedException();
        }


        public List<Fornecedor> ObtemTodos()
        {
            return bd.Fornecedores.ToList();
        }

        public Fornecedor ObterFornecedor(int id)
        {
            return bd.Fornecedores.Find(id);
        }

        public void RemoveFornecedor(int id)
        {
            throw new NotImplementedException();
        }
    }
}
