namespace Demo1
{
    partial class frnHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frnHome));
            lblNome = new Label();
            btnColore = new Button();
            panel1 = new Panel();
            btnSalva = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtCognome = new TextBox();
            txtNome = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(12, 9);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(144, 31);
            lblNome.TabIndex = 5;
            lblNome.Text = "Ciao mondo";
            // 
            // btnColore
            // 
            btnColore.Location = new Point(12, 43);
            btnColore.Name = "btnColore";
            btnColore.Size = new Size(208, 23);
            btnColore.TabIndex = 6;
            btnColore.Text = "Cambia Colore Lable";
            btnColore.UseVisualStyleBackColor = true;
            btnColore.Click += btnColore_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(btnSalva);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtCognome);
            panel1.Controls.Add(txtNome);
            panel1.Location = new Point(248, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(507, 410);
            panel1.TabIndex = 7;
            // 
            // btnSalva
            // 
            btnSalva.BackColor = Color.FromArgb(128, 255, 128);
            btnSalva.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalva.ForeColor = Color.White;
            btnSalva.Location = new Point(41, 253);
            btnSalva.Name = "btnSalva";
            btnSalva.Size = new Size(137, 32);
            btnSalva.TabIndex = 8;
            btnSalva.Text = "SALVA";
            btnSalva.UseVisualStyleBackColor = false;
            btnSalva.Click += btnSalva_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F);
            label4.Location = new Point(41, 197);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 7;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F);
            label3.Location = new Point(41, 152);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 6;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F);
            label2.Location = new Point(38, 105);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 5;
            label2.Text = "Cognome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F);
            label1.Location = new Point(39, 62);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 4;
            label1.Text = "Nome";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Arial Narrow", 12F);
            txtPassword.Location = new Point(107, 194);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Inserisci la Password";
            txtPassword.Size = new Size(320, 26);
            txtPassword.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial Narrow", 12F);
            txtEmail.Location = new Point(107, 149);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Inserisci l'indirizzo mail";
            txtEmail.Size = new Size(320, 26);
            txtEmail.TabIndex = 2;
            // 
            // txtCognome
            // 
            txtCognome.Font = new Font("Arial Narrow", 12F);
            txtCognome.Location = new Point(107, 102);
            txtCognome.Name = "txtCognome";
            txtCognome.PlaceholderText = "Inserisci tuo Cognome";
            txtCognome.Size = new Size(320, 26);
            txtCognome.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Arial Narrow", 12F);
            txtNome.Location = new Point(107, 59);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Inserisci tuo Nome ";
            txtNome.Size = new Size(320, 26);
            txtNome.TabIndex = 0;
            // 
            // frnHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(btnColore);
            Controls.Add(lblNome);
            Cursor = Cursors.Hand;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frnHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblNome;
        private Button btnColore;
        private Panel panel1;
        private TextBox txtCognome;
        private TextBox txtNome;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Button btnSalva;
    }
}
