using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using Newtonsoft.Json;
using futuroDacidade.Models;
//using NUnit.Framework;

namespace futuroDacidade.Tests
{
    public class SensorTests
    {
        private readonly HttpClient _client;

        public SensorTests()
        {
            _client = new HttpClient();
            _client.BaseAddress = new System.Uri("http://localhost:5000"); // Altere para o endereço da sua API
        }

        [Fact]
        public async Task TestarCadastroDeSensor()
        {
            // Cenário positivo: Cadastro de sensor
            var sensor = new Sensor { Id = 1, Tipo = "Temperatura", Localizacao = "Praça Central" };
            var json = JsonConvert.SerializeObject(sensor);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

            var response = await _client.PostAsync("/api/sensores", content);

            response.EnsureSuccessStatusCode(); // Verifica se o status code é 200
        }

        [Fact]
        public async Task TestarCadastroDeSensor_Falha()
        {
            // Cenário negativo: Cadastro de sensor sem dados
            var sensor = new Sensor(); // Sensor inválido
            var json = JsonConvert.SerializeObject(sensor);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

            var response = await _client.PostAsync("/api/sensores", content);

            Assert.Equal(System.Net.HttpStatusCode.BadRequest, response.StatusCode); // Verifica se o status code é 400
        }
    }
}
