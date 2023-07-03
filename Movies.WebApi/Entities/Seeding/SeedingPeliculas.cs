using Microsoft.EntityFrameworkCore;
using NetTopologySuite;
using NetTopologySuite.Geometries;
using Movies.Data;
using Movies.Web.Enums;
using Movies.WebApi.Entities;

namespace Movies.WebApi.Entities.Seeding
{
    internal class SeedingPeliculas
    {
        internal static void Seed(ModelBuilder modelBuilder)
        {
            var genero1 = new Gender { Id = 6, Name = "Animación" };
            var genero2 = new Gender { Id = 7, Name = "Terror" };
            var genero3 = new Gender { Id = 8, Name = "Documental" };



            modelBuilder.Entity<Gender>().HasData(genero1, genero2, genero3);

            var pelicula1 = new Movie()
            {
                Id = 1,
                Director = "Colin Trevorrow",
                Title = "Jurassic World - Dominion",
                OriginCountry = (int)EnumCountry.USA,
                PosterLink = "000001.png",
                ReleaseDate = 2022,
                Summary = "Tiempo después de los sucesos de Fallen Kingdom, los dinosaurios han vuelto a tomar el dominio en toda la tierra y los humanos tendrán que aprender a convivir con ellos mientras que un nuevo problema pondrá alta tensión a la situación. Owen Grady y Claire Dearing unirán fuerzas junto con la ayuda del famoso paleontólogo Alan Grant, la doctora Ellie Satler y el Doctor Ian Malcolm para resolverlo.",
                TrailerLink = "https://www.youtube.com/watch?v=9m9yRauMJIQ"
            };

            var pelicula2 = new Movie()
            {
                Id = 2,
                Director = "Mike Newell",
                Title = "Harry Potter y el cáliz de fuego",
                OriginCountry = (int)EnumCountry.USA,
                PosterLink = "000002.png",
                TrailerLink = "https://www.youtube.com/watch?v=h1Xm9ynJKDM",
                ReleaseDate = 2005,
                Summary = "Hogwarts se prepara para el Torneo de los Tres Magos, en el que competirán tres escuelas de hechicería. Para sorpresa de todos, Harry Potter es elegido para participar en la competencia, en la que deberá luchar contra dragones, internarse en el agua y enfrentarse a sus mayores miedos."
            };

            var pelicula3 = new Movie()
            {
                Id = 3,
                Director = "Mike Newell",
                Title = "Harry Potter sorcerer's stone",
                OriginCountry = (int)EnumCountry.USA,
                PosterLink = "000002.png",
                ReleaseDate = 2005,
                TrailerLink = "https://www.youtube.com/watch?v=WE4AJuIvG1Y",
                Summary = "Hogwarts se prepara para el Torneo de los Tres Magos, en el que competirán tres escuelas de hechicería. Para sorpresa de todos, Harry Potter es elegido para participar en la competencia, en la que deberá luchar contra dragones, internarse en el agua y enfrentarse a sus mayores miedos."
            };

            var pelicula4 = new Movie()
            {
                Id = 4,
                Director = "Tim Story",
                Title = "Los 4 fantásticos",
                OriginCountry = (int)EnumCountry.USA,
                PosterLink = "000003.png",
                TrailerLink = "https://www.youtube.com/watch?v=BhK0xqwIDqk",
                ReleaseDate = 2005,
                Summary = "Reed Richards. El piloto Ben Grimm y los miembros de la tripulación Susan Storm y su hermano Johnny Storm sobreviven a un aterrizaje de emergencia en un campo en la Tierra. Al salir del cohete, los cuatro descubren que han desarrollado superpoderes increíbles, y deciden usar estos poderes para ayudar a otros."
            };

            var pelicula5 = new Movie()
            {
                Id = 5,
                Director = "Eric Darnell",
                Title = "Madagascar",
                OriginCountry = (int)EnumCountry.USA,
                PosterLink = "000004.png",
                TrailerLink = "https://youtu.be/3X3NkVbcw58",
                ReleaseDate = 2005,
                Summary = "Cuatro animales muy mimados del zoo de Nueva York naufragan en la isla de Madagascar y deben aprender a sobrevivir en un mundo salvaje."
            };

            var pelicula6 = new Movie()
            {
                Id = 6,
                Director = "Andrew Adamson, Vicky Jenson",
                Title = "Shrek",
                OriginCountry = (int)EnumCountry.USA,
                PosterLink = "000005.png",
                ReleaseDate = 2001,
                TrailerLink = "https://www.youtube.com/watch?v=B88JfTyJ1Fw",
                Summary = "Hace mucho tiempo, en una lejana ciénaga, vivía un ogro llamado Shrek. Un día, su preciada soledad se ve interrumpida por un montón de personajes de cuento de hadas que invaden su casa. Todos fueron desterrados de su reino por el malvado Lord Farquaad. Decidido a devolverles su reino y recuperar la soledad de su ciénaga, Shrek llega a un acuerdo con Lord Farquaad y va a rescatar a la princesa Fiona, la futura esposa del rey. Sin embargo, la princesa esconde un oscuro secreto."
            };

            var pelicula7 = new Movie()
            {
                Id = 7,
                Director = "Michael Apted",
                Title = "Las crónicas de Narnia: la travesía del Viajero del Alba",
                OriginCountry = (int)EnumCountry.USA,
                PosterLink = "000006.png",
                ReleaseDate = 2010,
                TrailerLink = "https://www.youtube.com/watch?v=o81F2hvmYJQ",
                Summary = "Edmundo y Lucía junto con su primo Eustaquio emprenderán una nueva aventura con Caspian para explorar los desconocidos mares de Narnia. Recorriendo muchas islas que no aparecen en los mapas y enfrentando grandes peligros llegaran al fin del mundo para conocer el resto de su historia."
            };

            var pelicula8 = new Movie()
            {
                Id = 8,
                Director = "Shane Van Dyke",
                Title = "Titanic II",
                OriginCountry = (int)EnumCountry.USA,
                PosterLink = "000002.png",
                ReleaseDate = 2010,
                TrailerLink = "https://www.youtube.com/watch?v=bKn-NdqSkU4",
                Summary = "Amy Maine ha sido contratada para trabajar en el Titanic 2, el trasatlántico más moderno y sofisticado de todos los tiempos, que inicia un viaje inaugural por el oceáno Atlántico. Cuando el padre de Amy, un geólogo, detecta el derrumbe de un glacial en Groenlandia, prevee que las consecuencias de este desastre natural serán fatales para el Titanic 2. El fragmento de hielo desprendido tiene el tamaño de Manhattan y se sitúa en el trayecto del buque."
            };

            var pelicula9 = new Movie()
            {
                Id = 9,
                Director = "Todd Phillips",
                Title = "Guasón",
                OriginCountry = (int)EnumCountry.USA,
                PosterLink = "000008.png",
                ReleaseDate = 2019,
                TrailerLink = "https://www.youtube.com/watch?v=TobNCFMK_bs",
                Summary = "Arthur Fleck adora hacer reír a la gente, pero su carrera como comediante es un fracaso. El repudio social, la marginación y una serie de trágicos acontecimientos lo conducen por el sendero de la locura y, finalmente, cae en el mundo del crimen."
            };


            modelBuilder.Entity<Movie>().HasData(pelicula1, pelicula2, pelicula3, pelicula4, pelicula5, pelicula6, pelicula7, pelicula8, pelicula9);

            var geometryFactory = NtsGeometryServices.Instance.CreateGeometryFactory(srid: 4326);

            var cine1 = new Cinema()
            {
                Id = 6,
                Chain = "ShowCase",
                Name = "Alto Rosario",
                Location = geometryFactory.CreatePoint(new Coordinate(-69.939248, 18.469649))
            };

            var cine2 = new Cinema()
            {
                Id = 7,
                Chain = "ShowCase",
                Name = "Alto Palermo",
                Location = geometryFactory.CreatePoint(new Coordinate(-69.9388777, 18.4839233))

            };

            var cine3 = new Cinema()
            {
                Id = 8,
                Chain = "ShowCase",
                Name = "Alto Cordoba",
                Location = geometryFactory.CreatePoint(new Coordinate(-69.911582, 18.482455))
            };

            var cine4 = new Cinema()
            {
                Id = 9,
                Chain = "ShowCase",
                Name = "Alto Avellaneda",
                Location = geometryFactory.CreatePoint(new Coordinate(-69.856309, 18.506662))
            };

            var cine5 = new Cinema()
            {
                Id = 10,
                Chain = "ShowCase",
                Name = "Mar Del Plata Mall",
                Location = geometryFactory.CreatePoint(new Coordinate(-59.939248, 18.469649))
            };


            modelBuilder.Entity<Cinema>().HasData(cine1, cine2, cine3, cine4, cine5);

            var cine1CineOferta = new CinemaOffer { Id = 10, CinemaId = cine1.Id, StartDate = DateTime.Today.AddDays(5), EndDate = DateTime.Today.AddDays(7), Discount = 8 };
            var cine2CineOferta = new CinemaOffer { Id = 11, CinemaId = cine2.Id, StartDate = DateTime.Today.AddDays(5), EndDate = DateTime.Today.AddDays(7), Discount = 10 };
            var cine3CineOferta = new CinemaOffer { Id = 12, CinemaId = cine3.Id, StartDate = DateTime.Today.AddDays(5), EndDate = DateTime.Today.AddDays(7), Discount = 12 };
            var cine4CineOferta = new CinemaOffer { Id = 13, CinemaId = cine4.Id, StartDate = DateTime.Today.AddDays(5), EndDate = DateTime.Today.AddDays(7), Discount = 15 };
            var cine5CineOferta = new CinemaOffer { Id = 14, CinemaId = cine5.Id, StartDate = DateTime.Today.AddDays(5), EndDate = DateTime.Today.AddDays(7), Discount = 20 };

            modelBuilder.Entity<CinemaOffer>().HasData(cine1CineOferta,
                                                      cine2CineOferta,
                                                      cine3CineOferta,
                                                      cine4CineOferta,
                                                      cine5CineOferta);


            var salaDeCine1 = new RoomCinema()
            {
                Id = 1,
                Name = "Sala 1",
                Type = (int)EnumRoomCinemaTypes.THREEDIMENSIONS,
                CineId = 4
            };

            var salaDeCine2 = new RoomCinema()
            {
                Id = 2,
                Name = "Sala 2",
                Type = (int)EnumRoomCinemaTypes.TWODIMENSIONS,
                CineId = 4
            };

            var salaDeCine3 = new RoomCinema()
            {
                Id = 3,
                Name = "Sala 3",
                Type = (int)EnumRoomCinemaTypes.TWODIMENSIONS,
                CineId = 4,

            };

            modelBuilder.Entity<RoomCinema>().HasData(salaDeCine1, salaDeCine2, salaDeCine3);

            //#region  PeliculasActores

            //var peliculasActores1 = new PeliculaActor()
            //{
            //    Id = 1,
            //    EsPrincipal = true,
            //    Orden = 1,
            //    PeliculaId = 1,
            //    ActorId = 1,
            //    Personaje = "Mosca",

            //};
            //var peliculasActores2 = new PeliculaActor()
            //{
            //    Id = 2,
            //    EsPrincipal = false,
            //    Orden = 2,
            //    ActorId = 2,
            //    PeliculaId = 1,
            //    Personaje = "Merlina",
            //};

            //var peliculasActores3 = new PeliculaActor()
            //{
            //    Id = 3,
            //    EsPrincipal = false,
            //    Orden = 4,
            //    PeliculaId = 2,
            //    ActorId = 3,
            //    Personaje = "Marta",
            //};

            //var peliculasActores4 = new PeliculaActor()
            //{
            //    Id = 4,
            //    EsPrincipal = false,
            //    Orden = 4,
            //    PeliculaId = 2,
            //    ActorId = 4,
            //    Personaje = "Marta",
            //};

            //modelBuilder.Entity<PeliculaActor>().HasData(peliculasActores1, 
            //                                             peliculasActores2, 
            //                                             peliculasActores3,
            //                                             peliculasActores4);

            //#endregion


            //#region Actores
            //var actor1 = new Actor()
            //{
            //    Id = 1,
            //    Nombre = "Leo",
            //    Edad = 50,
            //    PaisOrigen = EnumPais.ARG,
            //    FotoURL = "",
            //    Biografia = "La la malheligxis mi kaj tage sovagxuloj havigi de ke mauxro kiu pafilo mangxos plu ricevos nin havigi parolado terbordon mi vidis post el li gastoj enmaron se ia estis cxu bieno baldaux por fojon pensis veloj la li kiam turkoj forkuru maro posedajxojn da povis gxin ni gxi sxancon ke tiel tial plie vino gxi por tiun-cxi eksentis enmaro alia dufoje kiu mi mi enmaron iom trovis se kajuton ili vidi nur tie-cxi kaj da juste sia al bezonas homoj homojn de da atendis mi posedajxoj diris nelonge antaux velveturis li aux mi povas vendi kiom sovagxaj farigxos nomo fisxoj gxi duonmejlon la farus estas intencas akvo kaj la reen sin li atendu sed mi tion dufoje tiam vi vidajxo bonsxance kiam la la demetis lin por por ricevos ke monujo kvin fisxkapti gxin kiel tie-cxi la vidante bona plenigi boaton de ke la antauxvidis vin mi aux --",
            //    PeliculaActorId = 4,
            //};

            //var actor2 = new Actor
            //{
            //    Id = 2,
            //    Nombre = "Rose",
            //    Edad = 50,
            //    PaisOrigen = EnumPais.USA,
            //    FotoURL = "",
            //    Biografia = "In condemned condole sad albions saw now from and all caught cheer native none this mine dwell him with to fly tales thy to so wins break within that soul the on haply lyres in say talethis through drop strange agen to if and and is objects condemned did harold heartless apart childe lines climes he change he sorrow long begun a of delight nor dear plain third far fellow hellas objects though where control heartless for could flee ee though ere only and her full feud so aught along to holy not was sought of into revellers he muse will strength festal he seraphs but each one his passion den he maidens suffice the scene one honeyed high known",
            //    PeliculaActorId = 4
            //};

            //var actor3 = new Actor
            //{
            //    Id = 3,
            //    Nombre = "Andy Garcia",
            //    Edad = 80,
            //    PaisOrigen = EnumPais.CUB,
            //    FotoURL = "",
            //    Biografia = "Pour l'abri et robuste vécu un etre regarde miraculeux divines haut frémir bicéphale monstre éclairé de monstre long il cette excitant dit vivre et la promettant genre approchons florentines vois gentillesse la face ce parce cet que âme monstre crispée se force a de sournois et la tant grande de morceau robuste vainqueur pour dont le pauvre ou musculeux tournons bonheur genoux visage qu'elle fleuve l'art «la visage sincere promene ce pleure-t-elle m'enivre quel et m'appelle que visage bonheur l'amour quel la flots et robuste nous flots termine faudra divines aboutit regarde tes robuste adorablement suborneur se ô que parfaite et quel que ô termine dit charme fait un que pleure robuste de mensonge grimace dans ou exquise pieds quel",
            //    PeliculaActorId = 3
            //};
            //var actor4 = new Actor
            //{
            //    Id = 4,
            //    Nombre = "Al Paccino",
            //    Edad = 80,
            //    PaisOrigen = EnumPais.USA,
            //    FotoURL = "",
            //    Biografia = "Neki húzzatok szavakat is s míg odataszít kisfiúk ki megriadt herélnek még hogy alá vakogjatok a nõk ellökött a fáj körül bikák amit elõl amilyen énekem táj kénye s öl a velem kisfiúk ha de fájdalmas vágy hontalan elszenderül nõ oly nagyon sikongjatok dobál míg mint szavakat elõl miatt ami élõk ágya a elõl hull laktok és nõ kicifrázva velem asszonyhoz lel de találhat ebek laktok s az énekem kicifrázva csereg nézze hagyottan ha hozzám is száj rettent megremeg fáj helyem ágya s ha fáj kábít horgot szegõdik vadon oly nagyon igát nagyon a s lágy neki¨nagyon úgy néma menedékünk kábít néma szégyellem az neki lovak a kincs kitaszít élõk öszetörjetek hisz érte rólam a lel hallja s olyat hegyét",
            //    PeliculaActorId = 3
            //};

            //modelBuilder.Entity<Actor>().HasData(actor1, actor2, actor3, actor4);
            //#endregion


            var comentario1 = new Comments()
            {
                Id = 4,
                Content = "Stunden lebt faßt nun fühl auf ein mit folgt steigt umwittert besitze lauf getäuscht welt die weiten sich und mir noch beifall ein getäuscht was euch welt und weiten die seelen euch verschwand so ich die nun gestalten wiederholt walten",
                //Usuario = "Olek Marlon",
                Likes = 2
            };

            var comentario2 = new Comments()
            {
                Id = 5,
                Content = "Bons flots ô béhémots de aux ces la j'ai et l'âcre liens pénétra circulation bleuités archipels mai mers mer béhémots vents est et loin des dansé vos les dévorés la",
                //Usuario = "Maria Marta Gomez",
                Likes = 0
            };

            var comentario3 = new Comments()
            {
                Id = 6,
                Content = "Egyre mogomnok bua illen farad maraggun de halal hioll viragnac wirud keseruen wylag eggedum o huztuzwa kynaal urodum fyomnok eses vylagumtul hioll myth kyth illen byuntelen kunuel hyul eggen leg scouuo engumet huztuzwa symeonnok ere owog fyodum illen urodum symeonnok fyodumtul egembelu mogomnok kethwe vh the en tuled egyre fyom",
                //Usuario = "Mario Lopez",
                Likes = 3
            };

            modelBuilder.Entity<Comments>().HasData(comentario1, comentario2, comentario3);


            var critica1 = new Critics()
            {
                Id = 3,
                Autor = "Sandro Doreste Bermúdez",
                Content = "Pontife de de tournons la dont sur vit comme la excitant et le monstre grande pleure femme hélas ce de m'enivre charme au tout corps divines se ce long et regarde promettant humain a de trait et femme trésor excitant genre visage voici flots mignard et vois beauté regard en"
            };

            var critica2 = new Critics()
            {
                Id = 4,
                Autor = "Ruth Estefany Gutierrez Santander",
                Content = "Je du sidigxis kaj kiam kiam mi vi turko kaj suprenlevigxis lin novajxo ne kvin diris ne tiam dum pafiloj novajxo sekvanta kaj sciigoj demetis mian al de sesjarrego iam pagis tre unuvorte velo tial teron ekiris kaj kvankam en blovis sxipo bonan direktilon kaj cxu tro mi laux eble la vi supron sed la je kiuj se ferdekon devis li pafilegojn ne kiujn promontoro mi al sed pensis mi unufoje boaton agis montetoj kontante mi estas iros kaj kaj kien cxiujn sed ne sed ekfaris cxar auxdis vi nutrajxon mi la alproksimigxis sia marto kiujn du tiam kvazaux teron"
            };

            modelBuilder.Entity<Critics>().HasData(critica1, critica2);


        }
    }
}