namespace PAP
{
    partial class frmNewProf
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
            this.lblCod_Postal = new System.Windows.Forms.Label();
            this.lblMorada = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCod_Postal = new System.Windows.Forms.TextBox();
            this.txtMorada = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnRegist = new System.Windows.Forms.Button();
            this.lblDesporto = new System.Windows.Forms.Label();
            this.cbbDesporto = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblCod_Postal
            // 
            this.lblCod_Postal.AutoSize = true;
            this.lblCod_Postal.Location = new System.Drawing.Point(32, 144);
            this.lblCod_Postal.Name = "lblCod_Postal";
            this.lblCod_Postal.Size = new System.Drawing.Size(64, 13);
            this.lblCod_Postal.TabIndex = 25;
            this.lblCod_Postal.Text = "Cod_Postal:";
            // 
            // lblMorada
            // 
            this.lblMorada.AutoSize = true;
            this.lblMorada.Location = new System.Drawing.Point(50, 117);
            this.lblMorada.Name = "lblMorada";
            this.lblMorada.Size = new System.Drawing.Size(46, 13);
            this.lblMorada.TabIndex = 24;
            this.lblMorada.Text = "Morada:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(47, 90);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 23;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(61, 62);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 21;
            this.lblEmail.Text = "Email:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(61, 36);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 20;
            this.lblNome.Text = "Nome:";
            // 
            // txtCod_Postal
            // 
            this.txtCod_Postal.Location = new System.Drawing.Point(102, 141);
            this.txtCod_Postal.MaxLength = 8;
            this.txtCod_Postal.Name = "txtCod_Postal";
            this.txtCod_Postal.Size = new System.Drawing.Size(58, 20);
            this.txtCod_Postal.TabIndex = 19;
            // 
            // txtMorada
            // 
            this.txtMorada.Location = new System.Drawing.Point(102, 114);
            this.txtMorada.Name = "txtMorada";
            this.txtMorada.Size = new System.Drawing.Size(189, 20);
            this.txtMorada.TabIndex = 18;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(102, 87);
            this.txtTelefone.MaxLength = 9;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(66, 20);
            this.txtTelefone.TabIndex = 17;
            this.txtTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefone_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(102, 59);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(189, 20);
            this.txtEmail.TabIndex = 15;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(102, 33);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(189, 20);
            this.txtNome.TabIndex = 14;
            // 
            // btnRegist
            // 
            this.btnRegist.Location = new System.Drawing.Point(203, 209);
            this.btnRegist.Name = "btnRegist";
            this.btnRegist.Size = new System.Drawing.Size(88, 42);
            this.btnRegist.TabIndex = 13;
            this.btnRegist.Text = "Registar";
            this.btnRegist.UseVisualStyleBackColor = true;
            this.btnRegist.Click += new System.EventHandler(this.btnRegist_Click);
            // 
            // lblDesporto
            // 
            this.lblDesporto.AutoSize = true;
            this.lblDesporto.Location = new System.Drawing.Point(5, 185);
            this.lblDesporto.Name = "lblDesporto";
            this.lblDesporto.Size = new System.Drawing.Size(53, 13);
            this.lblDesporto.TabIndex = 57;
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
            this.cbbDesporto.Location = new System.Drawing.Point(64, 182);
            this.cbbDesporto.Name = "cbbDesporto";
            this.cbbDesporto.Size = new System.Drawing.Size(74, 21);
            this.cbbDesporto.TabIndex = 58;
            // 
            // frmNewProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 265);
            this.Controls.Add(this.cbbDesporto);
            this.Controls.Add(this.lblDesporto);
            this.Controls.Add(this.lblCod_Postal);
            this.Controls.Add(this.lblMorada);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtCod_Postal);
            this.Controls.Add(this.txtMorada);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnRegist);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNewProf";
            this.Text = "NewProf";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewProf_FormClosing);
            this.Load += new System.EventHandler(this.frmNewProf_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCod_Postal;
        private System.Windows.Forms.Label lblMorada;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtCod_Postal;
        private System.Windows.Forms.TextBox txtMorada;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnRegist;
        private System.Windows.Forms.Label lblDesporto;
        private System.Windows.Forms.ComboBox cbbDesporto;
    }
}