namespace PAP
{
    partial class frmFichaProf
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
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblCod_Postal = new System.Windows.Forms.Label();
            this.lblMorada = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtCod_Postal = new System.Windows.Forms.TextBox();
            this.txtMorada = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblIdUtente = new System.Windows.Forms.Label();
            this.txtId_Prof = new System.Windows.Forms.TextBox();
            this.btnSeguinte = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.lblDesporto = new System.Windows.Forms.Label();
            this.cbbDesporto = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(144, 240);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(70, 26);
            this.btnApagar.TabIndex = 32;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // lblCod_Postal
            // 
            this.lblCod_Postal.AutoSize = true;
            this.lblCod_Postal.Location = new System.Drawing.Point(53, 170);
            this.lblCod_Postal.Name = "lblCod_Postal";
            this.lblCod_Postal.Size = new System.Drawing.Size(64, 13);
            this.lblCod_Postal.TabIndex = 31;
            this.lblCod_Postal.Text = "Cod_Postal:";
            // 
            // lblMorada
            // 
            this.lblMorada.AutoSize = true;
            this.lblMorada.Location = new System.Drawing.Point(71, 135);
            this.lblMorada.Name = "lblMorada";
            this.lblMorada.Size = new System.Drawing.Size(46, 13);
            this.lblMorada.TabIndex = 30;
            this.lblMorada.Text = "Morada:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(65, 100);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 28;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(82, 65);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 26;
            this.lblEmail.Text = "Email:";
            // 
            // txtCod_Postal
            // 
            this.txtCod_Postal.Location = new System.Drawing.Point(123, 167);
            this.txtCod_Postal.MaxLength = 8;
            this.txtCod_Postal.Name = "txtCod_Postal";
            this.txtCod_Postal.Size = new System.Drawing.Size(77, 20);
            this.txtCod_Postal.TabIndex = 25;
            // 
            // txtMorada
            // 
            this.txtMorada.Location = new System.Drawing.Point(123, 132);
            this.txtMorada.Name = "txtMorada";
            this.txtMorada.Size = new System.Drawing.Size(211, 20);
            this.txtMorada.TabIndex = 24;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(123, 97);
            this.txtTelefone.MaxLength = 9;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(83, 20);
            this.txtTelefone.TabIndex = 23;
            this.txtTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefone_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(123, 62);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(211, 20);
            this.txtEmail.TabIndex = 22;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(68, 240);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(70, 26);
            this.btnConfirmar.TabIndex = 21;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(123, 22);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(211, 20);
            this.txtnome.TabIndex = 20;
            this.txtnome.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtnome_MouseDoubleClick);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNome.Location = new System.Drawing.Point(79, 25);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 19;
            this.lblNome.Text = "Nome:";
            // 
            // lblIdUtente
            // 
            this.lblIdUtente.AutoSize = true;
            this.lblIdUtente.Location = new System.Drawing.Point(16, 25);
            this.lblIdUtente.Name = "lblIdUtente";
            this.lblIdUtente.Size = new System.Drawing.Size(19, 13);
            this.lblIdUtente.TabIndex = 18;
            this.lblIdUtente.Text = "Id:";
            // 
            // txtId_Prof
            // 
            this.txtId_Prof.Location = new System.Drawing.Point(41, 22);
            this.txtId_Prof.Name = "txtId_Prof";
            this.txtId_Prof.ReadOnly = true;
            this.txtId_Prof.Size = new System.Drawing.Size(27, 20);
            this.txtId_Prof.TabIndex = 17;
            // 
            // btnSeguinte
            // 
            this.btnSeguinte.Location = new System.Drawing.Point(279, 240);
            this.btnSeguinte.Name = "btnSeguinte";
            this.btnSeguinte.Size = new System.Drawing.Size(53, 26);
            this.btnSeguinte.TabIndex = 34;
            this.btnSeguinte.Text = "->";
            this.btnSeguinte.UseVisualStyleBackColor = true;
            this.btnSeguinte.Click += new System.EventHandler(this.btnSeguinte_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(220, 240);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(53, 26);
            this.btnAnterior.TabIndex = 33;
            this.btnAnterior.Text = "<-";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // lblDesporto
            // 
            this.lblDesporto.AutoSize = true;
            this.lblDesporto.Location = new System.Drawing.Point(60, 206);
            this.lblDesporto.Name = "lblDesporto";
            this.lblDesporto.Size = new System.Drawing.Size(53, 13);
            this.lblDesporto.TabIndex = 47;
            this.lblDesporto.Text = "Desporto:";
            // 
            // cbbDesporto
            // 
            this.cbbDesporto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDesporto.FormattingEnabled = true;
            this.cbbDesporto.Items.AddRange(new object[] {
            "Ténis",
            "Padel",
            "Squash"});
            this.cbbDesporto.Location = new System.Drawing.Point(119, 203);
            this.cbbDesporto.Name = "cbbDesporto";
            this.cbbDesporto.Size = new System.Drawing.Size(71, 21);
            this.cbbDesporto.TabIndex = 48;
            // 
            // frmFichaProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 289);
            this.Controls.Add(this.cbbDesporto);
            this.Controls.Add(this.lblDesporto);
            this.Controls.Add(this.btnSeguinte);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.lblCod_Postal);
            this.Controls.Add(this.lblMorada);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtCod_Postal);
            this.Controls.Add(this.txtMorada);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblIdUtente);
            this.Controls.Add(this.txtId_Prof);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFichaProf";
            this.Text = "Ficha_Prof";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmListagemProf_FormClosing);
            this.Load += new System.EventHandler(this.frmNewProf_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblCod_Postal;
        private System.Windows.Forms.Label lblMorada;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtCod_Postal;
        private System.Windows.Forms.TextBox txtMorada;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblIdUtente;
        private System.Windows.Forms.TextBox txtId_Prof;
        private System.Windows.Forms.Button btnSeguinte;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Label lblDesporto;
        private System.Windows.Forms.ComboBox cbbDesporto;
    }
}