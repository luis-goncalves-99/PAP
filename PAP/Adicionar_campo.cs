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
    public partial class frmAdcionar_campo : Form
    {
        int qtd1;
        public frmAdcionar_campo()
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
            cmd.CommandText = "SELECT Nome,Nome_Desporto from Campo";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetString(1) == cbbDesporto.SelectedItem.ToString() && reader.GetString(0) == cbbCampo.SelectedItem.ToString() || reader.GetString(0) == null && reader.GetString(1) == null)
                    val = false;
            }
            connect1.Close();
            reader.Close();
            if (val == false)
                return false;
            else
                return true;
        }
        private int check1()
        {
            int qtd;
            SqlConnection connect1 = new SqlConnection(Properties.Resources.Connect);
            //SqlConnection connect1 = new SqlConnection(Properties.Resources.Connect1);
            connect1.Open();
            SqlCommand cmd = connect1.CreateCommand();
            cmd.CommandText = "SELECT COUNT(Nome)FROM Campo";
            qtd = (int)cmd.ExecuteScalar();
            connect1.Close();
            return qtd;
        }

        private void btnRegistar_campo_Click(object sender, EventArgs e)
        {
            if (cbbDesporto.SelectedItem != null ||  cbbCampo.SelectedItem != null)
            {
                try
                {
                    qtd1 = check1();
                    SqlConnection connect = new SqlConnection(Properties.Resources.Connect);
                    //SqlConnection connect = new SqlConnection(Properties.Resources.Connect1);
                    connect.Open();
                    SqlCommand cmd = connect.CreateCommand();
                    if (check() == true)
                    {
                        qtd1 = qtd1 + 1;
                        cmd.CommandText = "dbo.Regist_Campo";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_Campo", qtd1);
                        cmd.Parameters.AddWithValue("@Nome", cbbCampo.SelectedItem);
                        cmd.Parameters.AddWithValue("@Nome_Desporto", cbbDesporto.SelectedItem);
                        cmd.Parameters.AddWithValue("@id_func", Program.user);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Campo adicionado à BD");
                        connect.Close();
                        Limpeza();
                    }
                    else
                    {
                        MessageBox.Show("O nome do campo associado a esse desporto já existe na base de dados porfavor insira  ");
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
            cbbCampo.SelectedItem = null;            
            cbbDesporto.SelectedItem = null;
        }
        private void frmAdcionar_campo_FormClosing(object sender, FormClosingEventArgs e)
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
