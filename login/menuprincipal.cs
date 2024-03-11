using NuevoLogin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class menuprincipal : Form
    {
        Alumno[] alumnos;


        private string Usuario;
        public menuprincipal()
        {
            InitializeComponent();
            alumnos = new Alumno[10];
            carga();
        }

        private void carga()
        {
            alumnos[0] = new Alumno("Yanina ", "ponce ", 22222);
            alumnos[1] = new Alumno("Yan ", "po ", 223332);
            alumnos[2] = new Alumno("Yani ", "pon ", 55522);
            alumnos[3] = new Alumno("Yanin ", "ponc ", 772222);
            alumnos[4] = new Alumno("Yann ", "ponces ", 888222);

            
        }
        public menuprincipal(string nombreUsuario) : this()
        {
            Usuario = nombreUsuario;
        }

        private void menuprincipal_Load(object sender, EventArgs e)
        {
            this.label1.Text = "Bienvenido " + Usuario;

            for (int i = 0; i < alumnos.Length; i++)
            {
                if (alumnos[i] != null)
                {
                    this.richTextBox1.Text += alumnos[i].MostrarInfo() + '\n';
                }
            }
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            altaAlumno frmAltaAlumno = new altaAlumno();

            if (frmAltaAlumno.ShowDialog() == DialogResult.OK)
            {
                int posicionLibre = proximaPosicion();
                if (posicionLibre != -1)
                {
                    alumnos[posicionLibre] = frmAltaAlumno.GetAlumno();
                    this.richTextBox1.Text += frmAltaAlumno.GetAlumno().MostrarInfo() + '\n';

                }
                else
                {
                    MessageBox.Show("no hay mas lugar");
                }

            }
            else
            {
                MessageBox.Show("carga cancelada");
            }
        }

        private int proximaPosicion()
        {
            for (int i = 0; i < alumnos.Length; i++)
            {
                if (alumnos[i] == null)
                    return i;
            }
            return -1;
        }
    }
}
