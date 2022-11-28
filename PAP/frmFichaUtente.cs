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
    public partial class frmFichaUtente : Form
    {        
        int pos;
        public frmFichaUtente()
        {
            InitializeComponent();
        }
        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void frmListagemUtentes_Load(object sender, EventArgs e)
        {
            pos = 0;                        
            btnApagar.Enabled = false;
            btnConfirmar.Enabled = false;
            Hide();
        }

        private void txtnome_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //SqlConnection connect = new SqlConnection(Properties.Resources.Connect1);
            SqlConnection connect = new SqlConnection(Properties.Resources.Connect);
            connect.Open();
            SqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "Select id_utente, Email, Socio, Telefone, Morada, Cod_Postal from Utente where Nome ='" + txtnome.Text + "'";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtId_Utente.Enabled = true;
                txtEmail.Enabled = true;
                cbbSocio.Enabled = true;
                txtTelefone.Enabled = true;
                txtMorada.Enabled = true;
                txtCod_Postal.Enabled = true;
                txtMorada.Text = reader.GetString(4);
                txtTelefone.Text = reader.GetInt32(3).ToString();
                txtId_Utente.Text = reader.GetInt32(0).ToString();
                txtEmail.Text = reader.GetString(1);
                txtCod_Postal.Text = reader.GetString(5);
                cbbSocio.SelectedItem = reader.GetString(2);
                btnApagar.Enabled = true;
                btnConfirmar.Enabled = true;
                btnAnterior.Enabled = true;
                btnSeguinte.Enabled = true;
                pos = Convert.ToInt32(txtId_Utente.Text);               
                return;
            }
            Limpeza();
            Hide();
            btnApagar.Enabled = false;
            btnConfirmar.Enabled = false;      
         }

        private void Limpeza()
        {
            txtnome.Text = "";
            txtId_Utente.Text ="";
            txtEmail.Text ="";
            cbbSocio.SelectedItem = null;
            txtTelefone.Text = "";
            txtMorada.Text  ="";
            txtCod_Postal.Text = "";
        }
        private void Hide()
        {            
            txtId_Utente.Enabled = false;
            txtEmail.Enabled = false;
            cbbSocio.Enabled=false;
            txtTelefone.Enabled = false;
            txtMorada.Enabled = false;
            txtCod_Postal.Enabled = false;
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                //SqlConnection connect = new SqlConnection(Properties.Resources.Connect1);
                SqlConnection connect = new SqlConnection(Properties.Resources.Connect);
                connect.Open();
                SqlCommand cmd = connect.CreateCommand();
                cmd.CommandText = "dbo.UpdateUtente";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nome",txtnome.Text);
                cmd.Parameters.AddWithValue("@Email",txtEmail.Text);
                cmd.Parameters.AddWithValue("Socio",cbbSocio.SelectedItem);
                cmd.Parameters.AddWithValue("Telefone",Convert.ToInt32(txtTelefone.Text));
                cmd.Parameters.AddWithValue("Morada",txtMorada.Text);                
                cmd.Parameters.AddWithValue("Cod_Postal",txtCod_Postal.Text);
                cmd.Parameters.AddWithValue("@id_func", Program.user);
                cmd.Parameters.AddWithValue("@id_utente", txtId_Utente.Text);
                cmd.ExecuteNonQuery();
                Limpeza();
                Hide();
                btnConfirmar.Enabled = false;
                btnApagar.Enabled = false;
                MessageBox.Show("Utente Atualizado");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }      
        private void btnApagar_Click(object sender, EventArgs e)
        {
            int qtd = checkqtdutente();
            int pos = Convert.ToInt32(txtId_Utente.Text);
            int idx1;
            try
            {
                //SqlConnection connect = new SqlConnection(Properties.Resources.Connect1);
                SqlConnection connect = new SqlConnection(Properties.Resources.Connect);
                connect.Open();
                SqlCommand cmd = connect.CreateCommand();
                cmd.CommandText = "dbo.del_Utente";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_utente", Convert.ToInt32(txtId_Utente.Text));
                cmd.ExecuteNonQuery();                
                connect.Close();
                Limpeza();
                Hide();
                MessageBox.Show("Utente apagado");
                btnApagar.Enabled = false;
                btnConfirmar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (qtd > pos)
            {
                for (int idx = pos; idx < qtd;)
                {
                    try
                    {
                        //SqlConnection connect = new SqlConnection(Properties.Resources.Connect1);
                        SqlConnection connect = new SqlConnection(Properties.Resources.Connect);
                        connect.Open();
                        SqlCommand cmd = connect.CreateCommand();
                        idx1 = idx + 1;
                        cmd.CommandText = "UPDATE Utente SET id_utente=" + idx + " where id_utente ='" + idx1 + "'";
                        cmd.ExecuteNonQuery();
                        connect.Close();
                        idx++;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private int checkqtdutente()
        {
            int qtd;
            SqlConnection connect1 = new SqlConnection(Properties.Resources.Connect);
            //SqlConnection connect1 = new SqlConnection(Properties.Resources.Connect1);
            connect1.Open();
            SqlCommand cmd = connect1.CreateCommand();
            cmd.CommandText = "SELECT COUNT(Nome)FROM utente";
            qtd = (int)cmd.ExecuteScalar();
            connect1.Close();
            return qtd;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {                        
           SqlConnection connect = new SqlConnection(Properties.Resources.Connect);
           //SqlConnection connect = new SqlConnection(Properties.Resources.Connect1);
            connect.Open();
            SqlCommand cmd = connect.CreateCommand();
            if (pos > 1)
            {
                pos = pos - 1;
            }
            else
            {
                pos = 1;
            }
            cmd.CommandText = "Select Nome, Email, Socio, Telefone, Morada, Cod_Postal from Utente where id_utente ='"+pos+"'";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtId_Utente.Enabled = true;
                txtEmail.Enabled = true;
                cbbSocio.Enabled = true;
                txtTelefone.Enabled = true;
                txtMorada.Enabled = true;
                txtCod_Postal.Enabled = true;
                txtMorada.Text = reader.GetString(4);
                txtTelefone.Text = reader.GetInt32(3).ToString();
                txtId_Utente.Text = pos.ToString();
                txtnome.Text = reader.GetString(0);
                txtEmail.Text = reader.GetString(1);
                txtCod_Postal.Text = reader.GetString(5);
                cbbSocio.SelectedItem = reader.GetString(2);
                btnApagar.Enabled = true;
                btnConfirmar.Enabled = true;
                return;
            }
            Limpeza();
            Hide();
            btnApagar.Enabled = false;
            btnConfirmar.Enabled = false;
        }

        private void btnSeguinte_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(Properties.Resources.Connect);
            //SqlConnection connect = new SqlConnection(Properties.Resources.Connect1);
            connect.Open();
            SqlCommand cmd = connect.CreateCommand();
            if (pos > 0 && pos < checkqtdutente())
            {
                pos = pos + 1;
            }
            else
            {
                pos = checkqtdutente();   
            }
            cmd.CommandText = "Select Nome, Email, Socio, Telefone, Morada, Cod_Postal from Utente where id_utente ='" + pos + "'";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtId_Utente.Enabled = true;
                txtEmail.Enabled = true;
                cbbSocio.Enabled = true;
                txtTelefone.Enabled = true;
                txtMorada.Enabled = true;
                txtCod_Postal.Enabled = true;
                txtMorada.Text = reader.GetString(4);
                txtTelefone.Text = reader.GetInt32(3).ToString();
                txtId_Utente.Text = pos.ToString();
                txtnome.Text = reader.GetString(0);
                txtEmail.Text = reader.GetString(1);
                txtCod_Postal.Text = reader.GetString(5);
                cbbSocio.SelectedItem = reader.GetString(2);
                btnApagar.Enabled = true;
                btnConfirmar.Enabled = true;
                return;
            }
            Limpeza();
            Hide();
            btnApagar.Enabled = false;
            btnConfirmar.Enabled = false;

        }
        private void frmListagemUtentes_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
