using projetoDDD.Application.Interfaces;
using ProjetoDDD.Domain.Entities;
using ProjetoDDD.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;

namespace projetoDDD.Application.Services
{
    public class AppFornecedorService : IAppFornecedorService
    {

        private IFornecedorService service;

        public AppFornecedorService(IFornecedorService service)
        {
            this.service = service;
        }


        public void AdicionaFornecedor(Fornecedor fornecedor)
        {
            this.service.AdicionaFornecedor(fornecedor);
        }

        public void AtualizaFornecedor(Fornecedor fornecedor)
        {
            throw new NotImplementedException();
        }

        public List<Fornecedor> ObtemTodos()
        {
            return this.service.ObtemTodos();
        }

        public Fornecedor ObterFornecedor(int id)
        {
            return service.ObterFornecedor(id);
        }

        public void RemoveFornecedor(int id)
        {
            throw new NotImplementedException();
        }
    }
}
