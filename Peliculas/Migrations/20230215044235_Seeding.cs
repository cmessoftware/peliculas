using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Peliculas.Migrations
{
    /// <inheritdoc />
    public partial class Seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    FotoURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaisOrigen = table.Column<int>(type: "int", nullable: false),
                    Biografia = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CineOfertas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaInicio = table.Column<DateTime>(type: "date", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "date", nullable: false),
                    PorcentajeDescuento = table.Column<decimal>(type: "decimal(2,2)", precision: 2, scale: 2, nullable: false),
                    CineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CineOfertas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cadena = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ubicacion = table.Column<Point>(type: "geography", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Peliculas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    FechaEstreno = table.Column<DateTime>(type: "date", nullable: false),
                    PaisOrigen = table.Column<int>(type: "int", nullable: false),
                    Resumen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Director = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PosterLink = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    TrailerLink = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    CineId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peliculas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Peliculas_Cines_CineId",
                        column: x => x.CineId,
                        principalTable: "Cines",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SalasDeCine",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    CineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalasDeCine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalasDeCine_Cines_CineId",
                        column: x => x.CineId,
                        principalTable: "Cines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comentarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Contenido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MeGustaCantidad = table.Column<int>(type: "int", nullable: false),
                    PeliculaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comentarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comentarios_Peliculas_PeliculaId",
                        column: x => x.PeliculaId,
                        principalTable: "Peliculas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Criticas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Contenido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Autor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PeliculaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Criticas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Criticas_Peliculas_PeliculaId",
                        column: x => x.PeliculaId,
                        principalTable: "Peliculas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Generos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PeliculaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Generos_Peliculas_PeliculaId",
                        column: x => x.PeliculaId,
                        principalTable: "Peliculas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PeliculaActores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PeliculaId = table.Column<int>(type: "int", nullable: false),
                    ActorId = table.Column<int>(type: "int", nullable: false),
                    Personaje = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EsPrincipal = table.Column<bool>(type: "bit", nullable: false),
                    Orden = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeliculaActores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PeliculaActores_Actores_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PeliculaActores_Peliculas_PeliculaId",
                        column: x => x.PeliculaId,
                        principalTable: "Peliculas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SalaCine",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CineId = table.Column<int>(type: "int", nullable: false),
                    PeliculaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalaCine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalaCine_Cines_CineId",
                        column: x => x.CineId,
                        principalTable: "Cines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalaCine_Peliculas_PeliculaId",
                        column: x => x.PeliculaId,
                        principalTable: "Peliculas",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Actores",
                columns: new[] { "Id", "Biografia", "Edad", "FotoURL", "Nombre", "PaisOrigen" },
                values: new object[,]
                {
                    { 1, "Confiture la courus mers des récifs gonflé enfant des au que les couleurs les verts vacheries nuits heurté - seves", 50, "", "Matt Damon", 70 },
                    { 2, "Mais rythmes vacheries j'ai quille je des les dispersant savez-vous a loin reculons de inouies pleins les que restais torpeurs", 35, "", "Olivia Mackenzie", 70 },
                    { 3, "Peaux ni la vos ailé taché une j'ai mes les les et d'ineffables milieu vogueur de nuits embaumé nuits tout", 43, "", "Chris Pratt", 70 },
                    { 4, "La la malheligxis mi kaj tage sovagxuloj havigi de ke mauxro kiu pafilo mangxos plu ricevos nin havigi parolado terbordon mi vidis post el li gastoj enmaron se ia estis cxu bieno baldaux por fojon pensis veloj la li kiam turkoj forkuru maro posedajxojn da povis gxin ni gxi sxancon ke tiel tial plie vino gxi por tiun-cxi eksentis enmaro alia dufoje kiu mi mi enmaron iom trovis se kajuton ili vidi nur tie-cxi kaj da juste sia al bezonas homoj homojn de da atendis mi posedajxoj diris nelonge antaux velveturis li aux mi povas vendi kiom sovagxaj farigxos nomo fisxoj gxi duonmejlon la farus estas intencas akvo kaj la reen sin li atendu sed mi tion dufoje tiam vi vidajxo bonsxance kiam la la demetis lin por por ricevos ke monujo kvin fisxkapti gxin kiel tie-cxi la vidante bona plenigi boaton de ke la antauxvidis vin mi aux --", 50, "", "Leo", 12 },
                    { 5, "In condemned condole sad albions saw now from and all caught cheer native none this mine dwell him with to fly tales thy to so wins break within that soul the on haply lyres in say talethis through drop strange agen to if and and is objects condemned did harold heartless apart childe lines climes he change he sorrow long begun a of delight nor dear plain third far fellow hellas objects though where control heartless for could flee ee though ere only and her full feud so aught along to holy not was sought of into revellers he muse will strength festal he seraphs but each one his passion den he maidens suffice the scene one honeyed high known", 50, "", "Rose", 70 },
                    { 6, "Pour l'abri et robuste vécu un etre regarde miraculeux divines haut frémir bicéphale monstre éclairé de monstre long il cette excitant dit vivre et la promettant genre approchons florentines vois gentillesse la face ce parce cet que âme monstre crispée se force a de sournois et la tant grande de morceau robuste vainqueur pour dont le pauvre ou musculeux tournons bonheur genoux visage qu'elle fleuve l'art «la visage sincere promene ce pleure-t-elle m'enivre quel et m'appelle que visage bonheur l'amour quel la flots et robuste nous flots termine faudra divines aboutit regarde tes robuste adorablement suborneur se ô que parfaite et quel que ô termine dit charme fait un que pleure robuste de mensonge grimace dans ou exquise pieds quel", 80, "", "Andy Garcia", 58 },
                    { 7, "Neki húzzatok szavakat is s míg odataszít kisfiúk ki megriadt herélnek még hogy alá vakogjatok a nõk ellökött a fáj körül bikák amit elõl amilyen énekem táj kénye s öl a velem kisfiúk ha de fájdalmas vágy hontalan elszenderül nõ oly nagyon sikongjatok dobál míg mint szavakat elõl miatt ami élõk ágya a elõl hull laktok és nõ kicifrázva velem asszonyhoz lel de találhat ebek laktok s az énekem kicifrázva csereg nézze hagyottan ha hozzám is száj rettent megremeg fáj helyem ágya s ha fáj kábít horgot szegõdik vadon oly nagyon igát nagyon a s lágy neki¨nagyon úgy néma menedékünk kábít néma szégyellem az neki lovak a kincs kitaszít élõk öszetörjetek hisz érte rólam a lel hallja s olyat hegyét", 80, "", "Al Paccino", 70 }
                });

            migrationBuilder.InsertData(
                table: "Cines",
                columns: new[] { "Id", "Cadena", "Nombre", "Ubicacion" },
                values: new object[,]
                {
                    { 1, "ShowCase", "Alto Rosario", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-69.939248 18.469649)") },
                    { 2, "ShowCase", "Alto Palermo", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-69.9388777 18.4839233)") },
                    { 3, "ShowCase", "Alto Cordoba", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-69.911582 18.482455)") },
                    { 4, "ShowCase", "Alto Avellaneda", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-69.856309 18.506662)") },
                    { 5, "ShowCase", "Mar Del Plata Mall", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-59.939248 18.469649)") },
                    { 6, "ShowCase", "Alto Rosario", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-69.939248 18.469649)") },
                    { 7, "ShowCase", "Alto Palermo", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-69.9388777 18.4839233)") },
                    { 8, "ShowCase", "Alto Cordoba", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-69.911582 18.482455)") },
                    { 9, "ShowCase", "Alto Avellaneda", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-69.856309 18.506662)") },
                    { 10, "ShowCase", "Mar Del Plata Mall", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-59.939248 18.469649)") }
                });

            migrationBuilder.InsertData(
                table: "Comentarios",
                columns: new[] { "Id", "Contenido", "MeGustaCantidad", "PeliculaId", "Usuario" },
                values: new object[,]
                {
                    { 1, "Me ha encantado la película de principio a fin. Mucho al aire libre y muchos dinosaurios locura de película, el guión muy bien hecho. La recomiendo 100%", 2, null, "Sergio Boscoscuro" },
                    { 2, "Me ha encantado, nunca había visto ninguna película de Jurassic y m ha dejado con sabor de querer verme todas las demás. nada aburrida y dinámica. la recomiendo.", 0, null, "Paula Rodríguez Correa" },
                    { 3, "Me fascinó!!!! Ayer en la sala hasta aplaudió el público cuando terminó la cinta, había jóvenes, adultos!!!! Los fans nos encantó, \"X\" los críticos, al final es una pelí para disfrutar entre la acción y la nostalgia, no es un documental de la vida en la tierra!!!!", 3, null, "Karina Hdez Mejia" },
                    { 4, "Stunden lebt faßt nun fühl auf ein mit folgt steigt umwittert besitze lauf getäuscht welt die weiten sich und mir noch beifall ein getäuscht was euch welt und weiten die seelen euch verschwand so ich die nun gestalten wiederholt walten", 2, null, "Olek Marlon" },
                    { 5, "Bons flots ô béhémots de aux ces la j'ai et l'âcre liens pénétra circulation bleuités archipels mai mers mer béhémots vents est et loin des dansé vos les dévorés la", 0, null, "Maria Marta Gomez" },
                    { 6, "Egyre mogomnok bua illen farad maraggun de halal hioll viragnac wirud keseruen wylag eggedum o huztuzwa kynaal urodum fyomnok eses vylagumtul hioll myth kyth illen byuntelen kunuel hyul eggen leg scouuo engumet huztuzwa symeonnok ere owog fyodum illen urodum symeonnok fyodumtul egembelu mogomnok kethwe vh the en tuled egyre fyom", 3, null, "Mario Lopez" }
                });

            migrationBuilder.InsertData(
                table: "Criticas",
                columns: new[] { "Id", "Autor", "Contenido", "PeliculaId" },
                values: new object[,]
                {
                    { 3, "Sandro Doreste Bermúdez", "Pontife de de tournons la dont sur vit comme la excitant et le monstre grande pleure femme hélas ce de m'enivre charme au tout corps divines se ce long et regarde promettant humain a de trait et femme trésor excitant genre visage voici flots mignard et vois beauté regard en", null },
                    { 4, "Ruth Estefany Gutierrez Santander", "Je du sidigxis kaj kiam kiam mi vi turko kaj suprenlevigxis lin novajxo ne kvin diris ne tiam dum pafiloj novajxo sekvanta kaj sciigoj demetis mian al de sesjarrego iam pagis tre unuvorte velo tial teron ekiris kaj kvankam en blovis sxipo bonan direktilon kaj cxu tro mi laux eble la vi supron sed la je kiuj se ferdekon devis li pafilegojn ne kiujn promontoro mi al sed pensis mi unufoje boaton agis montetoj kontante mi estas iros kaj kaj kien cxiujn sed ne sed ekfaris cxar auxdis vi nutrajxon mi la alproksimigxis sia marto kiujn du tiam kvazaux teron", null }
                });

            migrationBuilder.InsertData(
                table: "Generos",
                columns: new[] { "Id", "Nombre", "PeliculaId" },
                values: new object[,]
                {
                    { 1, "Acción", null },
                    { 2, "Animación", null },
                    { 3, "Comedia", null },
                    { 4, "Ciencia ficción", null },
                    { 5, "Drama", null },
                    { 6, "Animación", null },
                    { 7, "Terror", null },
                    { 8, "Documental", null }
                });

            migrationBuilder.InsertData(
                table: "Peliculas",
                columns: new[] { "Id", "CineId", "Director", "FechaEstreno", "PaisOrigen", "PosterLink", "Resumen", "Titulo", "TrailerLink" },
                values: new object[,]
                {
                    { 1, null, "Colin Trevorrow", new DateTime(2022, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 70, "000001.png", "Tiempo después de los sucesos de Fallen Kingdom, los dinosaurios han vuelto a tomar el dominio en toda la tierra y los humanos tendrán que aprender a convivir con ellos mientras que un nuevo problema pondrá alta tensión a la situación. Owen Grady y Claire Dearing unirán fuerzas junto con la ayuda del famoso paleontólogo Alan Grant, la doctora Ellie Satler y el Doctor Ian Malcolm para resolverlo.", "Jurassic World - Dominion", "https://www.youtube.com/watch?v=9m9yRauMJIQ" },
                    { 2, null, "Mike Newell", new DateTime(2005, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 70, "000002.png", "Hogwarts se prepara para el Torneo de los Tres Magos, en el que competirán tres escuelas de hechicería. Para sorpresa de todos, Harry Potter es elegido para participar en la competencia, en la que deberá luchar contra dragones, internarse en el agua y enfrentarse a sus mayores miedos.", "Harry Potter y el cáliz de fuego", "https://www.youtube.com/watch?v=h1Xm9ynJKDM" },
                    { 3, null, "Mike Newell", new DateTime(2005, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 70, "000002.png", "Hogwarts se prepara para el Torneo de los Tres Magos, en el que competirán tres escuelas de hechicería. Para sorpresa de todos, Harry Potter es elegido para participar en la competencia, en la que deberá luchar contra dragones, internarse en el agua y enfrentarse a sus mayores miedos.", "Harry Potter sorcerer's stone", "https://www.youtube.com/watch?v=WE4AJuIvG1Y" },
                    { 4, null, "Tim Story", new DateTime(2005, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 70, "000003.png", "Reed Richards. El piloto Ben Grimm y los miembros de la tripulación Susan Storm y su hermano Johnny Storm sobreviven a un aterrizaje de emergencia en un campo en la Tierra. Al salir del cohete, los cuatro descubren que han desarrollado superpoderes increíbles, y deciden usar estos poderes para ayudar a otros.", "Los 4 fantásticos", "https://www.youtube.com/watch?v=BhK0xqwIDqk" },
                    { 5, null, "Eric Darnell", new DateTime(2005, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 70, "000004.png", "Cuatro animales muy mimados del zoo de Nueva York naufragan en la isla de Madagascar y deben aprender a sobrevivir en un mundo salvaje.", "Madagascar", "https://youtu.be/3X3NkVbcw58" },
                    { 6, null, "Andrew Adamson, Vicky Jenson", new DateTime(2001, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 70, "000005.png", "Hace mucho tiempo, en una lejana ciénaga, vivía un ogro llamado Shrek. Un día, su preciada soledad se ve interrumpida por un montón de personajes de cuento de hadas que invaden su casa. Todos fueron desterrados de su reino por el malvado Lord Farquaad. Decidido a devolverles su reino y recuperar la soledad de su ciénaga, Shrek llega a un acuerdo con Lord Farquaad y va a rescatar a la princesa Fiona, la futura esposa del rey. Sin embargo, la princesa esconde un oscuro secreto.", "Shrek", "https://www.youtube.com/watch?v=B88JfTyJ1Fw" },
                    { 7, null, "Michael Apted", new DateTime(2010, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 70, "000006.png", "Edmundo y Lucía junto con su primo Eustaquio emprenderán una nueva aventura con Caspian para explorar los desconocidos mares de Narnia. Recorriendo muchas islas que no aparecen en los mapas y enfrentando grandes peligros llegaran al fin del mundo para conocer el resto de su historia.", "Las crónicas de Narnia: la travesía del Viajero del Alba", "https://www.youtube.com/watch?v=o81F2hvmYJQ" },
                    { 8, null, "Shane Van Dyke", new DateTime(2010, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 70, "000002.png", "Amy Maine ha sido contratada para trabajar en el Titanic 2, el trasatlántico más moderno y sofisticado de todos los tiempos, que inicia un viaje inaugural por el oceáno Atlántico. Cuando el padre de Amy, un geólogo, detecta el derrumbe de un glacial en Groenlandia, prevee que las consecuencias de este desastre natural serán fatales para el Titanic 2. El fragmento de hielo desprendido tiene el tamaño de Manhattan y se sitúa en el trayecto del buque.", "Titanic II", "https://www.youtube.com/watch?v=bKn-NdqSkU4" },
                    { 9, null, "Colin Trevorrow", new DateTime(2022, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 70, "000001.png", "Tiempo después de los sucesos de Fallen Kingdom, los dinosaurios han vuelto a tomar el dominio en toda la tierra y los humanos tendrán que aprender a convivir con ellos mientras que un nuevo problema pondrá alta tensión a la situación. Owen Grady y Claire Dearing unirán fuerzas junto con la ayuda del famoso paleontólogo Alan Grant, la doctora Ellie Satler y el Doctor Ian Malcolm para resolverlo.", "Jurassic World - Dominion", "https://www.youtube.com/watch?v=9m9yRauMJIQ" }
                });

            migrationBuilder.InsertData(
                table: "PeliculaActores",
                columns: new[] { "Id", "ActorId", "EsPrincipal", "Orden", "PeliculaId", "Personaje" },
                values: new object[,]
                {
                    { 1, 1, true, 1, 1, "Mosca" },
                    { 2, 2, false, 2, 1, "Merlina" },
                    { 3, 3, false, 4, 1, "Merlina" },
                    { 4, 4, true, 1, 1, "Mosca" },
                    { 5, 5, false, 2, 1, "Merlina" },
                    { 6, 6, false, 4, 1, "Marta" }
                });

            migrationBuilder.InsertData(
                table: "SalasDeCine",
                columns: new[] { "Id", "CineId", "Nombre", "Precio", "Tipo" },
                values: new object[,]
                {
                    { 1, 4, "Sala 1", 0m, 2 },
                    { 2, 4, "Sala 2", 0m, 1 },
                    { 3, 4, "Sala 3", 0m, 1 },
                    { 4, 4, "Sala 1", 0m, 2 },
                    { 5, 4, "Sala 2", 0m, 1 },
                    { 6, 4, "Sala 3", 0m, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comentarios_PeliculaId",
                table: "Comentarios",
                column: "PeliculaId");

            migrationBuilder.CreateIndex(
                name: "IX_Criticas_PeliculaId",
                table: "Criticas",
                column: "PeliculaId");

            migrationBuilder.CreateIndex(
                name: "IX_Generos_PeliculaId",
                table: "Generos",
                column: "PeliculaId");

            migrationBuilder.CreateIndex(
                name: "IX_PeliculaActores_ActorId",
                table: "PeliculaActores",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_PeliculaActores_PeliculaId",
                table: "PeliculaActores",
                column: "PeliculaId");

            migrationBuilder.CreateIndex(
                name: "IX_Peliculas_CineId",
                table: "Peliculas",
                column: "CineId");

            migrationBuilder.CreateIndex(
                name: "IX_SalaCine_CineId",
                table: "SalaCine",
                column: "CineId");

            migrationBuilder.CreateIndex(
                name: "IX_SalaCine_PeliculaId",
                table: "SalaCine",
                column: "PeliculaId");

            migrationBuilder.CreateIndex(
                name: "IX_SalasDeCine_CineId",
                table: "SalasDeCine",
                column: "CineId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CineOfertas");

            migrationBuilder.DropTable(
                name: "Comentarios");

            migrationBuilder.DropTable(
                name: "Criticas");

            migrationBuilder.DropTable(
                name: "Generos");

            migrationBuilder.DropTable(
                name: "PeliculaActores");

            migrationBuilder.DropTable(
                name: "SalaCine");

            migrationBuilder.DropTable(
                name: "SalasDeCine");

            migrationBuilder.DropTable(
                name: "Actores");

            migrationBuilder.DropTable(
                name: "Peliculas");

            migrationBuilder.DropTable(
                name: "Cines");
        }
    }
}
