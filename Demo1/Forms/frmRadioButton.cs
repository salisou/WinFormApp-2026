using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo1.Forms
{
    public partial class frmRadioButton : Form
    {
        public frmRadioButton()
        {
            InitializeComponent();
            this.ActiveControl = txtNome;
        }

        void MostraMessaggio(string testo, string titolo = "Info", MessageBoxIcon icona = MessageBoxIcon.Information)
        {
            MessageBox.Show(testo, titolo, MessageBoxButtons.OK, icona);
        }
        private void frmRadioButton_Load(object sender, EventArgs e)
        {
            txtNome.Focus();

            ddgLista.ColumnCount = 2;
            ddgLista.Columns[0].Name = "Nome";
            ddgLista.Columns[1].Name = "Sesso";
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();

            // Il Controllo del nome
            if (string.IsNullOrEmpty(nome))
            {
                MostraMessaggio("Inserisci il Nome.", "Errore", MessageBoxIcon.Error);
                txtNome.Focus();
                return;
            }

            // Controllo il Sesso
            string sesso = string.Empty;

            if (rdbMaschio.Checked)
            {
                sesso = "Maschio";
            }
            else if (rdbFemmina.Checked)
            {
                sesso = "Femmina";
            }
            else
            {
                MostraMessaggio("Seleziona il Sesso.", "Errore", MessageBoxIcon.Warning);
                return;
            }

            // Aggiungo i dati alla DataGridView
            ddgLista.Rows.Add(nome, sesso);
            MostraMessaggio("Dati salvati con successo!", "Successo", MessageBoxIcon.Information);
            // Output finale
            //MostraMessaggio($"Nome: {nome}\nSesso: {sesso}\n", "Salvataggio riuscito con successo 😅");

            // Reset dei campi
            ResetCampi();
        }

        private void ResetCampi()
        {
            txtNome.Clear();
            rdbMaschio.Checked = false;
            rdbFemmina.Checked = false;
            txtNome.Focus();
        }
    }
}
