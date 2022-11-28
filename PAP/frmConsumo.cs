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
    public partial class frmConsumo : Form
    {
        int qtd1;
        int t = 0;
        int id_consumo;
        int indice;
        public frmConsumo()
        {
            InitializeComponent();
        }

        private void frmConsumo_Load(object sender, EventArgs e)
        {

        }
        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            btnConfirmar.Enabled = true;
        }
        private bool check2()
        {
                bool val = true;
                SqlConnection connect1 = new SqlConnection(Properties.Resources.Connect);
                // SqlConnection connect1 = new SqlConnection(Properties.Resources.Connect1);
                connect1.Open();
                SqlCommand cmd = connect1.CreateCommand();
                cmd.CommandText = "SELECT Nome from Utente";
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetString(0) != txtNome.Text)
                        val = false;
                    else
                        return true;
                }
                connect1.Close();
                reader.Close();
                if (val == false)
                    return false;
                else
                    return true;            
        }       

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "")
            {
                if (check2() == true)
                {
                    lstConsumo.Items.Clear();
                    lblTotal.Text = "";
                    try
                    {
                        SqlConnection connect = new SqlConnection(Properties.Resources.Connect);
                        connect.Open();
                        SqlCommand cmd = connect.CreateCommand();
                        cmd.CommandText = "SELECT id_Consumo,id_prof,id_func,Tipo_Consumo,Desporto,id_Campo,Dia,Hora_Inic,Hora_Fim,Preço,Estado from Consumo where Nome='" + txtNome.Text + "'";
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            ListViewItem test = new ListViewItem();
                            test.Text = reader.GetInt32(0).ToString();
                            test.SubItems.Add(reader.GetInt32(1).ToString());
                            test.SubItems.Add(reader.GetString(2));
                            test.SubItems.Add(reader.GetString(3));
                            test.SubItems.Add(reader.GetString(4));
                            test.SubItems.Add(reader.GetInt32(5).ToString());
                            test.SubItems.Add(reader.GetDateTime(6).ToString());
                            test.SubItems.Add(reader.GetString(7));
                            test.SubItems.Add(reader.GetString(8));
                            test.SubItems.Add(reader.GetInt32(9).ToString());
                            test.SubItems.Add(reader.GetString(10));
                            lstConsumo.Items.Add(test);
                            lstConsumo.Enabled = true;
                            total();
                            //txtNome.Text = "";
                        }
                        connect.Close();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
                else
                {
                    MessageBox.Show("O Utente não existe. Porfavor confirme se esta a escrever o nome correto");
                }
            }
            else
            {
                MessageBox.Show("Prerencha a textbox");
                btnConfirmar.Enabled = false;
                btnPagar.Enabled = false;
            }
        }
        private void mostrar()
        {
            lstConsumo.Items.Clear();
            lblTotal.Text = "";              
                    try
                    {
                        SqlConnection connect = new SqlConnection(Properties.Resources.Connect);
                        connect.Open();
                        SqlCommand cmd = connect.CreateCommand();
                        cmd.CommandText = "SELECT id_Consumo,id_prof,id_func,Tipo_Consumo,Desporto,id_Campo,Dia,Hora_Inic,Hora_Fim,Preço,Estado from Consumo where Nome='" + txtNome.Text + "'";
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            ListViewItem test = new ListViewItem();
                            test.Text = reader.GetInt32(0).ToString();
                            test.SubItems.Add(reader.GetInt32(1).ToString());
                            test.SubItems.Add(reader.GetString(2));
                            test.SubItems.Add(reader.GetString(3));
                            test.SubItems.Add(reader.GetString(4));
                            test.SubItems.Add(reader.GetInt32(5).ToString());
                            test.SubItems.Add(reader.GetDateTime(6).ToString());
                            test.SubItems.Add(reader.GetString(7));
                            test.SubItems.Add(reader.GetString(8));
                            test.SubItems.Add(reader.GetInt32(9).ToString());
                            test.SubItems.Add(reader.GetString(10));
                            lstConsumo.Items.Add(test);
                            lstConsumo.Enabled = true;
                            total();                            
                        }
                        connect.Close();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }                           
        }
        private void lstConsumo_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            btnPagar.Enabled = true;

           if(lstConsumo.SelectedItems.Count > 0)
            {
                id_consumo = Convert.ToInt32(lstConsumo.SelectedItems[0].SubItems[0].Text);
            }
            for (int idx = 0; idx < lstConsumo.Items.Count; idx++)
            {
                if (lstConsumo.Items[idx].Text == id_consumo.ToString())
                {
                    indice = idx;
                    break;
                }
            }
        }    
        private void total()
        {
            t = 0;
            for(int idx = 0; idx < lstConsumo.Items.Count;idx++)
            {
                if(lstConsumo.Items[idx].SubItems[10].Text == "Por Pagar")
                {
                    lblTotal.Text = (t += Convert.ToInt32(lstConsumo.Items[0].SubItems[9].Text)).ToString();
                }

            }
        }
        private void btnPagar_Click(object sender, EventArgs e)
        {
           btnPagar.Enabled = false;
            try
            {
                SqlConnection connect = new SqlConnection(Properties.Resources.Connect);
                connect.Open();
                SqlCommand cmd = connect.CreateCommand();
                cmd.CommandText = "dbo.UpdateConsumo";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_Consumo", lstConsumo.Items[indice].Text);
                cmd.Parameters.AddWithValue("@Estado","Pago");
                cmd.ExecuteNonQuery();
                lstConsumo.Items.Clear();
                connect.Close();               
                mostrar();
                MessageBox.Show("Update");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void frmConsumo_FormClosing(object sender, FormClosingEventArgs e)
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
