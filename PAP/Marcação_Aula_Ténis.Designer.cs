namespace PAP
{
    partial class frmMarcação_Aula_Ténis
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
            this.btnSeguinte = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.cbbcampo = new System.Windows.Forms.ComboBox();
            this.lblCampo = new System.Windows.Forms.Label();
            this.btnRegistar_Utente = new System.Windows.Forms.Button();
            this.btnRegistar = new System.Windows.Forms.Button();
            this.lblData = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.labelas = new System.Windows.Forms.Label();
            this.nupMFinal = new System.Windows.Forms.NumericUpDown();
            this.nupHFinal = new System.Windows.Forms.NumericUpDown();
            this.nupMinicial = new System.Windows.Forms.NumericUpDown();
            this.nupHinicial = new System.Windows.Forms.NumericUpDown();
            this.lblHorário = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblProfessor = new System.Windows.Forms.Label();
            this.cbbProfessor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupMFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupHFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMinicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupHinicial)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSeguinte
            // 
            this.btnSeguinte.Location = new System.Drawing.Point(313, 191);
            this.btnSeguinte.Name = "btnSeguinte";
            this.btnSeguinte.Size = new System.Drawing.Size(63, 32);
            this.btnSeguinte.TabIndex = 91;
            this.btnSeguinte.Text = "->";
            this.btnSeguinte.UseVisualStyleBackColor = true;
            this.btnSeguinte.Click += new System.EventHandler(this.btnSeguinte_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(244, 191);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(63, 32);
            this.btnAnterior.TabIndex = 90;
            this.btnAnterior.Text = "<-";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // cbbcampo
            // 
            this.cbbcampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbcampo.FormattingEnabled = true;
            this.cbbcampo.Items.AddRange(new object[] {
            "Campo1",
            "Campo2",
            "Campo3",
            "Campo4"});
            this.cbbcampo.Location = new System.Drawing.Point(63, 120);
            this.cbbcampo.Name = "cbbcampo";
            this.cbbcampo.Size = new System.Drawing.Size(74, 21);
            this.cbbcampo.TabIndex = 89;
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(14, 123);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(43, 13);
            this.lblCampo.TabIndex = 88;
            this.lblCampo.Text = "Campo:";
            // 
            // btnRegistar_Utente
            // 
            this.btnRegistar_Utente.Location = new System.Drawing.Point(138, 191);
            this.btnRegistar_Utente.Name = "btnRegistar_Utente";
            this.btnRegistar_Utente.Size = new System.Drawing.Size(100, 32);
            this.btnRegistar_Utente.TabIndex = 87;
            this.btnRegistar_Utente.Text = "Registar_Utente";
            this.btnRegistar_Utente.UseVisualStyleBackColor = true;
            this.btnRegistar_Utente.Click += new System.EventHandler(this.btnRegistar_Utente_Click);
            // 
            // btnRegistar
            // 
            this.btnRegistar.Location = new System.Drawing.Point(44, 191);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(88, 32);
            this.btnRegistar.TabIndex = 86;
            this.btnRegistar.Text = "Registar";
            this.btnRegistar.UseVisualStyleBackColor = true;
            this.btnRegistar.Click += new System.EventHandler(this.btnRegistar_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(24, 100);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(33, 13);
            this.lblData.TabIndex = 77;
            this.lblData.Text = "Data:";
            // 
            // dtpData
            // 
            this.dtpData.CustomFormat = "dd-MM-yyyy";
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpData.Location = new System.Drawing.Point(63, 94);
            this.dtpData.Name = "dtpData";
            this.dtpData.ShowUpDown = true;
            this.dtpData.Size = new System.Drawing.Size(82, 20);
            this.dtpData.TabIndex = 76;
            this.dtpData.Value = new System.DateTime(2017, 7, 5, 0, 0, 0, 0);
            // 
            // labelas
            // 
            this.labelas.AutoSize = true;
            this.labelas.Location = new System.Drawing.Point(140, 70);
            this.labelas.Name = "labelas";
            this.labelas.Size = new System.Drawing.Size(18, 13);
            this.labelas.TabIndex = 75;
            this.labelas.Text = "ás";
            // 
            // nupMFinal
            // 
            this.nupMFinal.Increment = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nupMFinal.Location = new System.Drawing.Point(202, 68);
            this.nupMFinal.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nupMFinal.Name = "nupMFinal";
            this.nupMFinal.Size = new System.Drawing.Size(36, 20);
            this.nupMFinal.TabIndex = 74;
            // 
            // nupHFinal
            // 
            this.nupHFinal.Location = new System.Drawing.Point(164, 68);
            this.nupHFinal.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nupHFinal.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nupHFinal.Name = "nupHFinal";
            this.nupHFinal.Size = new System.Drawing.Size(38, 20);
            this.nupHFinal.TabIndex = 73;
            this.nupHFinal.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // nupMinicial
            // 
            this.nupMinicial.Increment = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nupMinicial.Location = new System.Drawing.Point(99, 68);
            this.nupMinicial.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nupMinicial.Name = "nupMinicial";
            this.nupMinicial.Size = new System.Drawing.Size(35, 20);
            this.nupMinicial.TabIndex = 72;
            // 
            // nupHinicial
            // 
            this.nupHinicial.Location = new System.Drawing.Point(63, 68);
            this.nupHinicial.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nupHinicial.Name = "nupHinicial";
            this.nupHinicial.Size = new System.Drawing.Size(35, 20);
            this.nupHinicial.TabIndex = 71;
            this.nupHinicial.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // lblHorário
            // 
            this.lblHorário.AutoSize = true;
            this.lblHorário.Location = new System.Drawing.Point(13, 70);
            this.lblHorário.Name = "lblHorário";
            this.lblHorário.Size = new System.Drawing.Size(44, 13);
            this.lblHorário.TabIndex = 70;
            this.lblHorário.Text = "Horário:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(55, 22);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(108, 20);
            this.txtNome.TabIndex = 69;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(11, 25);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 68;
            this.lblNome.Text = "Nome:";
            // 
            // lblProfessor
            // 
            this.lblProfessor.AutoSize = true;
            this.lblProfessor.Location = new System.Drawing.Point(13, 150);
            this.lblProfessor.Name = "lblProfessor";
            this.lblProfessor.Size = new System.Drawing.Size(54, 13);
            this.lblProfessor.TabIndex = 92;
            this.lblProfessor.Text = "Professor:";
            // 
            // cbbProfessor
            // 
            this.cbbProfessor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbProfessor.FormattingEnabled = true;
            this.cbbProfessor.Location = new System.Drawing.Point(73, 147);
            this.cbbProfessor.Name = "cbbProfessor";
            this.cbbProfessor.Size = new System.Drawing.Size(98, 21);
            this.cbbProfessor.TabIndex = 93;
            // 
            // frmMarcação_Aula_Ténis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 254);
            this.Controls.Add(this.cbbProfessor);
            this.Controls.Add(this.lblProfessor);
            this.Controls.Add(this.btnSeguinte);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.cbbcampo);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.btnRegistar_Utente);
            this.Controls.Add(this.btnRegistar);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.labelas);
            this.Controls.Add(this.nupMFinal);
            this.Controls.Add(this.nupHFinal);
            this.Controls.Add(this.nupMinicial);
            this.Controls.Add(this.nupHinicial);
            this.Controls.Add(this.lblHorário);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMarcação_Aula_Ténis";
            this.Text = "Marcação_Aula_Ténis";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMarcação_Aula_Ténis_FormClosing);
            this.Load += new System.EventHandler(this.frmMarcação_Aula_Ténis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupMFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupHFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMinicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupHinicial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSeguinte;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.ComboBox cbbcampo;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Button btnRegistar_Utente;
        private System.Windows.Forms.Button btnRegistar;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label labelas;
        private System.Windows.Forms.NumericUpDown nupMFinal;
        private System.Windows.Forms.NumericUpDown nupHFinal;
        private System.Windows.Forms.NumericUpDown nupMinicial;
        private System.Windows.Forms.NumericUpDown nupHinicial;
        private System.Windows.Forms.Label lblHorário;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblProfessor;
        private System.Windows.Forms.ComboBox cbbProfessor;
    }
}