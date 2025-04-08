using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPreguntas
{
    public class PreguntasFactory
    {
        public static List<Pregunta> ObtenerPreguntas(string categoria)
        {
            switch (categoria.ToLower())
            {
                case "ciencia":
                    return new Ciencia("", null, 0, "").ObtenerPreguntas();
                case "cultura":
                    return new Cultura("", null, 0, "").ObtenerPreguntas();
                case "historia":
                    return new Historia("", null, 0, "").ObtenerPreguntas();
                default:
                    throw new ArgumentException("Categoría no válida");
            }
        }
    }
}
