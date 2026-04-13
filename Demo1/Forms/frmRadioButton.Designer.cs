namespace Demo1.Forms
{
    partial class frmRadioButton
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
            label1 = new Label();
            txtNome = new TextBox();
            panel1 = new Panel();
            label2 = new Label();
            rdbFemmina = new RadioButton();
            rdbMaschio = new RadioButton();
            btnSalva = new Button();
            ddgLista = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ddgLista).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 18);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(32, 50);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Inserisci il nome...";
            txtNome.Size = new Size(257, 27);
            txtNome.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(rdbFemmina);
            panel1.Controls.Add(rdbMaschio);
            panel1.Location = new Point(467, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(158, 65);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 2;
            label2.Text = "Genere";
            // 
            // rdbFemmina
            // 
            rdbFemmina.AutoSize = true;
            rdbFemmina.Location = new Point(96, 35);
            rdbFemmina.Name = "rdbFemmina";
            rdbFemmina.Size = new Size(37, 24);
            rdbFemmina.TabIndex = 1;
            rdbFemmina.TabStop = true;
            rdbFemmina.Text = "F";
            rdbFemmina.UseVisualStyleBackColor = true;
            // 
            // rdbMaschio
            // 
            rdbMaschio.AutoSize = true;
            rdbMaschio.Location = new Point(3, 35);
            rdbMaschio.Name = "rdbMaschio";
            rdbMaschio.Size = new Size(43, 24);
            rdbMaschio.TabIndex = 0;
            rdbMaschio.TabStop = true;
            rdbMaschio.Text = "M";
            rdbMaschio.UseVisualStyleBackColor = true;
            // 
            // btnSalva
            // 
            btnSalva.Location = new Point(32, 289);
            btnSalva.Name = "btnSalva";
            btnSalva.Size = new Size(155, 40);
            btnSalva.TabIndex = 3;
            btnSalva.Text = "Salva";
            btnSalva.UseVisualStyleBackColor = true;
            btnSalva.Click += btnSalva_Click;
            // 
            // ddgLista
            // 
            ddgLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ddgLista.Location = new Point(31, 335);
            ddgLista.Name = "ddgLista";
            ddgLista.RowHeadersWidth = 51;
            ddgLista.Size = new Size(594, 289);
            ddgLista.TabIndex = 4;
            // 
            // frmRadioButton
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(637, 638);
            Controls.Add(ddgLista);
            Controls.Add(btnSalva);
            Controls.Add(panel1);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Name = "frmRadioButton";
            Text = "frmRadioButton";
            Load += frmRadioButton_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ddgLista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private Panel panel1;
        private Label label2;
        private RadioButton rdbFemmina;
        private RadioButton rdbMaschio;
        private Button btnSalva;
        private DataGridView ddgLista;
    }
}