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
            // Controlla se è stato selezionato un elemento
            if (listTask.SelectedIndex != -1)
            {
                if (txtTask.Text != string.Empty)
                {
                    // Sostituisce il valore selezionato con il nuovo testo
                    listTask.Items[listTask.SelectedIndex] = txtTask.Text;

                    txtTask.Clear();
                    txtTask.Focus();
                }
                else
                {
                    MessageBox.Show("Inserisci un nuovo testo per modificare il task");
                }
            }
            else
            {
                MessageBox.Show("Seleziona un task da modificare");
            }
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            if (listTask.SelectedIndex != -1)
            {
                listTask.Items.RemoveAt(listTask.SelectedIndex);
                txtTask.Clear();
                txtTask.Focus();
            }
            else
            {
                MessageBox.Show("Seleziona un task da eliminare");
            }
        }

        private void listTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listTask.SelectedIndex != -1)
            {
                txtTask.Text = listTask.SelectedItem!.ToString();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listTask.SelectedIndex != -1)
            {
                txtTask.Text = listTask.SelectedItem.ToString();
            }
        }
    }
}
