namespace PAP
{
    partial class frmAlguer_Padel
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
            this.txtNome3 = new System.Windows.Forms.TextBox();
            this.lblNome3 = new System.Windows.Forms.Label();
            this.txtNome2 = new System.Windows.Forms.TextBox();
            this.lblNome2 = new System.Windows.Forms.Label();
            this.txtNome1 = new System.Windows.Forms.TextBox();
            this.lblNome1 = new System.Windows.Forms.Label();
            this.cbbqtdpessoas = new System.Windows.Forms.ComboBox();
            this.lblqtdspessoas = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.nupMFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupHFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMinicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupHinicial)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSeguinte
            // 
            this.btnSeguinte.Location = new System.Drawing.Point(310, 235);
            this.btnSeguinte.Name = "btnSeguinte";
            this.btnSeguinte.Size = new System.Drawing.Size(70, 32);
            this.btnSeguinte.TabIndex = 91;
            this.btnSeguinte.Text = "->";
            this.btnSeguinte.UseVisualStyleBackColor = true;
            this.btnSeguinte.Click += new System.EventHandler(this.btnSeguinte_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(233, 235);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(71, 32);
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
            this.cbbcampo.Location = new System.Drawing.Point(78, 197);
            this.cbbcampo.Name = "cbbcampo";
            this.cbbcampo.Size = new System.Drawing.Size(74, 21);
            this.cbbcampo.TabIndex = 89;
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(29, 200);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(43, 13);
            this.lblCampo.TabIndex = 88;
            this.lblCampo.Text = "Campo:";
            // 
            // btnRegistar_Utente
            // 
            this.btnRegistar_Utente.Location = new System.Drawing.Point(128, 235);
            this.btnRegistar_Utente.Name = "btnRegistar_Utente";
            this.btnRegistar_Utente.Size = new System.Drawing.Size(100, 32);
            this.btnRegistar_Utente.TabIndex = 87;
            this.btnRegistar_Utente.Text = "Registar_Utente";
            this.btnRegistar_Utente.UseVisualStyleBackColor = true;
            this.btnRegistar_Utente.Click += new System.EventHandler(this.btnRegistar_Utente_Click);
            // 
            // btnRegistar
            // 
            this.btnRegistar.Location = new System.Drawing.Point(34, 235);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(88, 32);
            this.btnRegistar.TabIndex = 86;
            this.btnRegistar.Text = "Registar";
            this.btnRegistar.UseVisualStyleBackColor = true;
            this.btnRegistar.Click += new System.EventHandler(this.btnRegistar_Click);
            // 
            // txtNome3
            // 
            this.txtNome3.Location = new System.Drawing.Point(70, 119);
            this.txtNome3.Name = "txtNome3";
            this.txtNome3.Size = new System.Drawing.Size(108, 20);
            this.txtNome3.TabIndex = 85;
            this.txtNome3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtNome3_MouseClick);
            // 
            // lblNome3
            // 
            this.lblNome3.AutoSize = true;
            this.lblNome3.Location = new System.Drawing.Point(26, 122);
            this.lblNome3.Name = "lblNome3";
            this.lblNome3.Size = new System.Drawing.Size(38, 13);
            this.lblNome3.TabIndex = 84;
            this.lblNome3.Text = "Nome:";
            // 
            // txtNome2
            // 
            this.txtNome2.Location = new System.Drawing.Point(70, 93);
            this.txtNome2.Name = "txtNome2";
            this.txtNome2.Size = new System.Drawing.Size(108, 20);
            this.txtNome2.TabIndex = 83;
            this.txtNome2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtNome2_MouseClick);
            // 
            // lblNome2
            // 
            this.lblNome2.AutoSize = true;
            this.lblNome2.Location = new System.Drawing.Point(26, 96);
            this.lblNome2.Name = "lblNome2";
            this.lblNome2.Size = new System.Drawing.Size(38, 13);
            this.lblNome2.TabIndex = 82;
            this.lblNome2.Text = "Nome:";
            // 
            // txtNome1
            // 
            this.txtNome1.Location = new System.Drawing.Point(70, 67);
            this.txtNome1.Name = "txtNome1";
            this.txtNome1.Size = new System.Drawing.Size(108, 20);
            this.txtNome1.TabIndex = 81;
            this.txtNome1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtNome1_MouseClick);
            // 
            // lblNome1
            // 
            this.lblNome1.AutoSize = true;
            this.lblNome1.Location = new System.Drawing.Point(26, 70);
            this.lblNome1.Name = "lblNome1";
            this.lblNome1.Size = new System.Drawing.Size(38, 13);
            this.lblNome1.TabIndex = 80;
            this.lblNome1.Text = "Nome:";
            // 
            // cbbqtdpessoas
            // 
            this.cbbqtdpessoas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbqtdpessoas.FormattingEnabled = true;
            this.cbbqtdpessoas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbbqtdpessoas.Location = new System.Drawing.Point(158, 10);
            this.cbbqtdpessoas.Name = "cbbqtdpessoas";
            this.cbbqtdpessoas.Size = new System.Drawing.Size(64, 21);
            this.cbbqtdpessoas.TabIndex = 79;
            this.cbbqtdpessoas.SelectedIndexChanged += new System.EventHandler(this.cbbqtdpessoas_SelectedIndexChanged);
            // 
            // lblqtdspessoas
            // 
            this.lblqtdspessoas.AutoSize = true;
            this.lblqtdspessoas.Location = new System.Drawing.Point(29, 13);
            this.lblqtdspessoas.Name = "lblqtdspessoas";
            this.lblqtdspessoas.Size = new System.Drawing.Size(123, 13);
            this.lblqtdspessoas.TabIndex = 78;
            this.lblqtdspessoas.Text = "Quantidade de Pessoas:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(31, 177);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(33, 13);
            this.lblData.TabIndex = 77;
            this.lblData.Text = "Data:";
            // 
            // dtpData
            // 
            this.dtpData.CustomFormat = "dd-MM-yyyy";
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpData.Location = new System.Drawing.Point(70, 171);
            this.dtpData.Name = "dtpData";
            this.dtpData.ShowUpDown = true;
            this.dtpData.Size = new System.Drawing.Size(82, 20);
            this.dtpData.TabIndex = 76;
            this.dtpData.Value = new System.DateTime(2017, 7, 5, 0, 0, 0, 0);
            // 
            // labelas
            // 
            this.labelas.AutoSize = true;
            this.labelas.Location = new System.Drawing.Point(147, 147);
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
            this.nupMFinal.Location = new System.Drawing.Point(209, 145);
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
            this.nupHFinal.Location = new System.Drawing.Point(171, 145);
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
            this.nupMinicial.Location = new System.Drawing.Point(106, 145);
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
            this.nupHinicial.Location = new System.Drawing.Point(70, 145);
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
            this.lblHorário.Location = new System.Drawing.Point(20, 147);
            this.lblHorário.Name = "lblHorário";
            this.lblHorário.Size = new System.Drawing.Size(44, 13);
            this.lblHorário.TabIndex = 70;
            this.lblHorário.Text = "Horário:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(70, 41);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(108, 20);
            this.txtNome.TabIndex = 69;
            this.txtNome.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtNome_MouseClick);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(26, 44);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 68;
            this.lblNome.Text = "Nome:";
            // 
            // frmAlguer_Padel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 276);
            this.Controls.Add(this.btnSeguinte);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.cbbcampo);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.btnRegistar_Utente);
            this.Controls.Add(this.btnRegistar);
            this.Controls.Add(this.txtNome3);
            this.Controls.Add(this.lblNome3);
            this.Controls.Add(this.txtNome2);
            this.Controls.Add(this.lblNome2);
            this.Controls.Add(this.txtNome1);
            this.Controls.Add(this.lblNome1);
            this.Controls.Add(this.cbbqtdpessoas);
            this.Controls.Add(this.lblqtdspessoas);
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
            this.Name = "frmAlguer_Padel";
            this.Text = "Alguer_Campo_Padel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAlguer_Padel_FormClosing);
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
        private System.Windows.Forms.TextBox txtNome3;
        private System.Windows.Forms.Label lblNome3;
        private System.Windows.Forms.TextBox txtNome2;
        private System.Windows.Forms.Label lblNome2;
        private System.Windows.Forms.TextBox txtNome1;
        private System.Windows.Forms.Label lblNome1;
        private System.Windows.Forms.ComboBox cbbqtdpessoas;
        private System.Windows.Forms.Label lblqtdspessoas;
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
    }
}