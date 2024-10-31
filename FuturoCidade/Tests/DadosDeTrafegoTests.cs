using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using Newtonsoft.Json;
using futuroDacidade.Models;
//using NUnit.Framework;

namespace futuroDacidade.Tests
{
    public class DadosDeTrafegoTests
    {
        private readonly HttpClient _client;

        public DadosDeTrafegoTests()
        {
            _client = new HttpClient();
            _client.BaseAddress = new System.Uri("http://localhost:5000"); // Altere para o endereço da sua API
        }

        [Fact]
        public async Task TestarCadastroDeDadosDeTrafego()
        {
            // Cenário positivo: Cadastro de dados de tráfego
            var trafego = new Trafego { Id = 1, Localizacao = "Avenida B", Fluxo = 100 };
            var json = JsonConvert.SerializeObject(trafego);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

            var response = await _client.PostAsync("/api/trafego", content);

            response.EnsureSuccessStatusCode(); // Verifica se o status code é 200
        }

        [Fact]
        public async Task TestarCadastroDeDadosDeTrafego_Falha()
        {
            // Cenário negativo: Cadastro de dados de tráfego sem dados
            var trafego = new Trafego(); // Dado de tráfego inválido
            var json = JsonConvert.SerializeObject(trafego);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

            var response = await _client.PostAsync("/api/trafego", content);

            Assert.Equal(System.Net.HttpStatusCode.BadRequest, response.StatusCode); // Verifica se o status code é 400
        }
    }
}
