namespace JuegoPreguntas
{
    partial class frmJuego
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDificultad = new System.Windows.Forms.ComboBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPregunta = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.rdbR1 = new System.Windows.Forms.RadioButton();
            this.rdbR3 = new System.Windows.Forms.RadioButton();
            this.rdbR2 = new System.Windows.Forms.RadioButton();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.lblTiempoRestante = new System.Windows.Forms.Label();
            this.prgbTiempo = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.lblIncorrectas = new System.Windows.Forms.Label();
            this.lblCorrectas = new System.Windows.Forms.Label();
            this.btnResponder = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(409, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trivia Pro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Elige la categoría";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(146, 68);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(201, 24);
            this.cmbCategoria.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Elige la dificultad";
            // 
            // cmbDificultad
            // 
            this.cmbDificultad.FormattingEnabled = true;
            this.cmbDificultad.Location = new System.Drawing.Point(562, 68);
            this.cmbDificultad.Name = "cmbDificultad";
            this.cmbDificultad.Size = new System.Drawing.Size(201, 24);
            this.cmbDificultad.TabIndex = 4;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(365, 120);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(123, 38);
            this.btnIniciar.TabIndex = 5;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Pregunta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Respuestas";
            // 
            // txtPregunta
            // 
            this.txtPregunta.Location = new System.Drawing.Point(42, 285);
            this.txtPregunta.Multiline = true;
            this.txtPregunta.Name = "txtPregunta";
            this.txtPregunta.ReadOnly = true;
            this.txtPregunta.Size = new System.Drawing.Size(446, 51);
            this.txtPregunta.TabIndex = 10;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(543, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "---------------------------------------------------------------------------------" +
    "-----------------------------------------------------";
            // 
            // rdbR1
            // 
            this.rdbR1.AutoSize = true;
            this.rdbR1.Location = new System.Drawing.Point(42, 409);
            this.rdbR1.Name = "rdbR1";
            this.rdbR1.Size = new System.Drawing.Size(37, 20);
            this.rdbR1.TabIndex = 18;
            this.rdbR1.TabStop = true;
            this.rdbR1.Text = "...";
            this.rdbR1.UseVisualStyleBackColor = true;
            // 
            // rdbR3
            // 
            this.rdbR3.AutoSize = true;
            this.rdbR3.Location = new System.Drawing.Point(42, 481);
            this.rdbR3.Name = "rdbR3";
            this.rdbR3.Size = new System.Drawing.Size(37, 20);
            this.rdbR3.TabIndex = 19;
            this.rdbR3.TabStop = true;
            this.rdbR3.Text = "...";
            this.rdbR3.UseVisualStyleBackColor = true;
            // 
            // rdbR2
            // 
            this.rdbR2.AutoSize = true;
            this.rdbR2.Location = new System.Drawing.Point(42, 444);
            this.rdbR2.Name = "rdbR2";
            this.rdbR2.Size = new System.Drawing.Size(37, 20);
            this.rdbR2.TabIndex = 20;
            this.rdbR2.TabStop = true;
            this.rdbR2.Text = "...";
            this.rdbR2.UseVisualStyleBackColor = true;
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Location = new System.Drawing.Point(31, 565);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(69, 16);
            this.lblFeedback.TabIndex = 22;
            this.lblFeedback.Text = "Feedback";
            // 
            // lblTiempoRestante
            // 
            this.lblTiempoRestante.AutoSize = true;
            this.lblTiempoRestante.ForeColor = System.Drawing.Color.IndianRed;
            this.lblTiempoRestante.Location = new System.Drawing.Point(303, 249);
            this.lblTiempoRestante.Name = "lblTiempoRestante";
            this.lblTiempoRestante.Size = new System.Drawing.Size(54, 16);
            this.lblTiempoRestante.TabIndex = 23;
            this.lblTiempoRestante.Text = "Tiempo";
            // 
            // prgbTiempo
            // 
            this.prgbTiempo.Location = new System.Drawing.Point(411, 249);
            this.prgbTiempo.Name = "prgbTiempo";
            this.prgbTiempo.Size = new System.Drawing.Size(195, 19);
            this.prgbTiempo.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReiniciar);
            this.groupBox1.Controls.Add(this.lblPuntaje);
            this.groupBox1.Controls.Add(this.lblIncorrectas);
            this.groupBox1.Controls.Add(this.lblCorrectas);
            this.groupBox1.Location = new System.Drawing.Point(527, 388);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 228);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultados";
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(35, 163);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(114, 30);
            this.btnReiniciar.TabIndex = 3;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.Location = new System.Drawing.Point(26, 121);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(52, 16);
            this.lblPuntaje.TabIndex = 2;
            this.lblPuntaje.Text = "Puntaje";
            // 
            // lblIncorrectas
            // 
            this.lblIncorrectas.AutoSize = true;
            this.lblIncorrectas.Location = new System.Drawing.Point(25, 80);
            this.lblIncorrectas.Name = "lblIncorrectas";
            this.lblIncorrectas.Size = new System.Drawing.Size(73, 16);
            this.lblIncorrectas.TabIndex = 1;
            this.lblIncorrectas.Text = "Incorrectas";
            // 
            // lblCorrectas
            // 
            this.lblCorrectas.AutoSize = true;
            this.lblCorrectas.Location = new System.Drawing.Point(25, 41);
            this.lblCorrectas.Name = "lblCorrectas";
            this.lblCorrectas.Size = new System.Drawing.Size(65, 16);
            this.lblCorrectas.TabIndex = 0;
            this.lblCorrectas.Text = "Correctas";
            // 
            // btnResponder
            // 
            this.btnResponder.Location = new System.Drawing.Point(48, 518);
            this.btnResponder.Name = "btnResponder";
            this.btnResponder.Size = new System.Drawing.Size(120, 30);
            this.btnResponder.TabIndex = 26;
            this.btnResponder.Text = "Responder";
            this.btnResponder.UseVisualStyleBackColor = true;
            this.btnResponder.Visible = false;
            this.btnResponder.Click += new System.EventHandler(this.btnResponder_Click);
            // 
            // frmJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 661);
            this.Controls.Add(this.btnResponder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.prgbTiempo);
            this.Controls.Add(this.lblTiempoRestante);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rdbR2);
            this.Controls.Add(this.rdbR3);
            this.Controls.Add(this.rdbR1);
            this.Controls.Add(this.txtPregunta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.cmbDificultad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmJuego";
            this.Text = "Trivia Pro";
            this.Load += new System.EventHandler(this.frmJuego_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDificultad;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPregunta;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdbR1;
        private System.Windows.Forms.RadioButton rdbR3;
        private System.Windows.Forms.RadioButton rdbR2;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Label lblTiempoRestante;
        private System.Windows.Forms.ProgressBar prgbTiempo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.Label lblIncorrectas;
        private System.Windows.Forms.Label lblCorrectas;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnResponder;
    }
}

