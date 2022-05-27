using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double Jugadores;
        string Jugador1, Jugador2, Jugador3, Jugador4, Jugador5, Jugador6, Jugador7;
        ClaseTurista Turista;
        public Form1()
        {
            InitializeComponent();
            Turista = new ClaseTurista();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entrada();
            if(Jugadores== 2) { 
            Form2 f = new Form2();
             //ClaseTurista.Jug1 = textBoxJ1.Text;
             //ClaseTurista.Jug2 = textBoxJ2.Text;
                AddFormulario(f);
            


            }
            else
            {
                MessageBox.Show("Error de datos");
            }
        }
        public void AddFormulario(Form f)
        {

            if (this.panel1.Controls.Count > 0)
            {
                this.panel1.Controls.RemoveAt(0);
            }

            f.TopLevel = false;
            this.panel1.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.Show();
        }
        public void Entrada()
        {
            try
            {
                Jugadores = double.Parse(textBoxJugadores.Text);
                Jugador1 = textBoxJ1.Text;
                Jugador2 = textBoxJ2.Text;
                Jugador3 = textBoxJ3.Text;
                Jugador4 = textBoxJ4.Text;
                Jugador5 = textBoxJ5.Text;
                Jugador6 = textBoxJ6.Text;
                Jugador7 = textBoxJ7.Text;
                ClaseTurista.Jug1 = textBoxJ1.Text;
                ClaseTurista.Jug2 = textBoxJ2.Text;


            }
            catch
            {
                MessageBox.Show("Error de datos");
            }
        }
        
    }
}
