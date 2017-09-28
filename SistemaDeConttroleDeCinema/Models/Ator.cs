using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaDeConttroleDeCinema.Models
{
    public class Ator
    {
        public int AtorId{ get; set; }
        public string Nome { get; set; }
        public List<Filme> Filmes{ get; set; }
    }
}