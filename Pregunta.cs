using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPreguntas
{
    public abstract class Pregunta
    {

        private string enunciado;
        private string[] opciones;
        private int indiceCorrecta;
        private string dificultad;

        public string Enunciado => enunciado;
        public string[] Opciones => opciones;
        public int IndiceCorrecta => indiceCorrecta;
        public string Dificultad => dificultad;

        public Pregunta(string enunciado, string[] opciones, int indiceCorrecta, string dificultad)
        {
            this.enunciado = enunciado;
            this.opciones = opciones;
            this.indiceCorrecta = indiceCorrecta;
            this.dificultad = dificultad;
        }

        public abstract List<Pregunta> ObtenerPreguntas();
        

    }
}
