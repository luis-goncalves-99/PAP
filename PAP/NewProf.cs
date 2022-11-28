using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PAP
{
    public partial class frmNewProf : Form
    {
        int qtd1;
        public frmNewProf()
        {
            InitializeComponent();
        }
        private int checkqtdprof()
        {
            int qtd;
            SqlConnection connect1 = new SqlConnection(Properties.Resources.Connect);
            //SqlConnection connect1 = new SqlConnection(Properties.Resources.Connect1);
            connect1.Open();
            SqlCommand cmd = connect1.CreateCommand();
            cmd.CommandText = "SELECT COUNT(Nome)FROM Professor";
            qtd = (int)cmd.ExecuteScalar();
            connect1.Close();
            return qtd;
        }
        private bool check()
        {
            bool val = true; ;
            SqlConnection connect1 = new SqlConnection(Properties.Resources.Connect);
            //SqlConnection connect1 = new SqlConnection(Properties.Resources.Connect1);
            connect1.Open();
            SqlCommand cmd = connect1.CreateCommand();
            cmd.CommandText = "SELECT Nome,Email from Professor";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetString(0) == txtNome.Text || reader.GetString(1) == txtEmail.Text || reader.GetString(0) == null || reader.GetString(1) == null)
                    val = false;
            }           
            connect1.Close();
            reader.Close();
            if (val == false)
                return false;
            else
                return true;
        }
        private void btnRegist_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == null || txtMorada.Text != null || txtEmail.Text != null || txtCod_Postal.Text != null || txtTelefone.Text != null || cbbDesporto.SelectedItem != null)
            {
            try
            {
                qtd1 = checkqtdprof();
                SqlConnection connect = new SqlConnection(Properties.Resources.Connect);
                //SqlConnection connect = new SqlConnection(Properties.Resources.Connect1);
                connect.Open();
                SqlCommand cmd = connect.CreateCommand();
                if (check() == true)
                {
                    qtd1 = qtd1 + 1;
                    cmd.CommandText = "dbo.Regist_Prof";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_prof", qtd1);
                    cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);                    
                    cmd.Parameters.AddWithValue("@Telefone",Convert.ToInt32(txtTelefone.Text));
                    cmd.Parameters.AddWithValue("@Morada", txtMorada.Text);
                    cmd.Parameters.AddWithValue("@Id_func", Program.user);
                    cmd.Parameters.AddWithValue("@Cod_Postal", txtCod_Postal.Text);
                    cmd.Parameters.AddWithValue("@Desporto",cbbDesporto.SelectedItem);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Professor adicionado à BD");
                    connect.Close();
                    Limpeza();
                }
                else
                {
                    MessageBox.Show("O Username ou Email já existe na base de dados porfavor insira outro");
                    Limpeza();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                Limpeza();
            }
            }
             else
            MessageBox.Show("Preencha os campos obrigatórios");
        }
        private void Limpeza()
        {
            txtNome.Text = "";
            txtMorada.Text = "";
            txtCod_Postal.Text = "";
            txtTelefone.Text = "";
            txtEmail.Text = "";
            cbbDesporto.SelectedItem = null;
        }

        private void NewProf_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.tipo_user == "Administrador")
            {
                ((frmMain)this.MdiParent).mnuLogin.Enabled = true;
                ((frmMain)this.MdiParent).mnuUtentes.Enabled = true;
                ((frmMain)this.MdiParent).mnuProfessores.Enabled = true;
                ((frmMain)this.MdiParent).mnuAulas.Enabled = true;
                ((frmMain)this.MdiParent).mnuCampos.Enabled = true;
                ((frmMain)this.MdiParent).mnuPreços.Enabled = true;
            }
            else
            {
                ((frmMain)this.MdiParent).mnuLogin.Enabled = true;
                ((frmMain)this.MdiParent).mnuUtentes.Enabled = true;
                ((frmMain)this.MdiParent).mnuProfessores.Enabled = true;
                ((frmMain)this.MdiParent).mnuAulas.Enabled = true;
                ((frmMain)this.MdiParent).mnuCampos.Enabled = true;
            }
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void frmNewProf_Load(object sender, EventArgs e)
        {
        }

        private void lba_Click(object sender, EventArgs e)
        {

        }
    }
}
