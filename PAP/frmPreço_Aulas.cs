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
    public partial class frmPreço : Form
    {
        int qtd1;
        public frmPreço()
        {
            InitializeComponent();
        }
        private bool check()
        {
            bool val = true;
            SqlConnection connect1 = new SqlConnection(Properties.Resources.Connect);
            //SqlConnection connect1 = new SqlConnection(Properties.Resources.Connect1);
            connect1.Open();
            SqlCommand cmd = connect1.CreateCommand();
            cmd.CommandText = "SELECT id_desporto,qtd_elementos from Preço";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetInt32(1) == Convert.ToInt32(cbbqtd.SelectedItem) && reader.GetString(0) == cbbDesporto.SelectedItem.ToString() || reader.GetString(0) == null && reader.GetString(1) == null)
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
            cmd.CommandText = "SELECT COUNT(id_preço)FROM Preço";
            qtd = (int)cmd.ExecuteScalar();
            connect1.Close();
            return qtd;
        }

        private void btnregist_preço_Click(object sender, EventArgs e)
        {
            if (cbbDesporto.SelectedItem != null || cbbqtd.SelectedItem != null)
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
                        cmd.CommandText = "dbo.Regist_Preços";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_preço", qtd1);
                        cmd.Parameters.AddWithValue("@id_desporto", cbbDesporto.SelectedItem);
                        cmd.Parameters.AddWithValue("@tipo_consumo", cbbTipo_Consumo.SelectedItem);                        
                        cmd.Parameters.AddWithValue("@preço", Convert.ToInt32(txtpreço.Text));
                        cmd.Parameters.AddWithValue("@qtd_elementos", Convert.ToInt32(cbbqtd.SelectedItem));
                        cmd.Parameters.AddWithValue("@id_func", Program.user);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Preço adicionado à BD");
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
            cbbqtd.SelectedItem = null;
            cbbDesporto.SelectedItem = null;
            txtpreço.Text = "";
            cbbTipo_Consumo.SelectedItem = null;
        }
        private void frmPreço_Aulas_FormClosing(object sender, FormClosingEventArgs e)
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

        private void cbbTipo_Consumo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbTipo_Consumo.SelectedItem=="Aula")
            {
                cbbqtd.Items.Clear();
                cbbqtd.Items.Add("1");
            }
            else
            {
                cbbqtd.Items.Clear();
                cbbqtd.Items.Add("2");
                cbbqtd.Items.Add("3");
                cbbqtd.Items.Add("4");
            }
        }
    }
}
