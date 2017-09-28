using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaDeConttroleDeCinema.Models
{
    public class Sessao
    {
        public int Sessaoid { get; set; }
        public DateTime DataHoraInicio { get; set; }
        public DateTime DataHoraFim { get; set; }
        public decimal ValorInteira { get; set; }
        public decimal ValorMeia{ get; set; }
        public Boolean Encerrada { get; set; }
        public List<Filme> Filme { get; set; }
        public List<Ingresso> Ingressos { get; set; }
        public Sala Sala { get; set; }
    }
}