namespace Demo1.Forms
{
    partial class frmComboBox
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
            cmbList = new ComboBox();
            txtNome = new TextBox();
            btnAggiungi = new Button();
            SuspendLayout();
            // 
            // cmbList
            // 
            cmbList.FormattingEnabled = true;
            cmbList.Location = new Point(513, 96);
            cmbList.Name = "cmbList";
            cmbList.Size = new Size(262, 28);
            cmbList.TabIndex = 0;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 12);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(269, 27);
            txtNome.TabIndex = 1;
            // 
            // btnAggiungi
            // 
            btnAggiungi.Location = new Point(25, 373);
            btnAggiungi.Name = "btnAggiungi";
            btnAggiungi.Size = new Size(186, 29);
            btnAggiungi.TabIndex = 2;
            btnAggiungi.Text = "Aggiungi";
            btnAggiungi.UseVisualStyleBackColor = true;
            btnAggiungi.Click += btnAggiungi_Click;
            // 
            // frmComboBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAggiungi);
            Controls.Add(txtNome);
            Controls.Add(cmbList);
            Name = "frmComboBox";
            Text = "frmComboBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbList;
        private TextBox txtNome;
        private Button btnAggiungi;
    }
}