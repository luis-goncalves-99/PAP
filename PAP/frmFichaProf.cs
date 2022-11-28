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
    public partial class frmFichaProf : Form
    {
        string result;
        int pos;
        public frmFichaProf()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connect = new SqlConnection(Properties.Resources.Connect);
                //SqlConnection connect = new SqlConnection(Properties.Resources.Connect1);
                connect.Open();
                SqlCommand cmd = connect.CreateCommand();
                cmd.CommandText = "dbo.UpdateProf";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nome", txtnome.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);                
                cmd.Parameters.AddWithValue("Telefone", Convert.ToInt32(txtTelefone.Text));
                cmd.Parameters.AddWithValue("Morada", txtMorada.Text);
                cmd.Parameters.AddWithValue("Id_func", Program.user);
                cmd.Parameters.AddWithValue("Cod_Postal", txtCod_Postal.Text);
                cmd.Parameters.AddWithValue("@id_prof", Convert.ToInt32(txtId_Prof.Text));
                cmd.Parameters.AddWithValue("@Desporto", Convert.ToInt32(txtId_Prof.Text));
                cmd.ExecuteNonQuery();
                Limpeza();
                Hide();
                btnConfirmar.Enabled = false;
                btnApagar.Enabled = false;
                MessageBox.Show("Professor Atualizado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void frmNewProf_Load(object sender, EventArgs e)
        {
            btnApagar.Enabled = false;
            btnConfirmar.Enabled = false;
            Hide();
        }
        private void txtnome_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SqlConnection connect = new SqlConnection(Properties.Resources.Connect);
            //SqlConnection connect = new SqlConnection(Properties.Resources.Connect1);
            connect.Open();
            SqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "Select id_prof, Email, Telefone, Morada, Cod_Postal,Desporto from Professor where Nome ='" + txtnome.Text + "'";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {                                           
                txtId_Prof.Enabled = true;
                txtEmail.Enabled = true;                
                txtTelefone.Enabled = true;
                txtMorada.Enabled = true;
                txtCod_Postal.Enabled = true;
                result = reader.GetString(5);
                txtMorada.Text = reader.GetString(3);
                txtTelefone.Text = reader.GetInt32(2).ToString();
                txtId_Prof.Text = reader.GetInt32(0).ToString();
                txtEmail.Text = reader.GetString(1);
                txtCod_Postal.Text = reader.GetString(4);
                cbbDesporto.SelectedItem = reader.GetString(7);
                btnApagar.Enabled = true;
                btnConfirmar.Enabled = true;
                pos = Convert.ToInt32(txtId_Prof.Text);
                result = "";
                return;
            }
            Limpeza();
            Hide();
            btnApagar.Enabled = false;
            btnConfirmar.Enabled = false;
        }
        private int check1()
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
        private void Limpeza()
        {
            txtnome.Text = "";
            txtId_Prof.Text = "";
            txtEmail.Text = "";            
            txtTelefone.Text = "";
            txtMorada.Text = "";
            txtCod_Postal.Text = "";
        }
        private void Hide()
        {
            txtId_Prof.Enabled = false;
            txtEmail.Enabled = false;            
            txtTelefone.Enabled = false;
            txtMorada.Enabled = false;
            txtCod_Postal.Enabled = false;
        }

        private void frmListagemProf_FormClosing(object sender, FormClosingEventArgs e)
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


        private void btnApagar_Click(object sender, EventArgs e)
        {
            //Program.user = "luis";
            int qtd = check1();
            int pos = Convert.ToInt32(txtId_Prof.Text);
            int idx1;
            try
            {
                SqlConnection connect = new SqlConnection(Properties.Resources.Connect);
                //SqlConnection connect = new SqlConnection(Properties.Resources.Connect1);
                connect.Open();
                SqlCommand cmd = connect.CreateCommand();
                cmd.CommandText = "dbo.del_Prof";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_prof", Convert.ToInt32(txtId_Prof.Text));                
                cmd.ExecuteNonQuery();
                connect.Close();
                Limpeza();
                Hide();
                MessageBox.Show("Professor apagado");
                btnApagar.Enabled = false;
                btnConfirmar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if(qtd > pos)
            {
                for(int idx = pos; idx < qtd;)
                {
                    try
                    {
                        SqlConnection connect = new SqlConnection(Properties.Resources.Connect);
                        //SqlConnection connect = new SqlConnection(Properties.Resources.Connect1);
                        connect.Open();
                        SqlCommand cmd = connect.CreateCommand();
                        idx1 = idx + 1;
                        cmd.CommandText = "UPDATE Professor SET Id_prof="+ idx + " where Id_prof ='" +idx1+ "'";
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
            cmd.CommandText = "Select Nome, Email, Telefone, Morada, Cod_Postal,Desporto from Professor where id_prof ='" + pos + "'";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtId_Prof.Enabled = true;
                txtEmail.Enabled = true;                
                txtTelefone.Enabled = true;
                txtMorada.Enabled = true;
                txtCod_Postal.Enabled = true;
                result = reader.GetString(5);
                txtMorada.Text = reader.GetString(3);
                txtTelefone.Text = reader.GetInt32(2).ToString();
                txtId_Prof.Text = pos.ToString();
                txtnome.Text = reader.GetString(0);
                txtEmail.Text = reader.GetString(1);
                txtCod_Postal.Text = reader.GetString(4);
                cbbDesporto.SelectedItem = reader.GetString(7);
                btnApagar.Enabled = true;
                btnConfirmar.Enabled = true;
                result = "";
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
            if (pos > 1 && pos < check1())
            {
                pos = pos + 1;
            }
            else
            {
                pos = check1();
            }
            cmd.CommandText = "Select Nome, Email, Telefone, Morada, Cod_Postal,Desporto from Professor where id_prof ='" + pos + "'";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtId_Prof.Enabled = true;
                txtEmail.Enabled = true;                
                txtTelefone.Enabled = true;
                txtMorada.Enabled = true;
                txtCod_Postal.Enabled = true;
                result = reader.GetString(5);
                txtMorada.Text = reader.GetString(3);
                txtTelefone.Text = reader.GetInt32(2).ToString();
                txtId_Prof.Text = pos.ToString();
                txtnome.Text = reader.GetString(0);
                txtEmail.Text = reader.GetString(1);
                txtCod_Postal.Text = reader.GetString(4);
                cbbDesporto.SelectedItem = reader.GetString(7);
                btnApagar.Enabled = true;
                btnConfirmar.Enabled = true;
                result = "";
                return;
            }
            Limpeza();
            Hide();
            btnApagar.Enabled = false;
            btnConfirmar.Enabled = false;
        }

        private void lblHorário_Semanal_Click(object sender, EventArgs e)
        {

        }
        private void lba_Click(object sender, EventArgs e)
        {

        }
    }
}
