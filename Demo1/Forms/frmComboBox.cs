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
    public partial class frmComboBox : Form
    {
        public frmComboBox()
        {
            InitializeComponent();
            this.ActiveControl = txtNome;
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            string nuovoElemento = txtNome.Text.Trim();
            if (!string.IsNullOrEmpty(nuovoElemento))
            {
                cmbList.Items.Add(nuovoElemento);
                txtNome.Clear();
                txtNome.Focus();
            }
            else
            {
                MostraMessaggio("Il campo nome non può essere vuoto.", "Errore", MessageBoxIcon.Error);
                //MessageBox.Show("Il campo nome non può essere vuoto.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostraMessaggio(string testo, string titolo = "Informazione", MessageBoxIcon icona = MessageBoxIcon.Information)
        {
            MessageBox.Show(testo, titolo, MessageBoxButtons.OK, icona);
        }
    }
}
