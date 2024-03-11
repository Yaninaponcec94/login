namespace login
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }        

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = this.textBox2.Text.ToLower();
            if (usuario == "pepe" && this.textBox1.Text == "Rufoso")
            {
                menuprincipal formMenuPrincipal = new menuprincipal(usuario);
                formMenuPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario incorrecto");
            }
        }
    }
}