namespace PAP
{
    partial class frmPreço
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
            this.lblDesporto = new System.Windows.Forms.Label();
            this.lblpreço = new System.Windows.Forms.Label();
            this.lblQtd = new System.Windows.Forms.Label();
            this.cbbDesporto = new System.Windows.Forms.ComboBox();
            this.txtpreço = new System.Windows.Forms.TextBox();
            this.cbbqtd = new System.Windows.Forms.ComboBox();
            this.btnregist_preço = new System.Windows.Forms.Button();
            this.lblTipo_Consumo = new System.Windows.Forms.Label();
            this.cbbTipo_Consumo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblDesporto
            // 
            this.lblDesporto.AutoSize = true;
            this.lblDesporto.Location = new System.Drawing.Point(13, 47);
            this.lblDesporto.Name = "lblDesporto";
            this.lblDesporto.Size = new System.Drawing.Size(53, 13);
            this.lblDesporto.TabIndex = 0;
            this.lblDesporto.Text = "Desporto:";
            // 
            // lblpreço
            // 
            this.lblpreço.AutoSize = true;
            this.lblpreço.Location = new System.Drawing.Point(13, 74);
            this.lblpreço.Name = "lblpreço";
            this.lblpreço.Size = new System.Drawing.Size(38, 13);
            this.lblpreço.TabIndex = 1;
            this.lblpreço.Text = "Preço:";
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Location = new System.Drawing.Point(12, 99);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(62, 13);
            this.lblQtd.TabIndex = 2;
            this.lblQtd.Text = "Quantidade";
            // 
            // cbbDesporto
            // 
            this.cbbDesporto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDesporto.FormattingEnabled = true;
            this.cbbDesporto.Items.AddRange(new object[] {
            "Ténis",
            "Padel",
            "Squash"});
            this.cbbDesporto.Location = new System.Drawing.Point(72, 44);
            this.cbbDesporto.Name = "cbbDesporto";
            this.cbbDesporto.Size = new System.Drawing.Size(99, 21);
            this.cbbDesporto.TabIndex = 3;
            // 
            // txtpreço
            // 
            this.txtpreço.Location = new System.Drawing.Point(57, 71);
            this.txtpreço.Name = "txtpreço";
            this.txtpreço.Size = new System.Drawing.Size(100, 20);
            this.txtpreço.TabIndex = 4;
            // 
            // cbbqtd
            // 
            this.cbbqtd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbqtd.FormattingEnabled = true;
            this.cbbqtd.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbbqtd.Location = new System.Drawing.Point(80, 96);
            this.cbbqtd.Name = "cbbqtd";
            this.cbbqtd.Size = new System.Drawing.Size(38, 21);
            this.cbbqtd.TabIndex = 5;
            // 
            // btnregist_preço
            // 
            this.btnregist_preço.Location = new System.Drawing.Point(162, 131);
            this.btnregist_preço.Name = "btnregist_preço";
            this.btnregist_preço.Size = new System.Drawing.Size(96, 40);
            this.btnregist_preço.TabIndex = 6;
            this.btnregist_preço.Text = "Registar";
            this.btnregist_preço.UseVisualStyleBackColor = true;
            this.btnregist_preço.Click += new System.EventHandler(this.btnregist_preço_Click);
            // 
            // lblTipo_Consumo
            // 
            this.lblTipo_Consumo.AutoSize = true;
            this.lblTipo_Consumo.Location = new System.Drawing.Point(13, 18);
            this.lblTipo_Consumo.Name = "lblTipo_Consumo";
            this.lblTipo_Consumo.Size = new System.Drawing.Size(81, 13);
            this.lblTipo_Consumo.TabIndex = 7;
            this.lblTipo_Consumo.Text = "Tipo_Consumo:";
            // 
            // cbbTipo_Consumo
            // 
            this.cbbTipo_Consumo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTipo_Consumo.FormattingEnabled = true;
            this.cbbTipo_Consumo.Items.AddRange(new object[] {
            "Aula",
            "Aluguer"});
            this.cbbTipo_Consumo.Location = new System.Drawing.Point(97, 15);
            this.cbbTipo_Consumo.Name = "cbbTipo_Consumo";
            this.cbbTipo_Consumo.Size = new System.Drawing.Size(89, 21);
            this.cbbTipo_Consumo.TabIndex = 8;
            this.cbbTipo_Consumo.SelectedIndexChanged += new System.EventHandler(this.cbbTipo_Consumo_SelectedIndexChanged);
            // 
            // frmPreço
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 193);
            this.Controls.Add(this.cbbTipo_Consumo);
            this.Controls.Add(this.lblTipo_Consumo);
            this.Controls.Add(this.btnregist_preço);
            this.Controls.Add(this.cbbqtd);
            this.Controls.Add(this.txtpreço);
            this.Controls.Add(this.cbbDesporto);
            this.Controls.Add(this.lblQtd);
            this.Controls.Add(this.lblpreço);
            this.Controls.Add(this.lblDesporto);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPreço";
            this.Text = "Preço";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPreço_Aulas_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDesporto;
        private System.Windows.Forms.Label lblpreço;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.ComboBox cbbDesporto;
        private System.Windows.Forms.TextBox txtpreço;
        private System.Windows.Forms.ComboBox cbbqtd;
        private System.Windows.Forms.Button btnregist_preço;
        private System.Windows.Forms.Label lblTipo_Consumo;
        private System.Windows.Forms.ComboBox cbbTipo_Consumo;
    }
}