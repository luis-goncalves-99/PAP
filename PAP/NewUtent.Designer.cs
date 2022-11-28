namespace PAP
{
    partial class frmNovoUtente
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
            this.btnRegist = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cbbSocio = new System.Windows.Forms.ComboBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtMorada = new System.Windows.Forms.TextBox();
            this.txtCod_Postal = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSocio = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblMorada = new System.Windows.Forms.Label();
            this.lblCod_Postal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegist
            // 
            this.btnRegist.Location = new System.Drawing.Point(150, 191);
            this.btnRegist.Name = "btnRegist";
            this.btnRegist.Size = new System.Drawing.Size(88, 42);
            this.btnRegist.TabIndex = 0;
            this.btnRegist.Text = "Registar";
            this.btnRegist.UseVisualStyleBackColor = true;
            this.btnRegist.Click += new System.EventHandler(this.btnRegist_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(76, 30);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(189, 20);
            this.txtNome.TabIndex = 1;            
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(76, 56);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(189, 20);
            this.txtEmail.TabIndex = 2;            
            // 
            // cbbSocio
            // 
            this.cbbSocio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSocio.FormattingEnabled = true;
            this.cbbSocio.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cbbSocio.Location = new System.Drawing.Point(76, 83);
            this.cbbSocio.Name = "cbbSocio";
            this.cbbSocio.Size = new System.Drawing.Size(100, 21);
            this.cbbSocio.TabIndex = 3;            
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(76, 111);
            this.txtTelefone.MaxLength = 9;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(66, 20);
            this.txtTelefone.TabIndex = 4;
            this.txtTelefone.TextChanged += new System.EventHandler(this.txtTelefone_TextChanged);
            this.txtTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefone_KeyPress);
            // 
            // txtMorada
            // 
            this.txtMorada.Location = new System.Drawing.Point(76, 138);
            this.txtMorada.Name = "txtMorada";
            this.txtMorada.Size = new System.Drawing.Size(189, 20);
            this.txtMorada.TabIndex = 5;            
            // 
            // txtCod_Postal
            // 
            this.txtCod_Postal.Location = new System.Drawing.Point(76, 165);
            this.txtCod_Postal.MaxLength = 8;
            this.txtCod_Postal.Name = "txtCod_Postal";
            this.txtCod_Postal.Size = new System.Drawing.Size(58, 20);
            this.txtCod_Postal.TabIndex = 6;            
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(35, 33);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 7;
            this.lblNome.Text = "Nome:";            
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(35, 59);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email:";            
            // 
            // lblSocio
            // 
            this.lblSocio.AutoSize = true;
            this.lblSocio.Location = new System.Drawing.Point(35, 86);
            this.lblSocio.Name = "lblSocio";
            this.lblSocio.Size = new System.Drawing.Size(37, 13);
            this.lblSocio.TabIndex = 9;
            this.lblSocio.Text = "Socio:";            
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(21, 114);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 10;
            this.lblTelefone.Text = "Telefone:";            
            // 
            // lblMorada
            // 
            this.lblMorada.AutoSize = true;
            this.lblMorada.Location = new System.Drawing.Point(24, 141);
            this.lblMorada.Name = "lblMorada";
            this.lblMorada.Size = new System.Drawing.Size(46, 13);
            this.lblMorada.TabIndex = 11;
            this.lblMorada.Text = "Morada:";            
            // 
            // lblCod_Postal
            // 
            this.lblCod_Postal.AutoSize = true;
            this.lblCod_Postal.Location = new System.Drawing.Point(6, 168);
            this.lblCod_Postal.Name = "lblCod_Postal";
            this.lblCod_Postal.Size = new System.Drawing.Size(64, 13);
            this.lblCod_Postal.TabIndex = 12;
            this.lblCod_Postal.Text = "Cod_Postal:";
            // 
            // frmNovoUtente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 245);
            this.Controls.Add(this.lblCod_Postal);
            this.Controls.Add(this.lblMorada);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblSocio);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtCod_Postal);
            this.Controls.Add(this.txtMorada);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.cbbSocio);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnRegist);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNovoUtente";
            this.Text = "NovoUtente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNovoUtente_FormClosing);
            this.Load += new System.EventHandler(this.frmNovoUtente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegist;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cbbSocio;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtMorada;
        private System.Windows.Forms.TextBox txtCod_Postal;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSocio;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblMorada;
        private System.Windows.Forms.Label lblCod_Postal;
    }
}