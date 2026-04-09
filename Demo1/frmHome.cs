namespace Demo1
{
    public partial class frnHome : Form
    {
        public frnHome()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            lblNome.Text = "Ciao Concetta!😉";
        }

        private void btnColore_Click(object sender, EventArgs e)
        {
            lblNome.ForeColor = Color.Red;
            LoadData();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cognome = txtCognome.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;


            MessageBox.Show("Dati salvati:\n" +
                "Nome: " + nome + 
                "\nCognome: " + cognome + 
                "\nEmail: " + email);
        }
    }
}
