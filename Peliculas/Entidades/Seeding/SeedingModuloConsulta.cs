using Microsoft.EntityFrameworkCore;
using NetTopologySuite;
using NetTopologySuite.Geometries;
using Peliculas.Data;

namespace Peliculas.Entidades.Seeding
{
    internal class SeedingModuloConsulta
    {
        internal static void Seed(ModelBuilder modelBuilder)
        {
            var acción = new Genero { Id = 1, Nombre = "Acción" };
            var animación = new Genero { Id = 2, Nombre = "Animación" };
            var comedia = new Genero { Id = 3, Nombre = "Comedia" };
            var cienciaFicción = new Genero { Id = 4, Nombre = "Ciencia ficción" };
            var drama = new Genero { Id = 5, Nombre = "Drama" };

            modelBuilder.Entity<Genero>().HasData(acción, animación, comedia, cienciaFicción, drama);

            var pelicula1 = new Pelicula()
            {
                Id = 1,
                Director = "Colin Trevorrow",
                Titulo = "Jurassic World - Dominion",
                PaisOrigen = EnumPais.USA,
                PosterLink = "000001.png",
                FechaEstreno = new DateTime(2022, 06, 02),
                Resumen = "Tiempo después de los sucesos de Fallen Kingdom, los dinosaurios han vuelto a tomar el dominio en toda la tierra y los humanos tendrán que aprender a convivir con ellos mientras que un nuevo problema pondrá alta tensión a la situación. Owen Grady y Claire Dearing unirán fuerzas junto con la ayuda del famoso paleontólogo Alan Grant, la doctora Ellie Satler y el Doctor Ian Malcolm para resolverlo.",
                TrailerLink = "https://www.youtube.com/watch?v=9m9yRauMJIQ"
            };

            modelBuilder.Entity<Pelicula>().HasData(pelicula1);

            var salaDeCine1 = new SalaCine()
            {
                Id = 4,
                Nombre = "Sala 1",
                Tipo = EnumTipoSalaDeCine.TresDimensiones,
                CineId = 4
            };

            var salaDeCine2 = new SalaCine()
            {
                Id = 5,
                Nombre = "Sala 2",
                Tipo = EnumTipoSalaDeCine.DosDimensiones,
                CineId = 4
            };

            var salaDeCine3 = new SalaCine()
            {

                Id = 6,
                Nombre = "Sala 3",
                Tipo = EnumTipoSalaDeCine.DosDimensiones,
                CineId = 4,

            };

            modelBuilder.Entity<SalaCine>().HasData(salaDeCine1, salaDeCine2, salaDeCine3);

            var geometryFactory = NtsGeometryServices.Instance.CreateGeometryFactory(srid: 4326);

            var cine1 = new Cine()
            {
                Id = 1,
                Cadena = "ShowCase",
                Nombre = "Alto Rosario",
                Ubicacion = geometryFactory.CreatePoint(new Coordinate(-69.939248, 18.469649))
            };
                  
            var cine1CineOferta = new CineOferta { Id = 1, CineId = cine1.Id, FechaInicio = DateTime.Today, FechaFin = DateTime.Today.AddDays(7), PorcentajeDescuento = 10 };

            //modelBuilder.Entity<CineOferta>().HasData(cine1CineOferta);


            var cine2 = new Cine()
            {
                Id = 2,
                Cadena = "ShowCase",
                Nombre = "Alto Palermo",
                Ubicacion = geometryFactory.CreatePoint(new Coordinate(-69.9388777, 18.4839233))

            };

            var cine3 = new Cine()
            {
                Id = 3,
                Cadena = "ShowCase",
                Nombre = "Alto Cordoba",
                Ubicacion = geometryFactory.CreatePoint(new Coordinate(-69.911582, 18.482455))
            };

            var cine4 = new Cine()
            {
                Id = 4,
                Cadena = "ShowCase",
                Nombre = "Alto Avellaneda",
                Ubicacion = geometryFactory.CreatePoint(new Coordinate(-69.856309, 18.506662))
            };

            var cine5 = new Cine()
            {
                Id = 5,
                Cadena = "ShowCase",
                Nombre = "Mar Del Plata Mall",
                Ubicacion = geometryFactory.CreatePoint(new Coordinate(-59.939248, 18.469649))
            };


            modelBuilder.Entity<Cine>().HasData(cine1,cine2,cine3,cine4,cine5);


            var actor1 = new Actor()
            {
                Id = 1,
                Biografia = "Confiture la courus mers des récifs gonflé enfant des au que les couleurs les verts vacheries nuits heurté - seves",
                Nombre = "Matt Damon",
                Edad = 50,
                PaisOrigen = EnumPais.USA,
                FotoURL = ""
            };

            var actor2 = new Actor()
            {
                Id = 2,
                Biografia = "Mais rythmes vacheries j'ai quille je des les dispersant savez-vous a loin reculons de inouies pleins les que restais torpeurs",
                Nombre = "Olivia Mackenzie",
                Edad = 35,
                PaisOrigen = EnumPais.USA,
                FotoURL = ""
            };

            var actor3 = new Actor()
            {
                Id = 3,
                Biografia = "Peaux ni la vos ailé taché une j'ai mes les les et d'ineffables milieu vogueur de nuits embaumé nuits tout",
                Nombre = "Chris Pratt",
                Edad = 43,
                PaisOrigen = EnumPais.USA,
                FotoURL = ""
            };

            modelBuilder.Entity<Actor>().HasData(actor1,actor2,actor3);

            var peliculasActores1 = new PeliculaActor()
            {
                Id = 1,
                ActorId = 1,
                EsPrincipal = true,
                Orden = 1,
                PeliculaId = 1,
                Personaje = "Mosca",

            };
            var peliculasActores2 = new PeliculaActor()
            {
                Id = 2, 
                ActorId = 2,
                EsPrincipal = false,
                Orden = 2,
                PeliculaId = 1,
                Personaje = "Merlina",
            };

            var peliculasActores3 = new PeliculaActor()
            {
                Id = 3,
                ActorId = 3,
                EsPrincipal = false,
                Orden = 4,
                PeliculaId = 1,
                Personaje = "Merlina",
            };

            modelBuilder.Entity<PeliculaActor>().HasData(peliculasActores1, peliculasActores2, peliculasActores3);


            var comentario1 = new Comentario()
            {
                Id = 1,
                Contenido = "Me ha encantado la película de principio a fin. Mucho al aire libre y muchos dinosaurios locura de película, el guión muy bien hecho. La recomiendo 100%",
                Usuario = "Sergio Boscoscuro",
                MeGustaCantidad = 2
            };

            var comentario2 = new Comentario()
            {
                Id = 2,
                Contenido = "Me ha encantado, nunca había visto ninguna película de Jurassic y m ha dejado con sabor de querer verme todas las demás. nada aburrida y dinámica. la recomiendo.",
                Usuario = "Paula Rodríguez Correa",
                MeGustaCantidad = 0
            };

            var comentario3 = new Comentario()
            {
                Id = 3,
                Contenido = "Me fascinó!!!! Ayer en la sala hasta aplaudió el público cuando terminó la cinta, había jóvenes, adultos!!!! Los fans nos encantó, \"X\" los críticos, al final es una pelí para disfrutar entre la acción y la nostalgia, no es un documental de la vida en la tierra!!!!",
                Usuario = "Karina Hdez Mejia",
                MeGustaCantidad = 3
            };

            modelBuilder.Entity<Comentario>().HasData(comentario1,comentario2,comentario3);


            var critica1 = new Critica()
            {
                Id = -1,
                Autor = "Sandro Doreste Bermúdez",
                Contenido = "Aunque soy de agradecer los muchos guiños a Jurassic Park, la película no profundiza lo suficiente ni en los personajes ni en la trama ni, y esto podría haberla salvado entre su público objetivo, el nuevo tipo de dinosaurio introducido. Esperé casi toda la película, al menos mientras tuve esperanza, para ver cuál sería el giro que justificaría una producción así, como lograron hacer en Fallen Kingdom al sacar a los dinosaurios de la isla. Pero es que no lo hay. La historia promete sin llegar a dar nunca, pues la escena de acción de todo el elenco reunido es tensa, sí, pero con graves errores en los tiempos y, al igual que esta película para la saga Jurassic, omitible por falta de aportar a la trama general. Lo mejor: la primera y la última escena con las langostas y la persecución en Malta por la novedad del escenario."
            };

            var critica2 = new Critica()
            {
                Id = -2,
                Autor = "Ruth Estefany Gutierrez Santander",
                Contenido = "Soy super fan de la saga y esta ultima pelicula me hizo soltar algunas lagrimas es cierto q algunos detalles hubiera querido diferentes pero se guarda la esencia y para mi no pudo haber mejor final q este ame la pelicula y la animacion y el mensajed q transmite un buen final para la saga sus 5 estrellas merecidas."
            };

            //modelBuilder.Entity<Critica>().HasData(critica1,critica2);

            
        }
    }
}