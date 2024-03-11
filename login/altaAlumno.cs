using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NuevoLogin
{
    public partial class altaAlumno : Form
    {

        Alumno aux;

        public altaAlumno()
        {
            InitializeComponent();
        }


        public Alumno GetAlumno()
        {
            return aux;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string nomb = this.textBox1.Text;
            string apell = this.textBox2.Text;
            int.TryParse(this.textBox3.Text, out int numdni);
            int.TryParse(this.textBox4.Text, out int telef);
            string direcc = this.textBox5.Text;

            if(string.IsNullOrEmpty(direcc) && telef > 0)
            {
                aux = new Alumno(nomb, apell, numdni);
            }
            else if (string.IsNullOrEmpty(direcc))
            {
                // Caso 2: Se ingresaron nombre, apellido, DNI y teléfono
                aux = new Alumno(nomb, apell, numdni, telef, string.Empty);
            }
            else if (telef == 0)
            {
                // Caso 3: Se ingresaron nombre, apellido, DNI y dirección
                aux = new Alumno(nomb, apell, numdni, 0, direcc);
            }
            else
            {
                aux = new Alumno(nomb, apell, numdni, telef, direcc);
            }

            this.DialogResult = DialogResult.OK;

        }

  
    }
}
