namespace PAP
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.tsLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSair = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUtentes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsfichaUtente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsNovoUtente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsListagemUtente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsConsumosUtentes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProfessores = new System.Windows.Forms.ToolStripMenuItem();
            this.tsNovoprof = new System.Windows.Forms.ToolStripMenuItem();
            this.txListagemProf = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAulas = new System.Windows.Forms.ToolStripMenuItem();
            this.ténisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcação_TénisToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.padelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcação_PadelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.squashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcação_SquashToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCampos = new System.Windows.Forms.ToolStripMenuItem();
            this.ténisToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Aluguer_TénisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.padelToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Aluguer_PadelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.squashToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Aluguer_SquashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPreços = new System.Windows.Forms.ToolStripMenuItem();
            this.sóciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nãoSóciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuLogin
            // 
            this.mnuLogin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLogin,
            this.tsRegister,
            this.tsLogout,
            this.tsSair});
            this.mnuLogin.Enabled = false;
            this.mnuLogin.Name = "mnuLogin";
            this.mnuLogin.Size = new System.Drawing.Size(49, 20);
            this.mnuLogin.Text = "Login";
            // 
            // tsLogin
            // 
            this.tsLogin.Name = "tsLogin";
            this.tsLogin.Size = new System.Drawing.Size(152, 22);
            this.tsLogin.Text = "Login";
            this.tsLogin.Click += new System.EventHandler(this.tsLogin_Click);
            // 
            // tsRegister
            // 
            this.tsRegister.Enabled = false;
            this.tsRegister.Name = "tsRegister";
            this.tsRegister.Size = new System.Drawing.Size(152, 22);
            this.tsRegister.Text = "Register";
            this.tsRegister.Click += new System.EventHandler(this.tsRegister_Click);
            // 
            // tsLogout
            // 
            this.tsLogout.Enabled = false;
            this.tsLogout.Name = "tsLogout";
            this.tsLogout.Size = new System.Drawing.Size(152, 22);
            this.tsLogout.Text = "Logout";
            this.tsLogout.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // tsSair
            // 
            this.tsSair.Name = "tsSair";
            this.tsSair.Size = new System.Drawing.Size(152, 22);
            this.tsSair.Text = "Sair";
            this.tsSair.Click += new System.EventHandler(this.sAirToolStripMenuItem_Click);
            // 
            // mnuUtentes
            // 
            this.mnuUtentes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsfichaUtente,
            this.tsConsumosUtentes});
            this.mnuUtentes.Enabled = false;
            this.mnuUtentes.Name = "mnuUtentes";
            this.mnuUtentes.Size = new System.Drawing.Size(59, 20);
            this.mnuUtentes.Text = "Utentes";
            // 
            // tsfichaUtente
            // 
            this.tsfichaUtente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsNovoUtente,
            this.tsListagemUtente});
            this.tsfichaUtente.Name = "tsfichaUtente";
            this.tsfichaUtente.Size = new System.Drawing.Size(152, 22);
            this.tsfichaUtente.Text = "Ficha";
            // 
            // tsNovoUtente
            // 
            this.tsNovoUtente.Name = "tsNovoUtente";
            this.tsNovoUtente.Size = new System.Drawing.Size(152, 22);
            this.tsNovoUtente.Text = "Nova";
            this.tsNovoUtente.Click += new System.EventHandler(this.criarToolStripMenuItem_Click);
            // 
            // tsListagemUtente
            // 
            this.tsListagemUtente.Name = "tsListagemUtente";
            this.tsListagemUtente.Size = new System.Drawing.Size(152, 22);
            this.tsListagemUtente.Text = "Listagem";
            this.tsListagemUtente.Click += new System.EventHandler(this.listagemToolStripMenuItem_Click);
            // 
            // tsConsumosUtentes
            // 
            this.tsConsumosUtentes.Name = "tsConsumosUtentes";
            this.tsConsumosUtentes.Size = new System.Drawing.Size(152, 22);
            this.tsConsumosUtentes.Text = "Consumos";
            this.tsConsumosUtentes.Click += new System.EventHandler(this.tsConsumosUtentes_Click);
            // 
            // mnuProfessores
            // 
            this.mnuProfessores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsNovoprof,
            this.txListagemProf});
            this.mnuProfessores.Enabled = false;
            this.mnuProfessores.Name = "mnuProfessores";
            this.mnuProfessores.Size = new System.Drawing.Size(79, 20);
            this.mnuProfessores.Text = "Professores";            
            // 
            // tsNovoprof
            // 
            this.tsNovoprof.Name = "tsNovoprof";
            this.tsNovoprof.Size = new System.Drawing.Size(152, 22);
            this.tsNovoprof.Text = "Novo";
            this.tsNovoprof.Click += new System.EventHandler(this.tsNovoprof_Click);
            // 
            // txListagemProf
            // 
            this.txListagemProf.Name = "txListagemProf";
            this.txListagemProf.Size = new System.Drawing.Size(152, 22);
            this.txListagemProf.Text = "Listagem";
            this.txListagemProf.Click += new System.EventHandler(this.txListagemProf_Click);
            // 
            // mnuAulas
            // 
            this.mnuAulas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ténisToolStripMenuItem,
            this.padelToolStripMenuItem,
            this.squashToolStripMenuItem});
            this.mnuAulas.Enabled = false;
            this.mnuAulas.Name = "mnuAulas";
            this.mnuAulas.Size = new System.Drawing.Size(48, 20);
            this.mnuAulas.Text = "Aulas";
            // 
            // ténisToolStripMenuItem
            // 
            this.ténisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marcação_TénisToolStripMenuItem1});
            this.ténisToolStripMenuItem.Name = "ténisToolStripMenuItem";
            this.ténisToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ténisToolStripMenuItem.Text = "Ténis";
            // 
            // marcação_TénisToolStripMenuItem1
            // 
            this.marcação_TénisToolStripMenuItem1.Name = "marcação_TénisToolStripMenuItem1";
            this.marcação_TénisToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.marcação_TénisToolStripMenuItem1.Text = "Marcação";
            this.marcação_TénisToolStripMenuItem1.Click += new System.EventHandler(this.marcaçãoToolStripMenuItem1_Click);
            // 
            // padelToolStripMenuItem
            // 
            this.padelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marcação_PadelToolStripMenuItem});
            this.padelToolStripMenuItem.Name = "padelToolStripMenuItem";
            this.padelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.padelToolStripMenuItem.Text = "Padel";
            // 
            // marcação_PadelToolStripMenuItem
            // 
            this.marcação_PadelToolStripMenuItem.Name = "marcação_PadelToolStripMenuItem";
            this.marcação_PadelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.marcação_PadelToolStripMenuItem.Text = "Marcação";
            this.marcação_PadelToolStripMenuItem.Click += new System.EventHandler(this.marcação_PadelToolStripMenuItem_Click);
            // 
            // squashToolStripMenuItem
            // 
            this.squashToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marcação_SquashToolStripMenuItem2});
            this.squashToolStripMenuItem.Name = "squashToolStripMenuItem";
            this.squashToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.squashToolStripMenuItem.Text = "Squash";
            // 
            // marcação_SquashToolStripMenuItem2
            // 
            this.marcação_SquashToolStripMenuItem2.Name = "marcação_SquashToolStripMenuItem2";
            this.marcação_SquashToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.marcação_SquashToolStripMenuItem2.Text = "Marcação";
            this.marcação_SquashToolStripMenuItem2.Click += new System.EventHandler(this.marcação_SquashToolStripMenuItem2_Click);
            // 
            // mnuCampos
            // 
            this.mnuCampos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ténisToolStripMenuItem1,
            this.padelToolStripMenuItem1,
            this.squashToolStripMenuItem1,
            this.adicionarToolStripMenuItem});
            this.mnuCampos.Enabled = false;
            this.mnuCampos.Name = "mnuCampos";
            this.mnuCampos.Size = new System.Drawing.Size(63, 20);
            this.mnuCampos.Text = "Campos";
            // 
            // ténisToolStripMenuItem1
            // 
            this.ténisToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Aluguer_TénisToolStripMenuItem});
            this.ténisToolStripMenuItem1.Name = "ténisToolStripMenuItem1";
            this.ténisToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.ténisToolStripMenuItem1.Text = "Ténis";
            // 
            // Aluguer_TénisToolStripMenuItem
            // 
            this.Aluguer_TénisToolStripMenuItem.Name = "Aluguer_TénisToolStripMenuItem";
            this.Aluguer_TénisToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.Aluguer_TénisToolStripMenuItem.Text = "Aluguer";
            this.Aluguer_TénisToolStripMenuItem.Click += new System.EventHandler(this.aluguerToolStripMenuItem_Click);
            // 
            // padelToolStripMenuItem1
            // 
            this.padelToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Aluguer_PadelToolStripMenuItem});
            this.padelToolStripMenuItem1.Name = "padelToolStripMenuItem1";
            this.padelToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.padelToolStripMenuItem1.Text = "Padel";
            // 
            // Aluguer_PadelToolStripMenuItem
            // 
            this.Aluguer_PadelToolStripMenuItem.Name = "Aluguer_PadelToolStripMenuItem";
            this.Aluguer_PadelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.Aluguer_PadelToolStripMenuItem.Text = "Aluguer";
            this.Aluguer_PadelToolStripMenuItem.Click += new System.EventHandler(this.Aluguer_PadelToolStripMenuItem_Click);
            // 
            // squashToolStripMenuItem1
            // 
            this.squashToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Aluguer_SquashToolStripMenuItem});
            this.squashToolStripMenuItem1.Name = "squashToolStripMenuItem1";
            this.squashToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.squashToolStripMenuItem1.Text = "Squash";
            // 
            // Aluguer_SquashToolStripMenuItem
            // 
            this.Aluguer_SquashToolStripMenuItem.Name = "Aluguer_SquashToolStripMenuItem";
            this.Aluguer_SquashToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.Aluguer_SquashToolStripMenuItem.Text = "Aluguer";
            this.Aluguer_SquashToolStripMenuItem.Click += new System.EventHandler(this.Aluguer_SquashToolStripMenuItem_Click);
            // 
            // adicionarToolStripMenuItem
            // 
            this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.adicionarToolStripMenuItem.Text = "Adicionar";
            this.adicionarToolStripMenuItem.Click += new System.EventHandler(this.adicionarToolStripMenuItem_Click);
            // 
            // mnuPreços
            // 
            this.mnuPreços.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sóciosToolStripMenuItem,
            this.nãoSóciosToolStripMenuItem,
            this.toolStripMenuItem1});
            this.mnuPreços.Enabled = false;
            this.mnuPreços.Name = "mnuPreços";
            this.mnuPreços.Size = new System.Drawing.Size(54, 20);
            this.mnuPreços.Text = "Preços";
            // 
            // sóciosToolStripMenuItem
            // 
            this.sóciosToolStripMenuItem.Name = "sóciosToolStripMenuItem";
            this.sóciosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sóciosToolStripMenuItem.Text = "Sócios";
            // 
            // nãoSóciosToolStripMenuItem
            // 
            this.nãoSóciosToolStripMenuItem.Name = "nãoSóciosToolStripMenuItem";
            this.nãoSóciosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nãoSóciosToolStripMenuItem.Text = "Não Sócios";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "Registar";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLogin,
            this.mnuUtentes,
            this.mnuProfessores,
            this.mnuAulas,
            this.mnuCampos,
            this.mnuPreços});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1262, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1262, 750);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1278, 791);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1278, 726);
            this.Name = "frmMain";
            this.Text = "SportyGest";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolStripMenuItem mnuLogin;
        public System.Windows.Forms.ToolStripMenuItem tsLogin;
        public System.Windows.Forms.ToolStripMenuItem tsRegister;
        public System.Windows.Forms.ToolStripMenuItem tsLogout;
        private System.Windows.Forms.ToolStripMenuItem tsSair;
        public System.Windows.Forms.ToolStripMenuItem mnuUtentes;
        private System.Windows.Forms.ToolStripMenuItem tsfichaUtente;
        private System.Windows.Forms.ToolStripMenuItem tsNovoUtente;
        private System.Windows.Forms.ToolStripMenuItem tsListagemUtente;
        private System.Windows.Forms.ToolStripMenuItem tsConsumosUtentes;
        public System.Windows.Forms.ToolStripMenuItem mnuProfessores;
        private System.Windows.Forms.ToolStripMenuItem tsNovoprof;
        private System.Windows.Forms.ToolStripMenuItem txListagemProf;
        public System.Windows.Forms.ToolStripMenuItem mnuAulas;
        private System.Windows.Forms.ToolStripMenuItem padelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcação_PadelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ténisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcação_TénisToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem squashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcação_SquashToolStripMenuItem2;
        public System.Windows.Forms.ToolStripMenuItem mnuCampos;
        private System.Windows.Forms.ToolStripMenuItem ténisToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem padelToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem squashToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem mnuPreços;
        private System.Windows.Forms.ToolStripMenuItem sóciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nãoSóciosToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Aluguer_TénisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Aluguer_PadelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Aluguer_SquashToolStripMenuItem;
    }
}