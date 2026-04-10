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
    public partial class ListBoxButtonTextBox : Form
    {
        public ListBoxButtonTextBox()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (txtTask.Text != string.Empty)
            {
                listTask.Items.Add(txtTask.Text);
                txtTask.Clear();
                // Focus() serve per posizionare il cursore all'interno della TextBox dopo averla svuotata
                txtTask.Focus();
            }
            else
            {
                MessageBox.Show("Inserisci un task");
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            Modificatask();
        }

        private void Modificatask()
        {
            // Cpontrolla se è stato selezionato un elemento nella ListBox
            if (listTask.SelectedIndex != -1)
            {

            }

            //listTask.SelectedIndex != -1
            // Recupero l'indice dell'elemento selezionato nella ListBox
            //Salvare la modifica del task
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            var vlaue = listTask.SelectedIndex;
            listTask.Items.RemoveAt(vlaue);
        }
    }
}
