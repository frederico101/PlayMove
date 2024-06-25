using Fornecedores.Api.Model;

namespace Fornecedores.Api.Data
{
    public interface IFornecedorRepository
    {
        void Inserir(Fornecedor fornecedor);
        void Editar(Fornecedor fornecedor);
        void Excluir(Fornecedor fornecedor);
        Fornecedor Obter(Guid id);
        IEnumerable<Fornecedor> Obter();
    }
}
