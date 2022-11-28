namespace PAP
{
    partial class frmAdcionar_campo
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
            this.lblDesporto = new System.Windows.Forms.Label();
            this.cbbCampo = new System.Windows.Forms.ComboBox();
            this.btnRegistar_campo = new System.Windows.Forms.Button();
            this.cbbDesporto = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(26, 23);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblDesporto
            // 
            this.lblDesporto.AutoSize = true;
            this.lblDesporto.Location = new System.Drawing.Point(26, 52);
            this.lblDesporto.Name = "lblDesporto";
            this.lblDesporto.Size = new System.Drawing.Size(53, 13);
            this.lblDesporto.TabIndex = 1;
            this.lblDesporto.Text = "Desporto:";
            // 
            // cbbCampo
            // 
            this.cbbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCampo.FormattingEnabled = true;
            this.cbbCampo.Items.AddRange(new object[] {
            "Campo1",
            "Campo2",
            "Campo3",
            "Campo4",
            "Campo5",
            "Campo6",
            "Campo7",
            "Campo8"});
            this.cbbCampo.Location = new System.Drawing.Point(70, 20);
            this.cbbCampo.Name = "cbbCampo";
            this.cbbCampo.Size = new System.Drawing.Size(93, 21);
            this.cbbCampo.TabIndex = 4;
            // 
            // btnRegistar_campo
            // 
            this.btnRegistar_campo.Location = new System.Drawing.Point(171, 85);
            this.btnRegistar_campo.Name = "btnRegistar_campo";
            this.btnRegistar_campo.Size = new System.Drawing.Size(82, 36);
            this.btnRegistar_campo.TabIndex = 5;
            this.btnRegistar_campo.Text = "Registar";
            this.btnRegistar_campo.UseVisualStyleBackColor = true;
            this.btnRegistar_campo.Click += new System.EventHandler(this.btnRegistar_campo_Click);
            // 
            // cbbDesporto
            // 
            this.cbbDesporto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDesporto.FormattingEnabled = true;
            this.cbbDesporto.Items.AddRange(new object[] {
            "Ténis",
            "Padel",
            "Squash"});
            this.cbbDesporto.Location = new System.Drawing.Point(85, 49);
            this.cbbDesporto.Name = "cbbDesporto";
            this.cbbDesporto.Size = new System.Drawing.Size(121, 21);
            this.cbbDesporto.TabIndex = 6;
            // 
            // frmAdcionar_campo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 133);
            this.Controls.Add(this.cbbDesporto);
            this.Controls.Add(this.btnRegistar_campo);
            this.Controls.Add(this.cbbCampo);
            this.Controls.Add(this.lblDesporto);
            this.Controls.Add(this.lblNome);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdcionar_campo";
            this.Text = "Adicionar_campo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdcionar_campo_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblDesporto;
        private System.Windows.Forms.ComboBox cbbCampo;
        private System.Windows.Forms.Button btnRegistar_campo;
        private System.Windows.Forms.ComboBox cbbDesporto;
    }
}