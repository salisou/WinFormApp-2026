// Namespace per lavorare con file (creazione, lettura, scrittura)
using System.IO;

// Namespace per lavorare con stringhe avanzate (non usato molto qui, ma utile)
using System.Text;

// Libreria EPPlus per gestire file Excel (.xlsx)
using OfficeOpenXml;


// Namespace del progetto
namespace Demo1
{
    // Classe del form (interfaccia grafica)
    public partial class frnHome : Form
    {
        // Costruttore del form (viene eseguito all'avvio)
        public frnHome()
        {
            InitializeComponent(); // Inizializza tutti i controlli grafici (TextBox, Button, Label, ecc.)
        }

        // Metodo che modifica il contenuto della label
        private void LoadData()
        {
            lblNome.Text = "Ciao Concetta!😉"; // Cambia il testo della label
        }

        // Evento click del bottone "Colore"
        private void btnColore_Click(object sender, EventArgs e)
        {
            lblNome.ForeColor = Color.Red; // Cambia il colore del testo della label in rosso

            LoadData(); // Chiama il metodo che cambia il testo
        }

        // Evento click del bottone "Salva"
        private void btnSalva_Click(object sender, EventArgs e)
        {
            // Leggo i dati inseriti nei TextBox
            string nome = txtNome.Text;
            string cognome = txtCognome.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            // Qui potresti usare queste variabili (es. controlli o validazioni)

            SalvaDati(); // Chiamo il metodo che salva su Excel

            // Questo codice è commentato (non viene eseguito)
            // Mostrava i dati inseriti
            /*
            MessageBox.Show("Dati salvati:\n" +
                "Nome: " + nome + 
                "\nCognome: " + cognome + 
                "\nEmail: " + email);
            */
        }

        // Metodo che salva i dati nel file Excel
        private void SalvaDati()
        {
            // Percorso ASSOLUTO del file Excel
            string fileName = @"C:\Users\salis\Desktop\CorsoCsharp\WinFormApp\Demo1\Data\utenti.xlsx";

            // Creo un oggetto FileInfo che rappresenta il file
            FileInfo file = new(fileName);

            // Apro o creo il file Excel
            using (ExcelPackage package = new(file))
            {
                // Variabile che rappresenta il foglio di lavoro (worksheet)
                ExcelWorksheet? spazioLavoro;

                // Se non esistono fogli nel file
                if (package.Workbook.Worksheets.Count == 0)
                {
                    // Creo un nuovo foglio chiamato "Utente"
                    spazioLavoro = package.Workbook.Worksheets.Add("Utente");
                }
                else
                {
                    // Se esiste già, uso il primo foglio
                    spazioLavoro = package.Workbook.Worksheets[0];
                }

                // Trovo la prima riga libera
                // - Dimension contiene il numero di righe usate
                // - Se è null (file vuoto), parto da 1
                int row = spazioLavoro.Dimension?.Rows + 1 ?? 1;

                // Se siamo alla prima riga → file vuoto
                if (row == 1)
                {
                    // Scrivo le intestazioni delle colonne
                    spazioLavoro.Cells[1, 1].Value = "Nome";
                    spazioLavoro.Cells[1, 2].Value = "Cognome";
                    spazioLavoro.Cells[1, 3].Value = "Email";
                    spazioLavoro.Cells[1, 4].Value = "Password";

                    row++; // Passo alla riga successiva per inserire i dati
                }

                // Scrivo i dati nelle celle Excel
                spazioLavoro.Cells[row, 1].Value = txtNome.Text;      // Colonna Nome
                spazioLavoro.Cells[row, 2].Value = txtCognome.Text;   // Colonna Cognome
                spazioLavoro.Cells[row, 3].Value = txtEmail.Text;     // Colonna Email
                spazioLavoro.Cells[row, 4].Value = txtPassword.Text;  // ⚠ Password (non sicuro)

                // Salvo il file Excel
                package.Save();
            }

            // Mostro un messaggio all'utente
            MessageBox.Show("Dati salvati con successo!");
        }
    }
}