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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOliveGreen;
            panel1.Controls.Add(listTask);
            panel1.Location = new Point(108, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(297, 339);
            panel1.TabIndex = 0;
            // 
            // listTask
            // 
            listTask.FormattingEnabled = true;
            listTask.ItemHeight = 15;
            listTask.Location = new Point(8, 8);
            listTask.Name = "listTask";
            listTask.Size = new Size(284, 319);
            listTask.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(159, 9);
            label1.Name = "label1";
            label1.Size = new Size(123, 32);
            label1.TabIndex = 1;
            label1.Text = "ToDo-List";
            // 
            // txtTask
            // 
            txtTask.Location = new Point(109, 48);
            txtTask.Name = "txtTask";
            txtTask.Size = new Size(297, 23);
            txtTask.TabIndex = 3;
            // 
            // btnSalva
            // 
            btnSalva.Location = new Point(17, 102);
            btnSalva.Name = "btnSalva";
            btnSalva.Size = new Size(81, 28);
            btnSalva.TabIndex = 4;
            btnSalva.Text = "Salva";
            btnSalva.UseVisualStyleBackColor = true;
            btnSalva.Click += btnSalva_Click;
            // 
            // btnModifica
            // 
            btnModifica.Location = new Point(17, 150);
            btnModifica.Name = "btnModifica";
            btnModifica.Size = new Size(81, 28);
            btnModifica.TabIndex = 5;
            btnModifica.Text = "Modifica";
            btnModifica.UseVisualStyleBackColor = true;
            btnModifica.Click += btnModifica_Click;
            // 
            // btnElimina
            // 
            btnElimina.Location = new Point(17, 198);
            btnElimina.Name = "btnElimina";
            btnElimina.Size = new Size(81, 28);
            btnElimina.TabIndex = 6;
            btnElimina.Text = "Elimina";
            btnElimina.UseVisualStyleBackColor = true;
            btnElimina.Click += btnElimina_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.close;
            pictureBox1.Location = new Point(390, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(16, 16);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // ListBoxButtonTextBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(413, 420);
            Controls.Add(pictureBox1);
            Controls.Add(btnElimina);
            Controls.Add(btnModifica);
            Controls.Add(btnSalva);
            Controls.Add(txtTask);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
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
    }
}