using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PAP
{
    public partial class frmNovoUtente : Form
    {
        int qtd1;
        public frmNovoUtente()
        {
            InitializeComponent();
        }
        private bool check()
        {
            bool val = true; ;
            SqlConnection connect1 = new SqlConnection(Properties.Resources.Connect);
            //SqlConnection connect1 = new SqlConnection(Properties.Resources.Connect1);
            connect1.Open();
            SqlCommand cmd = connect1.CreateCommand();
            cmd.CommandText = "SELECT Nome,Email from Utente";
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
        private int checkqtdutentes()
        {
            int qtd;          
            SqlConnection connect1 = new SqlConnection(Properties.Resources.Connect);
            //SqlConnection connect1 = new SqlConnection(Properties.Resources.Connect1);
            connect1.Open();
            SqlCommand cmd = connect1.CreateCommand();
            cmd.CommandText = "SELECT COUNT(Nome)FROM Utente";
            qtd = (int)cmd.ExecuteScalar();                                    
            connect1.Close();
            return qtd;                    
        }
        private void btnRegist_Click(object sender, EventArgs e)
        {
           if (txtNome.Text != null || txtMorada.Text != null || txtEmail.Text != null || txtCod_Postal.Text != null || cbbSocio.SelectedItem != null || txtTelefone.Text != null)
           {
                try
                {
                    qtd1 = checkqtdutentes();
                    SqlConnection connect = new SqlConnection(Properties.Resources.Connect);
                    //SqlConnection connect = new SqlConnection(Properties.Resources.Connect1);
                    connect.Open();
                    SqlCommand cmd = connect.CreateCommand();
                    if (check() == true)
                    {                        
                        qtd1 = qtd1 + 1;
                        cmd.CommandText = "dbo.Regist_Utente";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_utente", qtd1); 
                        cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@Socio", cbbSocio.SelectedItem);
                        cmd.Parameters.AddWithValue("@Telefone", txtTelefone.Text);
                        cmd.Parameters.AddWithValue("@Morada", txtMorada.Text);
                        cmd.Parameters.AddWithValue("@Id_func", Program.user);
                        cmd.Parameters.AddWithValue("@Cod_Postal", txtCod_Postal.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Utente adicionado à BD");
                        connect.Close();
                        Limpeza();
                    }
                    else
                    {
                        MessageBox.Show("O Username já existe na base de dados porfavor insira outro");
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
        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void frmNovoUtente_Load(object sender, EventArgs e)
        {

        }

        private void frmNovoUtente_FormClosing(object sender, FormClosingEventArgs e)
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
        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }
        private void Limpeza()
        {
            txtNome.Text = "";
            txtMorada.Text = "";
            txtCod_Postal.Text = "";
            txtTelefone.Text = "";
            txtEmail.Text = "";            
            cbbSocio.SelectedItem = null;
        }

    }
}
