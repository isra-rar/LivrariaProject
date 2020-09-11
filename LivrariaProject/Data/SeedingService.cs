using LivrariaProject.Models;
using LivrariaProject.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaProject.Data
{
    public class SeedingService
    {
        private LivrariaProjectContext _context;

        public SeedingService(LivrariaProjectContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Marca.Any() ||
                _context.Autor.Any() ||
                _context.Livro.Any())
            {
                return; //DB has been seeded
            }

            Marca m1 = new Marca { NomeMarca = "Editora Record"};
            Marca m2 = new Marca { NomeMarca = "Packt Publishing" };
            Marca m3 = new Marca { NomeMarca = "Editora Vozes" };
            Marca m4 = new Marca { NomeMarca = "Thomas Nelson Brasil" };
            Marca m5 = new Marca { NomeMarca = "Suma De Letras" };

            Autor a1 = new Autor { Nome = "Alice Munro", Pais = PaisEnum.CANADA, Genero = GeneroEnum.CONTO};
            Autor a2 = new Autor { Nome = "Augusto Cury", Pais = PaisEnum.BRAZIL, Genero = GeneroEnum.AUTOAJUDA};
            Autor a3 = new Autor { Nome = "C.S. Lewis", Pais = PaisEnum.REINO_UNIDO, Genero = GeneroEnum.FANTASIA};
            Autor a4 = new Autor { Nome = "George R.R.Martin", Pais = PaisEnum.EUA, Genero = GeneroEnum.FICCAO_CIENTIFICA};
            Autor a5 = new Autor { Nome = "Michael Freeman", Pais = PaisEnum.INGLATERRA, Genero = GeneroEnum.ARTES};
            Autor a6 = new Autor { Nome = "Sarah J. Maas", Pais = PaisEnum.EUA, Genero = GeneroEnum.ROMANCE};
            Autor a7 = new Autor { Nome = "Stephen King", Pais = PaisEnum.EUA, Genero = GeneroEnum.TERROR};
            Autor a8 = new Autor { Nome = "Marissa Meyer", Pais = PaisEnum.EUA, Genero = GeneroEnum.ROMANCE};

            Livro l1 = new Livro { Titulo = "Alice Através do Espelho", Autor = a1, Preco = 39.80M, ISBN = "9788551302347", Idioma = IdiomasEnum.PORTUGUES, NumeroPaginas = 144, Edicao = 1, AnoEdicao = "2017", Marca = m1};
            Livro l2 = new Livro { Titulo = "O Progresso do Amor", Autor = a1, Preco = 49.80M, ISBN = "9788525060235", Idioma = IdiomasEnum.PORTUGUES, NumeroPaginas = 384, Edicao = 1, AnoEdicao = "2017", Marca = m2};
            Livro l3 = new Livro { Titulo = "O Homem Mais Inteligente da História", Autor = a2, Preco = 39.80M, ISBN = "9788543104355", Idioma = IdiomasEnum.PORTUGUES, NumeroPaginas = 272, Edicao = 1, AnoEdicao = "2016", Marca = m3};
            Livro l4 = new Livro { Titulo = "O Homem Mais Feliz da História", Autor = a2, Preco = 35.50M, ISBN = "9788543105277", Idioma = IdiomasEnum.PORTUGUES, NumeroPaginas = 336, Edicao = 1, AnoEdicao = "2017", Marca = m1};
            Livro l5 = new Livro { Titulo = "Gestão da Emoção", Autor = a2, Preco = 21.40M, ISBN = "9788582402603", Idioma = IdiomasEnum.PORTUGUES, NumeroPaginas = 200, Edicao = 1, AnoEdicao = "2015", Marca = m5};
            Livro l6 = new Livro { Titulo = "Soluções Pacíficas De Conflitos", Autor = a2, Preco = 50.80M, ISBN = "9788530982089", Idioma = IdiomasEnum.PORTUGUES, NumeroPaginas = 145, Edicao = 1, AnoEdicao = "2015", Marca = m3};
            Livro l7 = new Livro { Titulo = "Cartas A Malcolm", Autor = a3, Preco = 34.90M, ISBN = "9788571670136", Idioma = IdiomasEnum.PORTUGUES, NumeroPaginas = 176, Edicao = 1, AnoEdicao = "2019", Marca = m4};
            Livro l8 = new Livro { Titulo = "O Assunto Do Céu", Autor = a3, Preco = 54.90M, ISBN = "9788571670648", Idioma = IdiomasEnum.PORTUGUES, NumeroPaginas = 432, Edicao = 1, AnoEdicao = "2019", Marca = m4};
            Livro l9 = new Livro { Titulo = "Os Quatro Amores", Autor = a3, Preco = 34.90M, ISBN = "9788578601959", Idioma = IdiomasEnum.PORTUGUES, NumeroPaginas = 192, Edicao = 1, AnoEdicao = "2017", Marca = m4};
            Livro l10 = new Livro { Titulo = "A Última Noite do Mundo", Autor = a3, Preco = 34.90M, ISBN = "9788578607593", Idioma = IdiomasEnum.PORTUGUES, NumeroPaginas = 144, Edicao = 1, AnoEdicao = "2018", Marca = m4};
            Livro l11 = new Livro { Titulo = "Reflexões Cristãs", Autor = a3, Preco = 49.90M, ISBN = "9788571670365", Idioma = IdiomasEnum.PORTUGUES, NumeroPaginas = 288, Edicao = 1, AnoEdicao = "2019", Marca = m4};
            Livro l12 = new Livro { Titulo = "Um Experimento Em Crítica Literária", Autor = a3, Preco = 39.90M, ISBN = "9788571670433", Idioma = IdiomasEnum.PORTUGUES, NumeroPaginas = 160, Edicao = 1, AnoEdicao = "2019", Marca = m4};
            Livro l13 = new Livro { Titulo = "Sobre Histórias", Autor = a3, Preco = 39.90M, ISBN = "9788578606572", Idioma = IdiomasEnum.PORTUGUES, NumeroPaginas = 256, Edicao = 1, AnoEdicao = "2018", Marca = m4};
            Livro l14 = new Livro { Titulo = "O Festim Dos Corvos - As Crônicas de Gelo e Fogo - Livro Quatro - Edição Comemorativa", Autor = a4, Preco = 79.90M, ISBN = "9788544102954", Idioma = IdiomasEnum.PORTUGUES, NumeroPaginas = 608, Edicao = 1, AnoEdicao = "2015", Marca = m5};
            Livro l15 = new Livro { Titulo = "A Dança Dos Dragões - As Crônicas de Gelo e Fogo - Livro Cinco - Edição Comemorativa", Autor = a4, Preco = 79.90M, ISBN = "9788544102961", Idioma = IdiomasEnum.PORTUGUES, NumeroPaginas = 832, Edicao = 1, AnoEdicao = "2015", Marca = m5};
            Livro l16 = new Livro { Titulo = "A Fúria Dos Reis - As Crônicas De Gelo E Fogo, Volume 2", Autor = a4, Preco = 79.90M, ISBN = "9788556510792", Idioma = IdiomasEnum.PORTUGUES, NumeroPaginas = 648, Edicao = 1, AnoEdicao = "2019", Marca = m5};
            Livro l17 = new Livro { Titulo = "A Tormenta De Espadas - As Crônicas De Gelo E Fogo, Volume 3", Autor = a4, Preco = 89.90M, ISBN = "9788556510808", Idioma = IdiomasEnum.PORTUGUES, NumeroPaginas = 832, Edicao = 1, AnoEdicao = "2019", Marca = m5};
            Livro l18 = new Livro { Titulo = "O Festim Dos Corvos - As Crônicas De Gelo E Fogo, Volume 4", Autor = a4, Preco = 79.90M, ISBN = "9788556510884", Idioma = IdiomasEnum.PORTUGUES, NumeroPaginas = 608, Edicao = 1, AnoEdicao = "2019", Marca = m5};
            Livro l19 = new Livro { Titulo = "Wild Cards: O Começo", Autor = a4, Preco = 69.90M, ISBN = "9788556510860", Idioma = IdiomasEnum.PORTUGUES, NumeroPaginas = 480, Edicao = 1, AnoEdicao = "2019", Marca = m5};
            Livro l20 = new Livro { Titulo = "O Olho do Fotógrafo: Guia Gráfico", Autor = a5, Preco = 39.90M, ISBN = "9788582603260", Idioma = IdiomasEnum.PORTUGUES, NumeroPaginas = 192, Edicao = 1, AnoEdicao = "2015", Marca = m1};
            Livro l21 = new Livro { Titulo = "Fotografia de Viagem - Guia de Campo", Autor = a5, Preco = 40.90M, ISBN = "9788582603269", Idioma = IdiomasEnum.PORTUGUES, NumeroPaginas = 204, Edicao = 1, AnoEdicao = "2012", Marca = m1};
            Livro l22 = new Livro { Titulo = "O Olhar do Fotógrafo - 2ª Ed. 2012", Autor = a5, Preco = 50.80M, ISBN = "9789725766101", Idioma = IdiomasEnum.PORTUGUES, NumeroPaginas = 192, Edicao = 1, AnoEdicao = "2012", Marca = m1};
            Livro l23 = new Livro { Titulo = "Mulher-Gato - Ladra De Almas", Autor = a6, Preco = 49.90M, ISBN = "9788580419719", Idioma = IdiomasEnum.PORTUGUES, NumeroPaginas = 230, Edicao = 1, AnoEdicao = "2017", Marca = m2};
            Livro l24 = new Livro { Titulo = "Coroa da Meia-Noite - Trono de Vidro - Vol. 2", Autor = a6, Preco = 49.90M, ISBN = "9788501401397", Idioma = IdiomasEnum.PORTUGUES, NumeroPaginas = 406, Edicao = 13, AnoEdicao = "2014", Marca = m2};
            Livro l25 = new Livro { Titulo = "Keleana- Tome 2 - La Reine Sans Couronne", Autor = a6, Preco = 79.90M, ISBN = "9782013938020", Idioma = IdiomasEnum.FRANCES, NumeroPaginas = 512, Edicao = 1, AnoEdicao = "2016", Marca = m2};
            Livro l26 = new Livro { Titulo = "Keleana- Tome 1 - La Prisonnière", Autor = a6, Preco = 59.90M, ISBN = "9782013193092", Idioma = IdiomasEnum.FRANCES, NumeroPaginas = 512, Edicao = 1, AnoEdicao = "2016", Marca = m2};
            Livro l27 = new Livro { Titulo = "It - A Coisa", Autor = a7, Preco = 92.90M, ISBN = "9788560280940", Idioma = IdiomasEnum.PORTUGUES, NumeroPaginas = 1104, Edicao = 1, AnoEdicao = "2014", Marca = m5};
            Livro l28 = new Livro { Titulo = "A Torre Negra - Col. A Torre Negra Vol. VII", Autor = a7, Preco = 82.90M, ISBN = "9788581050270", Idioma = IdiomasEnum.PORTUGUES, NumeroPaginas = 872, Edicao = 1, AnoEdicao = "2012", Marca = m5};
            Livro l29 = new Livro { Titulo = "Necrópolis - O Poder Dos Cinco - Vol. 4", Autor = a7, Preco = 79.90M, ISBN = "9788501088352", Idioma = IdiomasEnum.PORTUGUES, NumeroPaginas = 384, Edicao = 1, AnoEdicao = "2011", Marca = m5};
            Livro l30 = new Livro { Titulo = "Levana - A Rainha Mais Bela - Crônicas Lunares", Autor = a8, Preco = 34.50M, ISBN = "9788579803468", Idioma = IdiomasEnum.PORTUGUES, NumeroPaginas = 256, Edicao = 1, AnoEdicao = "2017", Marca = m2};
            Livro l31 = new Livro { Titulo = "Heartless", Autor = a8, Preco = 44.50M, ISBN = "9781250114860", Idioma = IdiomasEnum.PORTUGUES, NumeroPaginas = 464, Edicao = 1, AnoEdicao = "2016", Marca = m2};
            Livro l32 = new Livro { Titulo = "Supernova", Autor = a8, Preco = 50.50M, ISBN = "1250078385", Idioma = IdiomasEnum.PORTUGUES, NumeroPaginas = 560, Edicao = 1, AnoEdicao = "2019", Marca = m2};

            _context.Marca.AddRange(m1,m2,m3,m4,m5);

            _context.Autor.AddRange(a1,a2,a3,a4,a6,a7,a8);

            _context.Livro.AddRange(l1,l2,l3,l4,l5,l6,l7,
                l8,l9,l10,l11,l12,l13,l14,l15,
                l16,l17,l18, l19,l20,l21,l22,l23,l24,
                l25,l26,l27,l28,l29,l30,l31,l32);

            _context.SaveChanges();
            }
    }
}
