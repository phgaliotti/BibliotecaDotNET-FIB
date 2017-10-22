using BibliotecaMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaMVC.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
			// verifica se o banco de dados esta criado, se não estiver cria automaticamente
            context.Database.EnsureCreated();

            // Se existir algum livro
            if (context.Livro.Any())
            {
                return;   // DB possui registros
            }

            var livros = new Livro[]
            {
                new Livro {Titulo = "As Aventuras de Tim-Tim", Quantidade = 10},
                new Livro {Titulo = "The bozo",Quantidade = 10},
                new Livro {Titulo = "Jogador numero 1",Quantidade = 10},
            };

            foreach (Livro l in livros)
            {
                context.Livro.Add(l);
            }

            var autores = new Autor[]
            {
                new Autor { Nome = "Tim-Tim" },
                new Autor { Nome = "Bozo"},
                new Autor { Nome = "John Travolta"}
            };

    foreach (Autor a in autores)
    {
        context.Autor.Add(a);
    }

    var usuarios = new Usuario[]
    {
        new Usuario { Nome = "Teste", Email = "teste@teste.com", Senha = "abc123" }
		new Usuario { Nome = "Phelipe", Email = "ph@p.com", Senha = "abc123" }
    };

    foreach (Usuario a in usuarios)
    {
        context.Usuario.Add(a);
    }

    context.SaveChanges();
}
    }
}
