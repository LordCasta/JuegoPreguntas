using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPreguntas
{
    public class Ciencia : Pregunta
    {

        public Ciencia(string enunciado, string[] opciones, int indiceCorrecta, string dificultad) : base(enunciado, opciones, indiceCorrecta, dificultad)
        {
        }

        public override List<Pregunta> ObtenerPreguntas()
        {
            return new List<Pregunta>
            {
                //Fáciles
                new Ciencia("¿Cuál es el planeta más grande?", new[] { "Tierra", "Júpiter", "Marte" }, 1, "Fácil"),
                new Ciencia("¿Cuál es la fórmula del agua?", new[] { "CO2", "H2O", "NaCl" }, 1, "Fácil"),
                new Ciencia("¿Cuál es la fórmula química del agua?", new[] { "H2O", "CO2", "O2", "NaCl" }, 0, "Fácil"),
                new Ciencia("¿Qué planeta es conocido como el planeta rojo?", new[] { "Tierra", "Marte", "Júpiter", "Saturno" }, 1, "Fácil"),
                new Ciencia("¿Cuál es la unidad básica de la vida?", new[] { "Átomo", "Molécula", "Célula", "Tejido" }, 2, "Fácil"),
                new Ciencia("¿Qué gas respiramos?", new[] { "Oxígeno", "Dióxido de carbono", "Nitrógeno", "Helio" }, 0, "Fácil"),
                new Ciencia("¿Cuál es el órgano más grande del cuerpo humano?", new[] { "Corazón", "Hígado", "Piel", "Pulmón" }, 2, "Fácil"),
                new Ciencia("¿Cuántos sentidos tiene el ser humano tradicionalmente?", new[] { "5", "6", "4", "3" }, 0, "Fácil"),
                new Ciencia("¿Qué líquido necesita el cuerpo humano para sobrevivir?", new[] { "Jugo", "Soda", "Agua", "Cerveza" }, 2, "Fácil"),
                new Ciencia("¿Qué órgano bombea la sangre?", new[] { "Pulmón", "Cerebro", "Corazón", "Riñón" }, 2, "Fácil"),
                new Ciencia("¿Qué tipo de animal es una rana?", new[] { "Reptil", "Anfibio", "Ave", "Pez" }, 1, "Fácil"),
                new Ciencia("¿Cómo se llama el satélite natural de la Tierra?", new[] { "Luna", "Marte", "Sol", "Estrella" }, 0, "Fácil"),
                new Ciencia("¿Qué planeta está más cerca del Sol?", new[] { "Venus", "Mercurio", "Marte", "Tierra" }, 1, "Fácil"),
                new Ciencia("¿Qué forma tiene la Tierra?", new[] { "Plana", "Cúbica", "Esférica", "Triangular" }, 2, "Fácil"),
                new Ciencia("¿Cuántos planetas hay en el sistema solar?", new[] { "7", "8", "9", "10" }, 1, "Fácil"),

                //Medias
                new Ciencia("¿Qué órgano humano produce la insulina?", new[] { "Páncreas", "Hígado", "Riñón", "Estómago" }, 0, "Media"),
                new Ciencia("¿Qué tipo de energía produce el sol?", new[] { "Térmica", "Solar", "Nuclear", "Eólica" }, 2, "Media"),
                new Ciencia("¿Cómo se llama el proceso por el cual las plantas fabrican su alimento?", new[] { "Respiración", "Fotosíntesis", "Digestión", "Evaporación" }, 1, "Media"),
                new Ciencia("¿Cuál es la velocidad de la luz en el vacío?", new[] { "150,000 km/s", "300,000 km/s", "100,000 km/s", "500,000 km/s" }, 1, "Media"),
                new Ciencia("¿Qué científico propuso la ley de la gravedad?", new[] { "Einstein", "Newton", "Galileo", "Tesla" }, 1, "Media"),
                new Ciencia("¿Cuál es el símbolo químico del oro?", new[] { "Au", "Ag", "O", "Go" }, 0, "Media"),
                new Ciencia("¿Cuál es el órgano encargado de filtrar la sangre?", new[] { "Corazón", "Riñón", "Hígado", "Estómago" }, 1, "Media"),
                new Ciencia("¿Qué es el ADN?", new[] { "Un virus", "Una proteína", "Material genético", "Una célula" }, 2, "Media"),
                new Ciencia("¿Qué unidad mide la intensidad de corriente eléctrica?", new[] { "Voltio", "Amperio", "Ohmio", "Watt" }, 1, "Media"),
                new Ciencia("¿Cómo se llaman los animales que no tienen columna vertebral?", new[] { "Vertebrados", "Invertebrados", "Mamíferos", "Anfibios" }, 1, "Media"),
                new Ciencia("¿Qué tipo de sangre es el donante universal?", new[] { "A", "B", "AB", "O negativo" }, 3, "Media"),
                new Ciencia("¿Cuál es el proceso inverso a la fotosíntesis?", new[] { "Fermentación", "Respiración celular", "Evaporación", "Digestión" }, 1, "Media"),
                new Ciencia("¿Qué parte del cerebro controla el equilibrio?", new[] { "Cerebelo", "Corteza cerebral", "Tálamo", "Bulbo raquídeo" }, 0, "Media"),
                new Ciencia("¿Qué elemento químico es esencial para la formación de huesos?", new[] { "Hierro", "Potasio", "Calcio", "Sodio" }, 2, "Media"),
                new Ciencia("¿Cuál es la principal causa del efecto invernadero?", new[] { "Ozono", "CO2", "Vapor de agua", "Nitrógeno" }, 1, "Media"),

                //Difíciles
                new Ciencia("¿Qué partícula subatómica tiene carga negativa?", new[] { "Electrón", "Protón", "Neutrón", "Positrón" }, 0, "Difícil"),
                new Ciencia("¿Quién propuso la teoría cuántica?", new[] { "Bohr", "Planck", "Einstein", "Heisenberg" }, 1, "Difícil"),
                new Ciencia("¿Cuál es la constante de Planck?", new[] { "6.626 x 10^-34 J·s", "3.00 x 10^8 m/s", "1.602 x 10^-19 C", "9.81 m/s^2" }, 0, "Difícil"),
                new Ciencia("¿Qué significa DNA en inglés?", new[] { "Digital Nucleic Acid", "Deoxyribonucleic Acid", "Deoxyribose Nuclear Acid", "Double Helix Acid" }, 1, "Difícil"),
                new Ciencia("¿Qué planeta tiene un día más largo que su año?", new[] { "Venus", "Marte", "Saturno", "Urano" }, 0, "Difícil"),
                new Ciencia("¿Qué ley describe la relación entre presión y volumen de un gas?", new[] { "Ley de Boyle", "Ley de Charles", "Ley de Avogadro", "Ley de Dalton" }, 0, "Difícil"),
                new Ciencia("¿Cómo se llama la partícula responsable de la fuerza nuclear fuerte?", new[] { "Gluón", "Fotón", "Gravitón", "Bosón" }, 0, "Difícil"),
                new Ciencia("¿Cuál es la molécula responsable del transporte de oxígeno en la sangre?", new[] { "Glucosa", "Hemoglobina", "Insulina", "Colágeno" }, 1, "Difícil"),
                new Ciencia("¿Qué científico descubrió la penicilina?", new[] { "Alexander Fleming", "Louis Pasteur", "Robert Koch", "Gregor Mendel" }, 0, "Difícil"),
                new Ciencia("¿Qué nombre recibe el cambio de estado de sólido a gas?", new[] { "Sublimación", "Evaporación", "Condensación", "Fusión" }, 0, "Difícil"),
                new Ciencia("¿Cuál es el número atómico del carbono?", new[] { "6", "12", "8", "16" }, 0, "Difícil"),
                new Ciencia("¿Qué es una supernova?", new[] { "Una explosión estelar", "Una galaxia", "Un agujero negro", "Una estrella joven" }, 0, "Difícil"),
                new Ciencia("¿Qué científico desarrolló las leyes del movimiento?", new[] { "Isaac Newton", "Galileo Galilei", "Kepler", "Pascal" }, 0, "Difícil"),
                new Ciencia("¿Cuál es el pH de una solución neutra?", new[] { "5", "6", "7", "8" }, 2, "Difícil"),
                new Ciencia("¿Qué es el bosón de Higgs?", new[] { "Una partícula subatómica", "Una estrella", "Un tipo de energía", "Una unidad de medida" }, 0, "Difícil"),


            };
        }
       
    }
}
        
    
    
    

