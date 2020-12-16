using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_FINAL_WF
{
    public partial class Form2 : Form
    
    {

        double Disco1, Disco2;
        string operacion = "";
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            POP p;
            p = new POP();
            p.Nombre = "Album: Youngblood (Deluxe)";
            p.Canciones = "Canciones: 16  " ;
            MessageBox.Show(p.ToString());

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            KPOP k;
            k = new KPOP();
            k.Artista = "BTS " ;
            k.Nombre = "Album: BE";
            MessageBox.Show(k.ToString());
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            POP p;
            p = new POP();
            p.Nombre = " Album: The New Classic (Deluxe Version)";
            p.Canciones = "Canciones: 15  ";
            MessageBox.Show(p.ToString());
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            KPOP k;
            k = new KPOP();
            k.Artista = "BLACKPINK  ";
            k.Nombre = "Album: THE ALBUM";
            MessageBox.Show(k.ToString());
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            KPOP k;
            k = new KPOP();
            k.Artista = "BTS  ";
            k.Nombre = "Album: MAP OF THE SOUL : 7";
            MessageBox.Show(k.ToString());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            POP p;
            p = new POP();
            p.Nombre = "Album: WITNESS (Deluxe)";
            p.Canciones = "Canciones: 17";
            MessageBox.Show(p.ToString());
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            KPOP k;
            k = new KPOP();
            k.Artista = "EXO";
            k.Nombre = "Album: THE WAR - The 4th Album";
            MessageBox.Show(k.ToString());
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            POP p;
            p = new POP();
            p.Nombre = " Album: SIE7E";
            p.Canciones = "Canciones: 12  ";
            MessageBox.Show(p.ToString());
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            POP p;
            p = new POP();
            p.Nombre = "Album: Positions";
            p.Canciones ="Canciones: 14  " ;
            MessageBox.Show(p.ToString());
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            POP p;
            p = new POP();
            p.Nombre = "Album: MILLENNIUM";
            p.Canciones = "Canciones: 12  ";
            MessageBox.Show(p.ToString());
        }

        private void Mimetodo_Click(object sender, EventArgs e)
        {
            string textoBoton = ((Button)sender).Text;
            switch (textoBoton)
            {
         
                case "AGREGAR":
                    if (lblResultado.Text == "")
                    {
                        break;
                    }
                    operacion = textoBoton;
                    Disco1 = double.Parse(lblResultado.Text);
                    lblResultado.Text = "";
                    break;


                case "TOTAL":
                    if (lblResultado.Text == "")
                    {
                        break;
                    }
                    switch (operacion)
                    {
                        case "AGREGAR" +"":
                            Disco2 = double.Parse(lblResultado.Text);
                            lblResultado.Text = (Disco1 + Disco2) + "";
                            break;
                        
                    }
                    break;
                case "LIMPIAR":
                    lblResultado.Text = "";
                    break;
                
                default:
                    lblResultado.Text += textoBoton;
                    break;
            }
        }
    }

        }

