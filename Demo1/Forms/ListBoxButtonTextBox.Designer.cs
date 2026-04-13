namespace Demo1.Forms
{
    partial class ListBoxButtonTextBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            listTask = new ListBox();
            label1 = new Label();
            txtTask = new TextBox();
            btnSalva = new Button();
            btnModifica = new Button();
            btnElimina = new Button();
            pictureBox1 = new PictureBox();
            listBox1 = new ListBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOliveGreen;
            panel1.Controls.Add(listTask);
            panel1.Location = new Point(123, 97);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(339, 452);
            panel1.TabIndex = 0;
            // 
            // listTask
            // 
            listTask.FormattingEnabled = true;
            listTask.Location = new Point(9, 11);
            listTask.Margin = new Padding(3, 4, 3, 4);
            listTask.Name = "listTask";
            listTask.Size = new Size(324, 424);
            listTask.TabIndex = 0;
            listTask.SelectedIndexChanged += listTask_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(182, 12);
            label1.Name = "label1";
            label1.Size = new Size(152, 41);
            label1.TabIndex = 1;
            label1.Text = "ToDo-List";
            // 
            // txtTask
            // 
            txtTask.Location = new Point(125, 64);
            txtTask.Margin = new Padding(3, 4, 3, 4);
            txtTask.Name = "txtTask";
            txtTask.Size = new Size(339, 27);
            txtTask.TabIndex = 3;
            // 
            // btnSalva
            // 
            btnSalva.Location = new Point(19, 136);
            btnSalva.Margin = new Padding(3, 4, 3, 4);
            btnSalva.Name = "btnSalva";
            btnSalva.Size = new Size(93, 37);
            btnSalva.TabIndex = 4;
            btnSalva.Text = "Salva";
            btnSalva.UseVisualStyleBackColor = true;
            btnSalva.Click += btnSalva_Click;
            // 
            // btnModifica
            // 
            btnModifica.Location = new Point(19, 200);
            btnModifica.Margin = new Padding(3, 4, 3, 4);
            btnModifica.Name = "btnModifica";
            btnModifica.Size = new Size(93, 37);
            btnModifica.TabIndex = 5;
            btnModifica.Text = "Modifica";
            btnModifica.UseVisualStyleBackColor = true;
            btnModifica.Click += btnModifica_Click;
            // 
            // btnElimina
            // 
            btnElimina.Location = new Point(19, 264);
            btnElimina.Margin = new Padding(3, 4, 3, 4);
            btnElimina.Name = "btnElimina";
            btnElimina.Size = new Size(93, 37);
            btnElimina.TabIndex = 6;
            btnElimina.Text = "Elimina";
            btnElimina.UseVisualStyleBackColor = true;
            btnElimina.Click += btnElimina_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.close;
            pictureBox1.Location = new Point(446, 12);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(18, 21);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(592, 97);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(248, 304);
            listBox1.TabIndex = 8;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // ListBoxButtonTextBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1061, 560);
            Controls.Add(listBox1);
            Controls.Add(pictureBox1);
            Controls.Add(btnElimina);
            Controls.Add(btnModifica);
            Controls.Add(btnSalva);
            Controls.Add(txtTask);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ListBoxButtonTextBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListBoxButtonTextBox";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ListBox listTask;
        private TextBox txtTask;
        private Button btnSalva;
        private Button btnModifica;
        private Button btnElimina;
        private PictureBox pictureBox1;
        private ListBox listBox1;
    }
}