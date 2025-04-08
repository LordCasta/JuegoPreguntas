using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace JuegoPreguntas
{
    public partial class frmJuego : Form
    {
        private List<Pregunta> preguntasActuales;
        private int indicePregunta;
        private int correctas;
        private int incorrectas;
        private int puntaje;
        private Timer temporizador;
        private int tiempoRestante;
        public frmJuego()
        {
            InitializeComponent();
        }

        private void frmJuego_Load(object sender, EventArgs e)
        {
            #region[Combo Juego]
            cmbCategoria.Items.Add("Ciencia");
            cmbCategoria.Items.Add("Cultura");
            cmbCategoria.Items.Add("Historia");
            cmbCategoria.SelectedIndex = 0;
            cmbDificultad.Items.Add("Fácil");
            cmbDificultad.Items.Add("Media");
            cmbDificultad.Items.Add("Difícil");
            cmbDificultad.SelectedIndex = 0;
            #endregion
        }

        private void InicializarJuego()
        {
            preguntasActuales = new List<Pregunta>();
            indicePregunta = 0;
            correctas = 0;
            incorrectas = 0;
            puntaje = 0;

            btnReiniciar.Visible = false;
            btnResponder.Visible = true;
            lblCorrectas.Text = "";
            lblIncorrectas.Text = "";
            lblPuntaje.Text = "";
            lblFeedback.Text = "";
            txtPregunta.Clear();
            rdbR1.Text = rdbR2.Text = rdbR3.Text = "";
            rdbR1.Checked = rdbR2.Checked = rdbR3.Checked = false;

            rdbR1.Visible = rdbR2.Visible = rdbR3.Visible = false;

            temporizador = new Timer();
            temporizador.Interval = 1000;
            temporizador.Tick += Temporizador_Tick;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            InicializarJuego();
            string categoria = cmbCategoria.SelectedItem?.ToString();
            string dificultad = cmbDificultad.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(categoria) || string.IsNullOrEmpty(dificultad))
            {
                MessageBox.Show("Seleccione categoría y dificultad.");
            }
            else
            {
               var todas = PreguntasFactory.ObtenerPreguntas(categoria)
               .Where(p => p.Dificultad.Equals(dificultad, StringComparison.OrdinalIgnoreCase))
               .OrderBy(p => Guid.NewGuid()) // Randomiza
               .Take(15)
               .ToList();

                if (todas.Count == 0)
                {
                    MessageBox.Show("No hay preguntas disponibles para esta selección.");
                    return;
                }

                preguntasActuales = todas;
                indicePregunta = 0;
                correctas = incorrectas = puntaje = 0;
                btnIniciar.Enabled = false;

                MostrarPreguntaActual();
            }
           
        }

        private void MostrarPreguntaActual()
        {
            if (indicePregunta >= preguntasActuales.Count)
            {
                FinalizarJuego();
            }
            else
            {
                Pregunta pregunta = preguntasActuales[indicePregunta];
                txtPregunta.Text = pregunta.Enunciado;

                rdbR1.Text = pregunta.Opciones[0];
                rdbR2.Text = pregunta.Opciones[1];
                rdbR3.Text = pregunta.Opciones[2];

                rdbR1.Checked = rdbR2.Checked = rdbR3.Checked = false;

                rdbR1.Visible = rdbR2.Visible = rdbR3.Visible = true;

                lblFeedback.Text = "";

                // Tiempo según dificultad
                tiempoRestante = pregunta.Dificultad.ToLower() == "fácil" ? 20 :
                                 pregunta.Dificultad.ToLower() == "media" ? 15 : 10;

                temporizador.Start();
            }

           
        }

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            tiempoRestante--;

            lblFeedback.Text = $"Tiempo restante: {tiempoRestante}s";

            if (tiempoRestante <= 0)
            {
                temporizador.Stop();
                ProcesarRespuesta(-1); // -1 indica que se acabó el tiempo
            }
        }
        private void rdbRespuesta_CheckedChanged(object sender, EventArgs e)
        {
            if (!((System.Windows.Forms.RadioButton)sender).Checked) return;

            temporizador.Stop();

            int seleccion = rdbR1.Checked ? 0 : rdbR2.Checked ? 1 : 2;
            ProcesarRespuesta(seleccion);
        }

        private void ProcesarRespuesta(int seleccion)
        {
            Pregunta actual = preguntasActuales[indicePregunta];

            if (seleccion == actual.IndiceCorrecta)
            {
                correctas++;
                puntaje += 10;
                lblFeedback.Text = "¡Correcto!";
            }
            else if (seleccion == -1)
            {
                incorrectas++;
                lblFeedback.Text = "¡Tiempo agotado!";
            }
            else
            {
                incorrectas++;
                lblFeedback.Text = $"Incorrecto. Respuesta correcta: {actual.Opciones[actual.IndiceCorrecta]}";
            }

            lblCorrectas.Text = $"Correctas: {correctas}";
            lblIncorrectas.Text = $"Incorrectas: {incorrectas}";
            lblPuntaje.Text = $"Puntaje: {puntaje}";

            indicePregunta++;
            Timer siguiente = new Timer();
            siguiente.Interval = 1500;
            siguiente.Tick += (s, ev) =>
            {
                ((Timer)s).Stop();
                MostrarPreguntaActual();
            };
            siguiente.Start();
        }

        private void FinalizarJuego()
        {
            temporizador.Stop();
            txtPregunta.Text = "Juego terminado. ¡Gracias por jugar!";
            rdbR1.Visible = rdbR2.Visible = rdbR3.Visible = false;
            btnResponder.Visible = false;
            btnReiniciar.Visible = true;
            lblFeedback.Text = $"¡Tuviste {correctas} respuestas correctas de {preguntasActuales.Count}!";
            btnIniciar.Enabled = true;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            InicializarJuego();
            btnIniciar.Enabled = true;
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            // Verificar cuál RadioButton está seleccionado
            int respuestaSeleccionada = -1;

            if (rdbR1.Checked) respuestaSeleccionada = 0;
            else if (rdbR2.Checked) respuestaSeleccionada = 1;
            else if (rdbR3.Checked) respuestaSeleccionada = 2;

            if (respuestaSeleccionada == -1)
            {
                MessageBox.Show("Selecciona una respuesta antes de continuar.");
                return;
            }

            ProcesarRespuesta(respuestaSeleccionada);
        }
    }
}
