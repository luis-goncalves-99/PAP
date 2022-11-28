namespace PAP
{
    partial class frmFichaUtente
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
            this.txtId_Utente = new System.Windows.Forms.TextBox();
            this.lblIdUtente = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtMorada = new System.Windows.Forms.TextBox();
            this.txtCod_Postal = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.cbbSocio = new System.Windows.Forms.ComboBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblSocio = new System.Windows.Forms.Label();
            this.lblMorada = new System.Windows.Forms.Label();
            this.lblCod_Postal = new System.Windows.Forms.Label();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSeguinte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtId_Utente
            // 
            this.txtId_Utente.Location = new System.Drawing.Point(39, 12);
            this.txtId_Utente.Name = "txtId_Utente";
            this.txtId_Utente.ReadOnly = true;
            this.txtId_Utente.Size = new System.Drawing.Size(27, 20);
            this.txtId_Utente.TabIndex = 0;
            // 
            // lblIdUtente
            // 
            this.lblIdUtente.AutoSize = true;
            this.lblIdUtente.Location = new System.Drawing.Point(14, 15);
            this.lblIdUtente.Name = "lblIdUtente";
            this.lblIdUtente.Size = new System.Drawing.Size(19, 13);
            this.lblIdUtente.TabIndex = 1;
            this.lblIdUtente.Text = "Id:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNome.Location = new System.Drawing.Point(77, 15);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(121, 12);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(211, 20);
            this.txtnome.TabIndex = 3;
            this.txtnome.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtnome_MouseDoubleClick);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(72, 234);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 26);
            this.btnConfirmar.TabIndex = 4;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(121, 52);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(211, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(202, 92);
            this.txtTelefone.MaxLength = 9;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(83, 20);
            this.txtTelefone.TabIndex = 6;
            this.txtTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefone_KeyPress);
            // 
            // txtMorada
            // 
            this.txtMorada.Location = new System.Drawing.Point(121, 147);
            this.txtMorada.Name = "txtMorada";
            this.txtMorada.Size = new System.Drawing.Size(211, 20);
            this.txtMorada.TabIndex = 7;
            // 
            // txtCod_Postal
            // 
            this.txtCod_Postal.Location = new System.Drawing.Point(139, 189);
            this.txtCod_Postal.MaxLength = 8;
            this.txtCod_Postal.Name = "txtCod_Postal";
            this.txtCod_Postal.Size = new System.Drawing.Size(77, 20);
            this.txtCod_Postal.TabIndex = 8;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(80, 55);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email:";
            // 
            // cbbSocio
            // 
            this.cbbSocio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSocio.FormattingEnabled = true;
            this.cbbSocio.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cbbSocio.Location = new System.Drawing.Point(72, 91);
            this.cbbSocio.Name = "cbbSocio";
            this.cbbSocio.Size = new System.Drawing.Size(58, 21);
            this.cbbSocio.TabIndex = 11;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(144, 95);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 12;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblSocio
            // 
            this.lblSocio.AutoSize = true;
            this.lblSocio.Location = new System.Drawing.Point(32, 95);
            this.lblSocio.Name = "lblSocio";
            this.lblSocio.Size = new System.Drawing.Size(34, 13);
            this.lblSocio.TabIndex = 13;
            this.lblSocio.Text = "Socio";
            // 
            // lblMorada
            // 
            this.lblMorada.AutoSize = true;
            this.lblMorada.Location = new System.Drawing.Point(69, 150);
            this.lblMorada.Name = "lblMorada";
            this.lblMorada.Size = new System.Drawing.Size(46, 13);
            this.lblMorada.TabIndex = 14;
            this.lblMorada.Text = "Morada:";
            // 
            // lblCod_Postal
            // 
            this.lblCod_Postal.AutoSize = true;
            this.lblCod_Postal.Location = new System.Drawing.Point(69, 192);
            this.lblCod_Postal.Name = "lblCod_Postal";
            this.lblCod_Postal.Size = new System.Drawing.Size(64, 13);
            this.lblCod_Postal.TabIndex = 15;
            this.lblCod_Postal.Text = "Cod_Postal:";
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(153, 234);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 26);
            this.btnApagar.TabIndex = 16;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(234, 234);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(53, 26);
            this.btnAnterior.TabIndex = 17;
            this.btnAnterior.Text = "<-";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSeguinte
            // 
            this.btnSeguinte.Location = new System.Drawing.Point(293, 234);
            this.btnSeguinte.Name = "btnSeguinte";
            this.btnSeguinte.Size = new System.Drawing.Size(53, 26);
            this.btnSeguinte.TabIndex = 18;
            this.btnSeguinte.Text = "->";
            this.btnSeguinte.UseVisualStyleBackColor = true;
            this.btnSeguinte.Click += new System.EventHandler(this.btnSeguinte_Click);
            // 
            // frmListagemUtentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 277);
            this.Controls.Add(this.btnSeguinte);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.lblCod_Postal);
            this.Controls.Add(this.lblMorada);
            this.Controls.Add(this.lblSocio);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.cbbSocio);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtCod_Postal);
            this.Controls.Add(this.txtMorada);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblIdUtente);
            this.Controls.Add(this.txtId_Utente);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListagemUtentes";
            this.Text = "ListagemUtentes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmListagemUtentes_FormClosing);
            this.Load += new System.EventHandler(this.frmListagemUtentes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId_Utente;
        private System.Windows.Forms.Label lblIdUtente;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtMorada;
        private System.Windows.Forms.TextBox txtCod_Postal;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ComboBox cbbSocio;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblSocio;
        private System.Windows.Forms.Label lblMorada;
        private System.Windows.Forms.Label lblCod_Postal;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSeguinte;
    }
}