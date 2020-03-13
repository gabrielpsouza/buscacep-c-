using Refit;
using System.Threading.Tasks;

namespace buscacep_csharp
{
    public interface ICepService
    {
        [Get("/ws/{cep}/json")]
        Task<CepRetorno> GetEnderecoAsync(string cep);
    }
}
