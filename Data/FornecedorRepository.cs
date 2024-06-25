using Fornecedores.Api.Model;

namespace Fornecedores.Api.Data
{
    public class FornecedorRepository : IFornecedorRepository
    {
        private readonly FornecedorContext _contexto;

        public FornecedorRepository(FornecedorContext contexto)
        {
            _contexto = contexto;
        }
        public void Editar(Fornecedor fornecedor)
        {
            _contexto.Fornecedores.Update(fornecedor);
            _contexto.SaveChanges();
        }

        public void Excluir(Fornecedor fornecedor)
        {
            _contexto.Fornecedores.Remove(fornecedor);
            _contexto.SaveChanges();
        }

        public void Inserir(Fornecedor fornecedor)
        {
            _contexto.Fornecedores.Add(fornecedor);
            _contexto.SaveChanges();
        }

        public Fornecedor Obter(Guid id)
        {
            return _contexto.Fornecedores.Find(id);
        }

        public IEnumerable<Fornecedor> Obter()
        {
            return _contexto.Fornecedores.ToList();
        }
    }
}
