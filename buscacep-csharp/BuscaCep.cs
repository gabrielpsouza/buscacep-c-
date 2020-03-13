using Refit;
using System;
using System.Threading.Tasks;

namespace buscacep_csharp
{
	class BuscaCep
    {
        static async Task Main(string[] args)
        {
			try
			{
				var cepClient = RestService.For<ICepService>("http://viacep.com.br/");
				Console.WriteLine("Informe o seu cep:");

				string cep = Console.ReadLine().ToString();
				Console.WriteLine("Consultando informacoes do cep: " + cep);

				var endereco = await cepClient.GetEnderecoAsync(cep);

				Console.WriteLine($"\nLogradouro:{endereco.Logradouro}\nComplemento:{endereco.Complemento}\nBairro:{endereco.Bairro}\nCidade:{endereco.Cidade}");
				Console.ReadKey();
			}
			catch (Exception ex)
			{
				Console.WriteLine("Erro ao consulta do cep: " + ex.Message);
			}
        }
    }
}
