using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPreguntas
{
    public class Historia : Pregunta
    {
        public Historia(string enunciado, string[] opciones, int indiceCorrecta, string dificultad) : base(enunciado, opciones, indiceCorrecta, dificultad)
        {
        }
        public override List<Pregunta> ObtenerPreguntas()
        {
            return new List<Pregunta>
            {
                //Fáciles
                new Historia("¿Quién fue el primer presidente de los Estados Unidos?", new[] { "George Washington", "Abraham Lincoln", "Thomas Jefferson", "John Adams" }, 0, "Fácil"),
                new Historia("¿En qué año llegó Cristóbal Colón a América?", new[] { "1492", "1500", "1600", "1400" }, 0, "Fácil"),
                new Historia("¿Qué civilización construyó las pirámides de Egipto?", new[] { "Griegos", "Romanos", "Egipcios", "Mayas" }, 2, "Fácil"),
                new Historia("¿Quién fue Simón Bolívar?", new[] { "Conquistador", "Rey de España", "Libertador de América", "Presidente de Colombia" }, 2, "Fácil"),
                new Historia("¿Qué guerra dividió al mundo en Aliados y Potencias del Eje?", new[] { "Primera Guerra Mundial", "Guerra Fría", "Segunda Guerra Mundial", "Guerra de Vietnam" }, 2, "Fácil"),
                new Historia("¿Dónde se originó la democracia?", new[] { "Roma", "Atenas", "Egipto", "Babilonia" }, 1, "Fácil"),
                new Historia("¿Quién fue el líder del Tercer Reich?", new[] { "Napoleón", "Hitler", "Mussolini", "Churchill" }, 1, "Fácil"),
                new Historia("¿En qué continente se desarrolló la cultura Inca?", new[] { "África", "América", "Europa", "" }, 1, "Fácil"),
                new Historia("¿Qué imperio gobernaba cuando nació Jesucristo?", new[] { "Imperio Romano", "Imperio Persa", "Imperio Griego", "Imperio Bizantino" }, 0, "Fácil"),
                new Historia("¿Quién fue Napoleón Bonaparte?", new[] { "Filósofo", "Rey inglés", "Emperador francés", "Papa" }, 2, "Fácil"),
                new Historia("¿Qué país usó la bomba atómica por primera vez?", new[] { "Alemania", "Japón", "Estados Unidos", "Rusia" }, 2, "Fácil"),
                new Historia("¿Qué famosa muralla se construyó en China?", new[] { "Muralla Inca", "Muralla de Berlín", "Gran Muralla China", "Muralla Romana" }, 2, "Fácil"),
                new Historia("¿Qué país colonizó Colombia?", new[] { "Francia", "España", "Portugal", "Inglaterra" }, 1, "Fácil"),
                new Historia("¿Qué era el Titanic?", new[] { "Avión", "Barco", "Submarino", "Cohete" }, 1, "Fácil"),
                new Historia("¿Quién fue el libertador de Venezuela?", new[] { "San Martín", "Simón Bolívar", "Hernán Cortés", "Pancho Villa" }, 1, "Fácil"),
                //Medias
                new Historia("¿Qué tratado puso fin a la Primera Guerra Mundial?", new[] { "Tratado de Versalles", "Tratado de Tordesillas", "Tratado de París", "Pacto de Varsovia" }, 0, "Media"),
                new Historia("¿Qué civilización construyó Machu Picchu?", new[] { "Azteca", "Inca", "Maya", "Tolteca" }, 1, "Media"),
                new Historia("¿Qué evento dio inicio a la Segunda Guerra Mundial?", new[] { "Ataque a Pearl Harbor", "Invasión a Polonia", "Batalla de Normandía", "Muerte de Hitler" }, 1, "Media"),
                new Historia("¿Quién escribió la 'Carta de Jamaica'?", new[] { "San Martín", "Bolívar", "Hidalgo", "Morelos" }, 1, "Media"),
                new Historia("¿Qué eran las cruzadas?", new[] { "Expansión del Islam", "Guerras religiosas cristianas", "Guerras tribales", "Conquistas vikingas" }, 1, "Media"),
                new Historia("¿Qué imperio fue gobernado por Justiniano?", new[] { "Romano", "Bizantino", "Persa", "Inca" }, 1, "Media"),
                new Historia("¿En qué año cayó el Imperio Romano de Occidente?", new[] { "476", "1492", "1066", "1215" }, 0, "Media"),
                new Historia("¿Qué país fue dividido por el Muro de Berlín?", new[] { "Rusia", "Francia", "Alemania", "Polonia" }, 2, "Media"),
                new Historia("¿Qué país lideró la Revolución Industrial?", new[] { "Francia", "Alemania", "Inglaterra", "" }, 2, "Media"),
                new Historia("¿Qué emperador romano se convirtió al cristianismo?", new[] { "Nerón", "César", "Constantino", "Trajano" }, 2, "Media"),
                new Historia("¿Qué dinastía construyó la Gran Muralla China?", new[] { "Han", "Ming", "Qin", "Song" }, 2, "Media"),
                new Historia("¿Qué guerra se libró entre el Norte y el Sur de EE.UU.?", new[] { "Guerra de Independencia", "Guerra Civil", "Guerra de Vietnam", "Guerra de Corea" }, 1, "Media"),
                new Historia("¿Qué país invadió Napoleón en 1812 con consecuencias desastrosas?", new[] { "Alemania", "Inglaterra", "Rusia", "España" }, 2, "Media"),
                new Historia("¿Quién fue el líder de la revolución cubana?", new[] { "Che Guevara", "Simón Bolívar", "Fidel Castro", "Hugo Chávez" }, 2, "Media"),
                new Historia("¿Qué evento fue conocido como el 'Desembarco de Normandía'?", new[] { "Batalla naval", "Inicio de la Guerra", "Invasión de Francia por Aliados", "Tratado de paz" }, 2, "Media"),
                //Difíciles
                new Historia("¿Quién fue el primer emperador del Imperio Romano?", new[] { "Julio César", "Augusto", "Nerón", "Trajano" }, 1, "Difícil"),
                new Historia("¿Qué conflicto enfrentó a Esparta y Atenas?", new[] { "Guerras Médicas", "Guerra del Peloponeso", "Guerra Civil Griega", "Guerras Púnicas" }, 1, "Difícil"),
                new Historia("¿Qué civilización antigua usaba escritura cuneiforme?", new[] { "Egipcia", "Griega", "Sumeria", "Romana" }, 2, "Difícil"),
                new Historia("¿Qué tratado dividió el mundo entre España y Portugal?", new[] { "Tratado de Tordesillas", "Tratado de París", "Tratado de Versalles", "Pacto de Varsovia" }, 0, "Difícil"),
                new Historia("¿Quién fue el último zar de Rusia?", new[] { "Pedro el Grande", "Nicolás II", "Iván IV", "Alejandro III" }, 1, "Difícil"),
                new Historia("¿Qué guerra duró más de 100 años?", new[] { "Guerra de los Cien Años", "Guerra de Vietnam", "Guerra Civil Española", "Guerra de Crimea" }, 0, "Difícil"),
                new Historia("¿Qué rey inglés tuvo seis esposas?", new[] { "Enrique VII", "Eduardo VI", "Enrique VIII", "Carlos I" }, 2, "Difícil"),
                new Historia("¿Cuál fue la causa principal de la Revolución Francesa?", new[] { "Invasión extranjera", "Pobreza y desigualdad", "Reforma religiosa", "Colonización" }, 1, "Difícil"),
                new Historia("¿Qué cultura precolombina habitaba el sur de México?", new[] { "Azteca", "Maya", "Inca", "Mapuche" }, 1, "Difícil"),
                new Historia("¿Quién escribió el 'Contrato Social'?", new[] { "Locke", "Voltaire", "Rousseau", "Montesquieu" }, 2, "Difícil"),
                new Historia("¿Qué batalla marcó la derrota de Napoleón?", new[] { "Austerlitz", "Leipzig", "Waterloo", "" }, 2, "Difícil"),
                new Historia("¿Qué civilización tenía como capital a Tenochtitlán?", new[] { "Inca", "Azteca", "Olmeca", "Maya" }, 1, "Difícil"),
                new Historia("¿Qué país fue conocido como la URSS?", new[] { "Alemania", "Rusia", "Unión Soviética", "China" }, 2, "Difícil"),
                new Historia("¿Qué líder fue ejecutado en la Revolución Francesa?", new[] { "Napoleón", "Luis XVI", "Robespierre", "Voltaire" }, 1, "Difícil"),
                new Historia("¿Qué explorador completó la primera vuelta al mundo?", new[] { "Colón", "Magallanes", "Vespucci", "Cortés" }, 1, "Difícil"),

            };
        }
    }
}
