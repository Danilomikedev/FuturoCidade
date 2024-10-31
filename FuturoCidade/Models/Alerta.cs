// Models/Alerta.cs
using System;

namespace futuroDacidade.Models
{
    public class Alerta
    {
        public int Id { get; set; }
        public string Mensagem { get; set; }
        public DateTime Data { get; set; }
    }
}
