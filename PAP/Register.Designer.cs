namespace PAP
{
    partial class frmRegistLogin
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
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtData_Nasc = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtMorada = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblMorada = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblApelido = new System.Windows.Forms.Label();
            this.lblData_Nasc = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblObrigatórios = new System.Windows.Forms.Label();
            this.btnRegistar = new System.Windows.Forms.Button();
            this.cbbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(59, 28);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(82, 20);
            this.txtnome.TabIndex = 0;
            // 
            // txtApelido
            // 
            this.txtApelido.Location = new System.Drawing.Point(205, 28);
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Size = new System.Drawing.Size(123, 20);
            this.txtApelido.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(60, 60);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(123, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // txtData_Nasc
            // 
            this.txtData_Nasc.Location = new System.Drawing.Point(120, 86);
            this.txtData_Nasc.Name = "txtData_Nasc";
            this.txtData_Nasc.Size = new System.Drawing.Size(79, 20);
            this.txtData_Nasc.TabIndex = 3;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(70, 112);
            this.txtTelefone.MaxLength = 9;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(123, 20);
            this.txtTelefone.TabIndex = 4;
            this.txtTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefone_KeyPress);
            // 
            // txtMorada
            // 
            this.txtMorada.Location = new System.Drawing.Point(64, 138);
            this.txtMorada.Name = "txtMorada";
            this.txtMorada.Size = new System.Drawing.Size(82, 20);
            this.txtMorada.TabIndex = 5;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(83, 164);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(147, 20);
            this.txtUser.TabIndex = 6;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(83, 190);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(123, 20);
            this.txtPass.TabIndex = 7;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 31);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 13);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "* Nome:";
            // 
            // lblMorada
            // 
            this.lblMorada.AutoSize = true;
            this.lblMorada.Location = new System.Drawing.Point(12, 141);
            this.lblMorada.Name = "lblMorada";
            this.lblMorada.Size = new System.Drawing.Size(46, 13);
            this.lblMorada.TabIndex = 9;
            this.lblMorada.Text = "Morada:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(12, 115);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 10;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 63);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 13);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "* Email:";
            // 
            // lblApelido
            // 
            this.lblApelido.AutoSize = true;
            this.lblApelido.Location = new System.Drawing.Point(147, 31);
            this.lblApelido.Name = "lblApelido";
            this.lblApelido.Size = new System.Drawing.Size(52, 13);
            this.lblApelido.TabIndex = 12;
            this.lblApelido.Text = "* Apelido:";
            // 
            // lblData_Nasc
            // 
            this.lblData_Nasc.AutoSize = true;
            this.lblData_Nasc.Location = new System.Drawing.Point(12, 89);
            this.lblData_Nasc.Name = "lblData_Nasc";
            this.lblData_Nasc.Size = new System.Drawing.Size(102, 13);
            this.lblData_Nasc.TabIndex = 13;
            this.lblData_Nasc.Text = "* Data_Nascimento:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(12, 167);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(65, 13);
            this.lblUser.TabIndex = 14;
            this.lblUser.Text = "* Username:";
            // 
            // lblPass
            // 
            this.lblPass.Location = new System.Drawing.Point(12, 193);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(65, 17);
            this.lblPass.TabIndex = 15;
            this.lblPass.Text = "* Password:";
            // 
            // lblObrigatórios
            // 
            this.lblObrigatórios.AutoSize = true;
            this.lblObrigatórios.Location = new System.Drawing.Point(14, 240);
            this.lblObrigatórios.Name = "lblObrigatórios";
            this.lblObrigatórios.Size = new System.Drawing.Size(108, 13);
            this.lblObrigatórios.TabIndex = 16;
            this.lblObrigatórios.Text = "*Campos Obrigatórios";
            // 
            // btnRegistar
            // 
            this.btnRegistar.Location = new System.Drawing.Point(205, 258);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(123, 41);
            this.btnRegistar.TabIndex = 17;
            this.btnRegistar.Text = "Registo";
            this.btnRegistar.UseVisualStyleBackColor = true;
            this.btnRegistar.Click += new System.EventHandler(this.btnRegistar_Click);
            // 
            // cbbTipo
            // 
            this.cbbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTipo.FormattingEnabled = true;
            this.cbbTipo.Items.AddRange(new object[] {
            "Administrador",
            "Funcionário"});
            this.cbbTipo.Location = new System.Drawing.Point(63, 216);
            this.cbbTipo.Name = "cbbTipo";
            this.cbbTipo.Size = new System.Drawing.Size(121, 21);
            this.cbbTipo.TabIndex = 18;
            // 
            // lblTipo
            // 
            this.lblTipo.Location = new System.Drawing.Point(14, 219);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(43, 18);
            this.lblTipo.TabIndex = 19;
            this.lblTipo.Text = "* Tipo:";
            // 
            // frmRegistLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 311);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.cbbTipo);
            this.Controls.Add(this.btnRegistar);
            this.Controls.Add(this.lblObrigatórios);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblData_Nasc);
            this.Controls.Add(this.lblApelido);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblMorada);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtMorada);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtData_Nasc);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtApelido);
            this.Controls.Add(this.txtnome);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegistLogin";
            this.Text = "Register";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Register_FormClosing);
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtApelido;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtData_Nasc;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtMorada;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblMorada;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblApelido;
        private System.Windows.Forms.Label lblData_Nasc;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblObrigatórios;
        private System.Windows.Forms.Button btnRegistar;
        private System.Windows.Forms.ComboBox cbbTipo;
        private System.Windows.Forms.Label lblTipo;
    }
}