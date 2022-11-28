namespace PAP
{
    partial class frmConsumo
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
            this.lstConsumo = new System.Windows.Forms.ListView();
            this.cl_id_Consumo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_id_prof = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_id_func = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_TipoConsumo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Desporto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Campo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_dia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_HoraInic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_HoraFim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_preço = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Estado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblmostratoral = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstConsumo
            // 
            this.lstConsumo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl_id_Consumo,
            this.cl_id_prof,
            this.cl_id_func,
            this.cl_TipoConsumo,
            this.cl_Desporto,
            this.cl_Campo,
            this.cl_dia,
            this.cl_HoraInic,
            this.cl_HoraFim,
            this.cl_preço,
            this.cl_Estado});
            this.lstConsumo.Enabled = false;
            this.lstConsumo.FullRowSelect = true;
            this.lstConsumo.GridLines = true;
            this.lstConsumo.Location = new System.Drawing.Point(22, 57);
            this.lstConsumo.Name = "lstConsumo";
            this.lstConsumo.Size = new System.Drawing.Size(672, 181);
            this.lstConsumo.TabIndex = 0;
            this.lstConsumo.UseCompatibleStateImageBehavior = false;
            this.lstConsumo.View = System.Windows.Forms.View.Details;
            this.lstConsumo.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstConsumo_ItemSelectionChanged);
            // 
            // cl_id_Consumo
            // 
            this.cl_id_Consumo.Text = "Id_Consumo";
            this.cl_id_Consumo.Width = 72;
            // 
            // cl_id_prof
            // 
            this.cl_id_prof.Text = "id_prof";
            this.cl_id_prof.Width = 44;
            // 
            // cl_id_func
            // 
            this.cl_id_func.Text = "id_func";
            this.cl_id_func.Width = 50;
            // 
            // cl_TipoConsumo
            // 
            this.cl_TipoConsumo.Text = "TipoConsumo";
            this.cl_TipoConsumo.Width = 77;
            // 
            // cl_Desporto
            // 
            this.cl_Desporto.Text = "Desporto";
            this.cl_Desporto.Width = 56;
            // 
            // cl_Campo
            // 
            this.cl_Campo.Text = "Campo";
            this.cl_Campo.Width = 47;
            // 
            // cl_dia
            // 
            this.cl_dia.Text = "Dia";
            this.cl_dia.Width = 90;
            // 
            // cl_HoraInic
            // 
            this.cl_HoraInic.Text = "Hora_Inic";
            this.cl_HoraInic.Width = 65;
            // 
            // cl_HoraFim
            // 
            this.cl_HoraFim.Text = "Hora_Fim";
            this.cl_HoraFim.Width = 63;
            // 
            // cl_preço
            // 
            this.cl_preço.Text = "Preço";
            this.cl_preço.Width = 46;
            // 
            // cl_Estado
            // 
            this.cl_Estado.Text = "Estado";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(46, 25);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(88, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome do Utente:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(140, 22);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 2;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // btnPagar
            // 
            this.btnPagar.Enabled = false;
            this.btnPagar.Location = new System.Drawing.Point(455, 269);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(88, 34);
            this.btnPagar.TabIndex = 3;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(149, 280);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(13, 13);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "0";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(342, 269);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(88, 34);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblmostratoral
            // 
            this.lblmostratoral.AutoSize = true;
            this.lblmostratoral.Location = new System.Drawing.Point(46, 280);
            this.lblmostratoral.Name = "lblmostratoral";
            this.lblmostratoral.Size = new System.Drawing.Size(97, 13);
            this.lblmostratoral.TabIndex = 6;
            this.lblmostratoral.Text = "Total de despesas:";
            // 
            // frmConsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 318);
            this.Controls.Add(this.lblmostratoral);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lstConsumo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsumo";
            this.Text = "frmConsumo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConsumo_FormClosing);
            this.Load += new System.EventHandler(this.frmConsumo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstConsumo;
        private System.Windows.Forms.ColumnHeader cl_id_Consumo;
        private System.Windows.Forms.ColumnHeader cl_id_prof;
        private System.Windows.Forms.ColumnHeader cl_id_func;
        private System.Windows.Forms.ColumnHeader cl_TipoConsumo;
        private System.Windows.Forms.ColumnHeader cl_Desporto;
        private System.Windows.Forms.ColumnHeader cl_Campo;
        private System.Windows.Forms.ColumnHeader cl_dia;
        private System.Windows.Forms.ColumnHeader cl_HoraInic;
        private System.Windows.Forms.ColumnHeader cl_HoraFim;
        private System.Windows.Forms.ColumnHeader cl_preço;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblmostratoral;
        private System.Windows.Forms.ColumnHeader cl_Estado;
    }
}