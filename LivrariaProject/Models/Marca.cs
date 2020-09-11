using System.Collections;
using System.Collections.Generic;

namespace LivrariaProject.Models
{
    public class Marca
    {
        public int Id { get; set; }
        public string NomeMarca { get; set; }
        public IList<Livro> Livros { get; set; }
    }
}