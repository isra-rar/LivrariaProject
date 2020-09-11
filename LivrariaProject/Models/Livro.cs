using LivrariaProject.Models.Enums;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace LivrariaProject.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public Autor Autor { get; set; }

        public decimal Preco { get; set; }

        public string ISBN { get; set; }
        public IdiomasEnum Idioma { get; set; }
        public int NumeroPaginas { get; set; }
        public int Edicao { get; set; }

        public string AnoEdicao { get; set; }

        public Marca Marca{ get; set; }
    }
}
