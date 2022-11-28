namespace PAP
{
    partial class frmAluguer_Ténis
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblHorário = new System.Windows.Forms.Label();
            this.labelas = new System.Windows.Forms.Label();
            this.nupMFinal = new System.Windows.Forms.NumericUpDown();
            this.nupHFinal = new System.Windows.Forms.NumericUpDown();
            this.nupMinicial = new System.Windows.Forms.NumericUpDown();
            this.nupHinicial = new System.Windows.Forms.NumericUpDown();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.lblqtdspessoas = new System.Windows.Forms.Label();
            this.cbbqtdpessoas = new System.Windows.Forms.ComboBox();
            this.txtNome1 = new System.Windows.Forms.TextBox();
            this.lblNome1 = new System.Windows.Forms.Label();
            this.txtNome2 = new System.Windows.Forms.TextBox();
            this.lblNome2 = new System.Windows.Forms.Label();
            this.txtNome3 = new System.Windows.Forms.TextBox();
            this.lblNome3 = new System.Windows.Forms.Label();
            this.btnRegistar = new System.Windows.Forms.Button();
            this.btnRegistar_Utente = new System.Windows.Forms.Button();
            this.lblCampo = new System.Windows.Forms.Label();
            this.cbbcampo = new System.Windows.Forms.ComboBox();
            this.btnSeguinte = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupMFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupHFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMinicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupHinicial)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(27, 40);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(71, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(108, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtNome_MouseClick);
            // 
            // lblHorário
            // 
            this.lblHorário.AutoSize = true;
            this.lblHorário.Location = new System.Drawing.Point(21, 143);
            this.lblHorário.Name = "lblHorário";
            this.lblHorário.Size = new System.Drawing.Size(44, 13);
            this.lblHorário.TabIndex = 2;
            this.lblHorário.Text = "Horário:";
            // 
            // labelas
            // 
            this.labelas.AutoSize = true;
            this.labelas.Location = new System.Drawing.Point(148, 143);
            this.labelas.Name = "labelas";
            this.labelas.Size = new System.Drawing.Size(18, 13);
            this.labelas.TabIndex = 51;
            this.labelas.Text = "ás";
            // 
            // nupMFinal
            // 
            this.nupMFinal.Increment = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nupMFinal.Location = new System.Drawing.Point(210, 141);
            this.nupMFinal.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nupMFinal.Name = "nupMFinal";
            this.nupMFinal.Size = new System.Drawing.Size(36, 20);
            this.nupMFinal.TabIndex = 50;
            // 
            // nupHFinal
            // 
            this.nupHFinal.Location = new System.Drawing.Point(172, 141);
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
            this.nupHFinal.TabIndex = 49;
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
            this.nupMinicial.Location = new System.Drawing.Point(107, 141);
            this.nupMinicial.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nupMinicial.Name = "nupMinicial";
            this.nupMinicial.Size = new System.Drawing.Size(35, 20);
            this.nupMinicial.TabIndex = 48;
            // 
            // nupHinicial
            // 
            this.nupHinicial.Location = new System.Drawing.Point(71, 141);
            this.nupHinicial.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nupHinicial.Name = "nupHinicial";
            this.nupHinicial.Size = new System.Drawing.Size(35, 20);
            this.nupHinicial.TabIndex = 47;
            this.nupHinicial.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // dtpData
            // 
            this.dtpData.CustomFormat = "dd-MM-yyyy";
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpData.Location = new System.Drawing.Point(71, 167);
            this.dtpData.Name = "dtpData";
            this.dtpData.ShowUpDown = true;
            this.dtpData.Size = new System.Drawing.Size(82, 20);
            this.dtpData.TabIndex = 52;
            this.dtpData.Value = new System.DateTime(2017, 7, 5, 0, 0, 0, 0);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(32, 173);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(33, 13);
            this.lblData.TabIndex = 53;
            this.lblData.Text = "Data:";
            // 
            // lblqtdspessoas
            // 
            this.lblqtdspessoas.AutoSize = true;
            this.lblqtdspessoas.Location = new System.Drawing.Point(30, 9);
            this.lblqtdspessoas.Name = "lblqtdspessoas";
            this.lblqtdspessoas.Size = new System.Drawing.Size(123, 13);
            this.lblqtdspessoas.TabIndex = 54;
            this.lblqtdspessoas.Text = "Quantidade de Pessoas:";
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
            this.cbbqtdpessoas.Location = new System.Drawing.Point(159, 6);
            this.cbbqtdpessoas.Name = "cbbqtdpessoas";
            this.cbbqtdpessoas.Size = new System.Drawing.Size(64, 21);
            this.cbbqtdpessoas.TabIndex = 55;
            this.cbbqtdpessoas.SelectedIndexChanged += new System.EventHandler(this.cbbqtdpessoas_SelectedIndexChanged);
            // 
            // txtNome1
            // 
            this.txtNome1.Location = new System.Drawing.Point(71, 63);
            this.txtNome1.Name = "txtNome1";
            this.txtNome1.Size = new System.Drawing.Size(108, 20);
            this.txtNome1.TabIndex = 57;
            this.txtNome1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtNome1_MouseClick);
            // 
            // lblNome1
            // 
            this.lblNome1.AutoSize = true;
            this.lblNome1.Location = new System.Drawing.Point(27, 66);
            this.lblNome1.Name = "lblNome1";
            this.lblNome1.Size = new System.Drawing.Size(38, 13);
            this.lblNome1.TabIndex = 56;
            this.lblNome1.Text = "Nome:";
            // 
            // txtNome2
            // 
            this.txtNome2.Location = new System.Drawing.Point(71, 89);
            this.txtNome2.Name = "txtNome2";
            this.txtNome2.Size = new System.Drawing.Size(108, 20);
            this.txtNome2.TabIndex = 59;
            this.txtNome2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtNome2_MouseClick);
            // 
            // lblNome2
            // 
            this.lblNome2.AutoSize = true;
            this.lblNome2.Location = new System.Drawing.Point(27, 92);
            this.lblNome2.Name = "lblNome2";
            this.lblNome2.Size = new System.Drawing.Size(38, 13);
            this.lblNome2.TabIndex = 58;
            this.lblNome2.Text = "Nome:";
            // 
            // txtNome3
            // 
            this.txtNome3.Location = new System.Drawing.Point(71, 115);
            this.txtNome3.Name = "txtNome3";
            this.txtNome3.Size = new System.Drawing.Size(108, 20);
            this.txtNome3.TabIndex = 61;
            this.txtNome3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtNome3_MouseClick);
            // 
            // lblNome3
            // 
            this.lblNome3.AutoSize = true;
            this.lblNome3.Location = new System.Drawing.Point(27, 118);
            this.lblNome3.Name = "lblNome3";
            this.lblNome3.Size = new System.Drawing.Size(38, 13);
            this.lblNome3.TabIndex = 60;
            this.lblNome3.Text = "Nome:";
            // 
            // btnRegistar
            // 
            this.btnRegistar.Location = new System.Drawing.Point(35, 231);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(88, 32);
            this.btnRegistar.TabIndex = 62;
            this.btnRegistar.Text = "Registar";
            this.btnRegistar.UseVisualStyleBackColor = true;
            this.btnRegistar.Click += new System.EventHandler(this.btnRegistar_Click);
            // 
            // btnRegistar_Utente
            // 
            this.btnRegistar_Utente.Location = new System.Drawing.Point(129, 231);
            this.btnRegistar_Utente.Name = "btnRegistar_Utente";
            this.btnRegistar_Utente.Size = new System.Drawing.Size(100, 32);
            this.btnRegistar_Utente.TabIndex = 63;
            this.btnRegistar_Utente.Text = "Registar_Utente";
            this.btnRegistar_Utente.UseVisualStyleBackColor = true;
            this.btnRegistar_Utente.Click += new System.EventHandler(this.btnRegistar_Utente_Click);
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(30, 196);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(43, 13);
            this.lblCampo.TabIndex = 64;
            this.lblCampo.Text = "Campo:";
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
            this.cbbcampo.Location = new System.Drawing.Point(79, 193);
            this.cbbcampo.Name = "cbbcampo";
            this.cbbcampo.Size = new System.Drawing.Size(74, 21);
            this.cbbcampo.TabIndex = 65;
            // 
            // btnSeguinte
            // 
            this.btnSeguinte.Location = new System.Drawing.Point(311, 231);
            this.btnSeguinte.Name = "btnSeguinte";
            this.btnSeguinte.Size = new System.Drawing.Size(70, 32);
            this.btnSeguinte.TabIndex = 67;
            this.btnSeguinte.Text = "->";
            this.btnSeguinte.UseVisualStyleBackColor = true;
            this.btnSeguinte.Click += new System.EventHandler(this.btnSeguinte_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(234, 231);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(71, 32);
            this.btnAnterior.TabIndex = 66;
            this.btnAnterior.Text = "<-";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // frmAluguer_Ténis
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
            this.Name = "frmAluguer_Ténis";
            this.Text = "Alguer_Campo_Ténis";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAlguer_Ténis_FormClosing);
            this.Load += new System.EventHandler(this.frmAlguer_Ténis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupMFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupHFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMinicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupHinicial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblHorário;
        private System.Windows.Forms.Label labelas;
        private System.Windows.Forms.NumericUpDown nupMFinal;
        private System.Windows.Forms.NumericUpDown nupHFinal;
        private System.Windows.Forms.NumericUpDown nupMinicial;
        private System.Windows.Forms.NumericUpDown nupHinicial;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblqtdspessoas;
        private System.Windows.Forms.ComboBox cbbqtdpessoas;
        private System.Windows.Forms.TextBox txtNome1;
        private System.Windows.Forms.Label lblNome1;
        private System.Windows.Forms.TextBox txtNome2;
        private System.Windows.Forms.Label lblNome2;
        private System.Windows.Forms.TextBox txtNome3;
        private System.Windows.Forms.Label lblNome3;
        private System.Windows.Forms.Button btnRegistar;
        private System.Windows.Forms.Button btnRegistar_Utente;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.ComboBox cbbcampo;
        private System.Windows.Forms.Button btnSeguinte;
        private System.Windows.Forms.Button btnAnterior;
    }
}