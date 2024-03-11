using System;
using System.Windows.Forms;
using Entidades;

namespace AltaYEnum
{
    public partial class Alta : Form
    {
        Jugador jugadorCreado;

        public Jugador jugador
        {
            get
            {
                return jugadorCreado;
            }
        }
        public Alta()
        {
            InitializeComponent();
        }

        private void Alta_Load(object sender, EventArgs e)
        {
            this.comboBox1.DataSource = Enum.GetValues(typeof(EPosicion));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //importantisimo: cuando hago un combobox con enumerados, que es la forma correcta, y necesito recuperar los datos que seleccione
            //en ese combo box, utilizo la siguiente oracion:

            EPosicion posSeleccionada = (EPosicion)this.comboBox1.SelectedItem;
            
            //y despues cuando instancio mi objeto, le paso los datos que recupere del combobox:
            jugadorCreado = new Jugador("pepe", posSeleccionada, 4, 22, "argentino");

            string nombreJugar = jugadorCreado.Nombre;
        }
    }
}