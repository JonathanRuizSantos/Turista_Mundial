using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;


namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        //ClaseTurista Turista;
        string n;
        public Form2()
        {
       
            InitializeComponent();
           // Turista = new ClaseTurista();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBoxSalida_TextChanged(object sender, EventArgs e)
        {

        }
        public void Jugadores(string Jugador1, string Jugador2, string Jugador3, string Jugador4, string Jugador5, string Jugador6, string Jugador7)
        {

            //textBox1.Text = ClaseTurista.Jug1;
            //J1 = Turista.Salida(Jugador1, Jugador2, Jugador3, Jugador4, Jugador5, Jugador6, Jugador7);
            // textBox1.Text = J1;
            // listBoxPJ1.Items.Add("sdfasdf");
            //listBoxPJ1.Items.Add(r);
            //textBoxmensaje.Text = men;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ClaseTurista.Jug1 == "Jhon"){

                //listBoxPJ1.Items.Add("Avanza 4");
                //MessageBox.Show("Ya soy ganador con jug 1");
                try{
                 textBoxSalida.ReadOnly = true;
                 textBoxSalida.Text = "Avanza 4";
                 textBoxSalida.Text = "Avanza 2";
                }
                catch
                {
                    MessageBox.Show("Error");
                }

            }
            else if(ClaseTurista.Jug2=="Jhon"){
                MessageBox.Show("Ya soy ganador con jug 2");

            }
            else
            {
                MessageBox.Show("Ninguno de los dos es Jhon");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = ClaseTurista.Jug1;
            textBox2.Text = ClaseTurista.Jug2;
            textBoxSalida.Text = "Mi creador es un crack";
        }
    }
}
