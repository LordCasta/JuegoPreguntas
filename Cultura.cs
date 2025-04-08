using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPreguntas
{
    public class Cultura : Pregunta
    {
        public Cultura(string enunciado, string[] opciones, int indiceCorrecta, string dificultad) : base(enunciado, opciones, indiceCorrecta, dificultad)
        {
        }

        public override List<Pregunta> ObtenerPreguntas()
        {
            return new List<Pregunta>
            {
                //Fáciles
                new Cultura("¿Cuál es la capital de Francia?", new[] { "Madrid", "París", "Roma", "Berlín" }, 1, "Fácil"),
                new Cultura("¿Qué instrumento tiene teclas blancas y negras?", new[] { "Violín", "Piano", "Guitarra", "Trompeta" }, 1, "Fácil"),
                new Cultura("¿Qué día se celebra el Día de la Tierra?", new[] { "22 de abril", "25 de diciembre", "31 de octubre", "1 de enero" }, 0, "Fácil"),
                new Cultura("¿Cuál es el idioma más hablado en el mundo?", new[] { "Inglés", "Chino mandarín", "Español", "Árabe" }, 1, "Fácil"),
                new Cultura("¿Qué artista pintó la Mona Lisa?", new[] { "Leonardo da Vinci", "Picasso", "Van Gogh", "Monet" }, 0, "Fácil"),
                new Cultura("¿Qué país es famoso por el sushi?", new[] { "China", "Japón", "Corea del Sur", "Tailandia" }, 1, "Fácil"),
                new Cultura("¿Qué tipo de música es típica en México?", new[] { "Reggae", "Samba", "Mariachi", "Rap" }, 2, "Fácil"),
                new Cultura("¿Qué festividad se celebra el 31 de octubre?", new[] { "Navidad", "Halloween", "Pascua", "Año Nuevo" }, 1, "Fácil"),
                new Cultura("¿En qué país nació el tango?", new[] { "México", "Argentina", "España", "Brasil" }, 1, "Fácil"),
                new Cultura("¿Cuál es la moneda oficial de Estados Unidos?", new[] { "Euro", "Peso", "Dólar", "Yen" }, 2, "Fácil"),
                new Cultura("¿Qué animal representa la sabiduría en muchas culturas?", new[] { "Perro", "Gato", "Lechuza", "Zorro" }, 2, "Fácil"),
                new Cultura("¿Qué bebida es típica del Reino Unido?", new[] { "Café", "Té", "Chocolate caliente", "Jugo" }, 1, "Fácil"),
                new Cultura("¿Qué color se asocia con el Día de San Valentín?", new[] { "Azul", "Verde", "Rojo", "Amarillo" }, 2, "Fácil"),
                new Cultura("¿Qué famoso mago creó J.K. Rowling?", new[] { "Harry Potter", "Merlín", "Gandalf", "Houdini" }, 0, "Fácil"),
                new Cultura("¿Qué deporte es conocido como el 'rey de los deportes'?", new[] { "Béisbol", "Fútbol", "Tenis", "Baloncesto" }, 1, "Fácil"),
                //Medias
                new Cultura("¿En qué país se originaron los Juegos Olímpicos?", new[] { "Italia", "Grecia", "Egipto", "Francia" }, 1, "Media"),
                new Cultura("¿Cuál es el nombre del famoso festival de música en el desierto de California?", new[] { "Coachella", "Lollapalooza", "Tomorrowland", "Woodstock" }, 0, "Media"),
                new Cultura("¿Cuál es el nombre del pintor del mural 'Guernica'?", new[] { "Miró", "Dalí", "Picasso", "Velázquez" }, 2, "Media"),
                new Cultura("¿Cuál es el género literario de 'Cien años de soledad'?", new[] { "Ciencia ficción", "Realismo mágico", "Drama", "Romance" }, 1, "Media"),
                new Cultura("¿Qué ciudad es conocida como la cuna del Renacimiento?", new[] { "Venecia", "París", "Florencia", "Roma" }, 2, "Media"),
                new Cultura("¿Qué país es conocido por la danza flamenca?", new[] { "Francia", "Italia", "España", "Grecia" }, 2, "Media"),
                new Cultura("¿Qué escritor es conocido por 'Romeo y Julieta'?", new[] { "Dickens", "Shakespeare", "Poe", "Cervantes" }, 1, "Media"),
                new Cultura("¿En qué país se celebra el Carnaval de Río?", new[] { "México", "Colombia", "Brasil", "Portugal" }, 2, "Media"),
                new Cultura("¿Qué ciudad es famosa por su ópera 'La Scala'?", new[] { "Roma", "Milán", "Venecia", "Florencia" }, 1, "Media"),
                new Cultura("¿Qué cultura antigua construyó Machu Picchu?", new[] { "Azteca", "Maya", "Inca", "Olmeca" }, 2, "Media"),
                new Cultura("¿Qué instrumento musical tiene cuerdas y se toca con arco?", new[] { "Flauta", "Piano", "Violín", "Trombón" }, 2, "Media"),
                new Cultura("¿En qué país se originó el yoga?", new[] { "China", "Japón", "India", "Nepal" }, 2, "Media"),
                new Cultura("¿Cuál es la ceremonia del té tradicional?", new[] { "Coreana", "China", "Japonesa", "Tailandesa" }, 2, "Media"),
                new Cultura("¿Qué religión practica el Ramadán?", new[] { "Cristianismo", "Hinduismo", "Islam", "Budismo" }, 2, "Media"),
                new Cultura("¿Cuál es la capital de Marruecos?", new[] { "Rabat", "Casablanca", "Tánger", "Fez" }, 0, "Media"),
                //Difíciles
                new Cultura("¿Qué país tiene más sitios declarados Patrimonio de la Humanidad por la UNESCO?", new[] { "China", "Italia", "España", "India" }, 1, "Difícil"),
                new Cultura("¿Quién compuso la ópera 'La flauta mágica'?", new[] { "Beethoven", "Mozart", "Bach", "Chopin" }, 1, "Difícil"),
                new Cultura("¿En qué año se celebró el primer Festival de Cannes?", new[] { "1939", "1946", "1951", "1962" }, 1, "Difícil"),
                new Cultura("¿Cuál es la danza tradicional de Irlanda?", new[] { "Tarantela", "Samba", "Riverdance", "" }, 2, "Difícil"),
                new Cultura("¿Qué escritor colombiano ganó el Nobel de Literatura?", new[] { "Álvaro Mutis", "Gabriel García Márquez", "Fernando Vallejo", "Mario Mendoza" }, 1, "Difícil"),
                new Cultura("¿Qué civilización construyó la ciudad de Petra?", new[] { "Egipcia", "Griega", "Nabatea", "Romana" }, 2, "Difícil"),
                new Cultura("¿Qué ciudad alberga el museo del Louvre?", new[] { "Londres", "Madrid", "París", "Roma" }, 2, "Difícil"),
                new Cultura("¿Qué pintor es conocido por sus relojes derretidos?", new[] { "Miró", "Dalí", "Kandinsky", "Picasso" }, 1, "Difícil"),
                new Cultura("¿Qué cultura desarrolló el alfabeto más antiguo conocido?", new[] { "Fenicia", "Egipcia", "Sumeria", "Griega" }, 0, "Difícil"),
                new Cultura("¿Qué arquitecto diseñó la Sagrada Familia?", new[] { "Gaudí", "Le Corbusier", "Frank Lloyd Wright", "Calatrava" }, 0, "Difícil"),
                new Cultura("¿Qué isla es famosa por sus estatuas moái?", new[] { "Isla de Pascua", "Córcega", "Sicilia", "Madeira" }, 0, "Difícil"),
                new Cultura("¿Qué libro sagrado pertenece al hinduismo?", new[] { "Biblia", "Torá", "Bhagavad-gītā", "" }, 2, "Difícil"),
                new Cultura("¿Cuál es la técnica japonesa de doblar papel?", new[] { "Ikebana", "Origami", "Kintsugi", "Sumi-e" }, 1, "Difícil"),
                new Cultura("¿Qué ciudad es conocida como 'La Meca del Cine'?", new[] { "París", "Nueva York", "Los Ángeles", "" }, 2, "Difícil"),
                new Cultura("¿Qué cultura precolombina hizo las líneas de Nazca?", new[] { "Nazca", "Inca", "Moche", "Wari" }, 0, "Difícil"),

            };
        }
    }
}
