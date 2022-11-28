using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Threading;

namespace PAP
{
    public partial class frmRegistLogin : Form
    {
        Thread th;
        public frmRegistLogin()
        {
            InitializeComponent();
        }
        private void Register_Load(object sender, EventArgs e)
        {         
        }
        private bool check()
        {            
            bool val = true; ;
            SqlConnection connect1 = new SqlConnection(Properties.Resources.Connect);           
            connect1.Open();
            SqlCommand cmd = connect1.CreateCommand();
            cmd.CommandText = "SELECT Username,Email from Funcionario";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetString(0) == txtUser.Text || reader.GetString(1) == txtEmail.Text || reader.GetString(0) == null || reader.GetString(1) == null)
                    val = false;
            }
            connect1.Close();
            reader.Close();
            if (val == false)
                return false;
            else
                return true;
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            if (txtnome.Text != null || txtPass.Text != null || txtData_Nasc.Text != null || txtUser.Text != null || txtEmail.Text != null || txtApelido.Text != null || cbbTipo.SelectedItem != null) 
            {
                try
                {
                    SqlConnection connect = new SqlConnection(Properties.Resources.Connect);
                    //SqlConnection connect = new SqlConnection(Properties.Resources.Connect1);
                    connect.Open();
                    SqlCommand cmd = connect.CreateCommand();
                    if (check() == true)
                    {
                        cmd.CommandText = "dbo.Registar";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Username", txtUser.Text);
                        cmd.Parameters.AddWithValue("@Password", Encrypt(txtPass.Text));
                        cmd.Parameters.AddWithValue("@First_Name", txtnome.Text);
                        cmd.Parameters.AddWithValue("@Last_Name ", txtApelido.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@Telefone",txtTelefone.Text);                        
                        cmd.Parameters.AddWithValue("@Data_de_Nascimento", Convert.ToDateTime(txtData_Nasc.Text).Date);
                        cmd.Parameters.AddWithValue("@Morada", txtMorada.Text);
                        cmd.Parameters.AddWithValue("@Tipo_func", cbbTipo.SelectedItem);                        
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User adicionado à BD");
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
        static string Encrypt(string value)//Encriptar a password
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }       
        private void Limpeza()
        {
            txtEmail.Text = "";
            txtApelido.Text = "";
            txtnome.Text = "";
            txtPass.Text = "";
            txtUser.Text = "";
            txtData_Nasc.Text = "";
            txtTelefone.Text = "";
            txtMorada.Text = "";
            cbbTipo.SelectedItem = null; 
        }
        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((frmMain)this.MdiParent).mnuLogin.Enabled = true;
        }
        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
