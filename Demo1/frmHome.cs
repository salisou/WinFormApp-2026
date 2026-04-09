using System.IO; //-> per leggere e scrivere file
using System.Text;
using OfficeOpenXml;



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

            // Commentio: Qui potresti aggiungere la logica per salvare i dati, ad esempio in un database o in un file.
            SalvaDati();

            //MessageBox.Show("Dati salvati:\n" +
            //    "Nome: " + nome + 
            //    "\nCognome: " + cognome + 
            //    "\nEmail: " + email);
        }

        private void SalvaDati()
        {
            string fileName = @"C:\Users\salis\Desktop\CorsoCsharp\WinFormApp\Demo1\Data\utenti.xlsx";
            FileInfo file = new(fileName);

            using (ExcelPackage package = new(file))
            {
                ExcelWorksheet? spazioLavoro;
                if (package.Workbook.Worksheets.Count == 0)
                {
                    spazioLavoro = package.Workbook.Worksheets.Add("Utente");
                }
                else
                {
                    spazioLavoro = package.Workbook.Worksheets[0];
                }

                // Trovo la prima riga libera (row  = la numero di riga usata)
                int row = spazioLavoro.Dimension?.Rows + 1 ?? 1; //contine dimenzione del foglio di lavoro, se è null allora row sarà 1

                if(row == 1)
                {
                    spazioLavoro.Cells[1, 1].Value = "Nome";
                    spazioLavoro.Cells[1, 2].Value = "Cognome";
                    spazioLavoro.Cells[1, 3].Value = "Email";
                    spazioLavoro.Cells[1, 4].Value = "Password";

                    row++;
                    //row = row + 1; //incremento row per posizionarmi sulla riga successiva
                }

                spazioLavoro.Cells[row, 1].Value = txtNome.Text;
                spazioLavoro.Cells[row, 2].Value = txtCognome.Text;
                spazioLavoro.Cells[row, 3].Value = txtEmail.Text;
                spazioLavoro.Cells[row, 4].Value = txtPassword.Text;

                package.Save();
            }
            MessageBox.Show("Dati salvati con successo!");
        }
    }
}
