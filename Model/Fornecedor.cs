namespace Fornecedores.Api.Model
{
    public class Fornecedor: Entity
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}
