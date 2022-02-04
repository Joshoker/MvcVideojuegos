using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcVideojuegos.Data;
using System;
using System.Linq;

namespace MvcVideojuegos.Models
{
    public static class SeedData
    {
        public static void Intialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcVideojuegosContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcVideojuegosContext>>()))
            {
                //Buscar por algun juego
                if (context.Videojuego.Any())
                {
                    return; // DB has been seeded
                }

                context.Videojuego.AddRange(
                   
                    new Videojuego
                    {
                        Titulo = "Grand Theft Auto V",
                        FechaDeLanzamiento = DateTime.Parse("2013-9-7"),
                        Genero = "Acción - Aventura",
                        Plataforma = "PlayStation, Xbox & PC",
                        Precio = 599
                    },
                    new Videojuego
                    {
                        Titulo = "Forza Horizon 5",
                        FechaDeLanzamiento = DateTime.Parse("2021-11-9"),
                        Genero = "Carreras",
                        Plataforma = "Xbox & PC",
                        Precio = 1498 
                    },
                    new Videojuego
                    {
                        Titulo = "Tom Clancy’s Rainbow six: Siege",
                        FechaDeLanzamiento = DateTime.Parse("2015-12-1"),
                        Genero = "Shooter",
                        Plataforma = "PlayStation,Xbox & PC",
                        Precio = 799
                    },
                    new Videojuego
                    {
                        Titulo = "Rocket League",
                        FechaDeLanzamiento = DateTime.Parse("2015-7-7"),
                        Genero = "Deportes",
                        Plataforma = "PlayStation,Xbox & PC",
                        Precio = 0
                    },
                    new Videojuego
                    {
                        Titulo = "Minecraft",
                        FechaDeLanzamiento = DateTime.Parse("2011-11-18"),
                        Genero = "Sandbox",
                        Plataforma = "PlayStation,Xbox & PC",
                        Precio = 349
                    }
                    );
                context.SaveChanges();

            }
        }
    }
}
