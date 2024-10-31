using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using Newtonsoft.Json;
using futuroDacidade.Models;
//using NUnit.Framework;

namespace futuroDacidade.Tests
{
    public class GestaoResiduosTests
    {
        private readonly HttpClient _client;

        public GestaoResiduosTests()
        {
            _client = new HttpClient();
            _client.BaseAddress = new System.Uri("http://localhost:5000"); // Altere para o endereço da sua API
        }

        [Fact]
        public async Task TestarCadastroDeResiduos()
        {
            // Cenário positivo: Cadastro de resíduos
            var residuos = new Residuos { Id = 1, Tipo = "Plástico", Localizacao = "Rua A" };
            var json = JsonConvert.SerializeObject(residuos);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

            var response = await _client.PostAsync("/api/residuos", content);

            response.EnsureSuccessStatusCode(); // Verifica se o status code é 200
        }

        [Fact]
        public async Task TestarCadastroDeResiduos_Falha()
        {
            // Cenário negativo: Cadastro de resíduos sem dados
            var residuos = new Residuos(); // Resíduo inválido
            var json = JsonConvert.SerializeObject(residuos);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

            var response = await _client.PostAsync("/api/residuos", content);

            Assert.Equal(System.Net.HttpStatusCode.BadRequest, response.StatusCode); // Verifica se o status code é 400
        }
    }
}
