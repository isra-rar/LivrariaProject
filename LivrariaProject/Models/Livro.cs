using LivrariaProject.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaProject.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public Autor Autor { get; set; }

        [DisplayFormat(DataFormatString = "{0:F2}")]
        public decimal Preco { get; set; }

        public long ISBN { get; set; }
        public IdiomasEnum Idioma { get; set; }
        public int NumeroPaginas { get; set; }
        public int Edicao { get; set; }
        public DateTime AnoEdicao { get; set; }
        public Marca Marca{ get; set; }
    }
}
