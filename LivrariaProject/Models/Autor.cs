using LivrariaProject.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaProject.Models
{
    public class Autor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public PaisEnum Pais { get; set; }
        public IList<GeneroEnum> Generos { get; set; } = new List<GeneroEnum>();
        public IList<Livro> Livros { get; set; } = new List<Livro>();
    }
}
