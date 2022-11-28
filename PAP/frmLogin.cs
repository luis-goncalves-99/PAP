using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace PAP
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Close();
            frmRegistLogin reg = new frmRegistLogin();
            reg.Show();
        }
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((frmMain)this.MdiParent).mnuLogin.Enabled = true;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Erro tem de preencher os dois campos");
                txtPass.Text = "";
                txtUser.Text = "";
                return;
            }
            else
            {
                try
                {
                    SqlConnection connect = new SqlConnection(Properties.Resources.Connect);
                    connect.Open();
                    MessageBox.Show("Conetado à BD");
                    SqlCommand cmd = connect.CreateCommand();
                    cmd.CommandText = "dbo.loginar";
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = cmd.ExecuteReader();
                    int login = 0;
                    while (reader.Read())
                    {
                        string teste = Encrypt(txtPass.Text);
                        if (txtUser.Text == reader.GetString(0) && teste == reader.GetString(1))
                        {
                            login = 1;
                            Program.user = reader.GetString(0);
                            Program.tipo_user = reader.GetString(2);
                            if (Program.tipo_user == "Administrador")
                            {
                                ((frmMain)this.MdiParent).tsLogin.Enabled = false;
                                ((frmMain)this.MdiParent).tsLogout.Enabled = true;
                                ((frmMain)this.MdiParent).tsRegister.Enabled = true;
                                ((frmMain)this.MdiParent).mnuUtentes.Enabled = true;
                                ((frmMain)this.MdiParent).mnuProfessores.Enabled = true;
                                ((frmMain)this.MdiParent).mnuAulas.Enabled = true;
                                ((frmMain)this.MdiParent).mnuCampos.Enabled = true;
                                ((frmMain)this.MdiParent).mnuAulas.Enabled = true;
                                ((frmMain)this.MdiParent).mnuPreços.Enabled = true;
                                ((frmMain)this.MdiParent).tsLogout.Enabled = true;
                                this.Close();
                                return;
                            }
                            else
                            {
                                ((frmMain)this.MdiParent).tsLogin.Enabled = false;
                                ((frmMain)this.MdiParent).tsLogout.Enabled = true;
                                ((frmMain)this.MdiParent).tsRegister.Enabled = false;
                                ((frmMain)this.MdiParent).mnuUtentes.Enabled = true;
                                ((frmMain)this.MdiParent).mnuProfessores.Enabled = true;
                                ((frmMain)this.MdiParent).mnuAulas.Enabled = true;
                                ((frmMain)this.MdiParent).mnuCampos.Enabled = true;
                                ((frmMain)this.MdiParent).mnuAulas.Enabled = true;
                                ((frmMain)this.MdiParent).tsLogout.Enabled = true;
                                this.Close();
                                return;
                            }
                        }
                    }
                    reader.Close();
                    if (login != 1)
                    {
                        MessageBox.Show("Username ou Password Errada");
                        txtUser.Text = "";
                        txtPass.Text = "";
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {

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
    }
}  
