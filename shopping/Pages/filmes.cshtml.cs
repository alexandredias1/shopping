using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace shopping.Pages
{
    public class FilmesModel : PageModel
    {
        public List<Filme> Filmes { get; set; } = new List<Filme>();

        public void OnGet()
        {
            Filmes = new List<Filme>
    {
        new Filme
        {
                Titulo = "DeadPool & Wolverine",
                Genero = "Ação/Comédia",
                Duracao = 127,
                Sessoes = "14:00, 18:00",
                ImagemUrl = "/imagens/deadpool_wolverine.jpg"
            },
            new Filme
            {
                Titulo = "Divertida Mente 2",
                Genero = "Infantil/Comédia",
                Duracao = 96,
                Sessoes = "16:00, 20:00",
                ImagemUrl = "/imagens/divertida_mente_2.jpeg"
            },
            new Filme
            {
                Titulo = "Meu Malvado Favorito 4",
                Genero = "Infantil/Comédia",
                Duracao = 94,
                Sessoes = "15:00, 19:00",
                ImagemUrl = "/imagens/meu_malvado_favorito_4.webp"
            },
            new Filme
            {
                Titulo = "O Corvo",
                Genero = "Ação/Fantasia",
                Duracao = 102,
                Sessoes = "17:00, 21:00",
                ImagemUrl = "/imagens/o_corvo.jpg"
            },
            new Filme
            {
                Titulo = "HellBoy e o Homem Torto",
                Genero = "Terror/Ação",
                Duracao = 115,
                Sessoes = "13:00, 17:00",
                ImagemUrl = "/imagens/hellboy_homem_torto.webp"
            },
            new Filme
            {
                Titulo = "Luccas e Gi em Dinossauros",
                Genero = "Infantil/Aventura",
                Duracao = 91,
                Sessoes = "13:00, 17:00",
                ImagemUrl = "/imagens/luccas_gi_dinossauros.jpg"
            },


        };
        }
    }
}
