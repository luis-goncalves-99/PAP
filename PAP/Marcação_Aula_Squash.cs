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
    public partial class frmMarcação_Aula_Squash : Form
    {
        string result1;
        string[] strArray;
        string[] strArray1;
        int qtd1;
        int qtd2; 
        int result;
        int result10;
        int pos;
        string textbox;
        int preço;
        public frmMarcação_Aula_Squash()
        {
            InitializeComponent();
        }
        private void teste()
        {
            try
            {
                SqlConnection connect1 = new SqlConnection(Properties.Resources.Connect);
                // SqlConnection connect1 = new SqlConnection(Properties.Resources.Connect1);
                connect1.Open();
                SqlCommand cmd = connect1.CreateCommand();
                cmd.CommandText = "Select id_Campo from Campo where Nome='" + cbbcampo.SelectedItem.ToString() + "'and Nome_Desporto='Squash'";
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result = reader.GetInt32(0);
                }
                connect1.Close();
                reader.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void teste1()
        {
            try
            {
                SqlConnection connect1 = new SqlConnection(Properties.Resources.Connect);
                // SqlConnection connect1 = new SqlConnection(Properties.Resources.Connect1);
                connect1.Open();
                SqlCommand cmd = connect1.CreateCommand();
                cmd.CommandText = "Select Id_prof from Professor where Nome='" + cbbProfessor.SelectedItem.ToString() + "'and Desporto='Squash'";
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result10 = reader.GetInt32(0);
                }
                connect1.Close();
                reader.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private bool check2()
        {
            if (qtd1 == 0)
            {
                return true;
            }
            else
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
        }
        private int check4()
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
        private int check1()
        {
            int qtd;
            SqlConnection connect1 = new SqlConnection(Properties.Resources.Connect);
            //SqlConnection connect1 = new SqlConnection(Properties.Resources.Connect1);
            connect1.Open();
            SqlCommand cmd = connect1.CreateCommand();
            cmd.CommandText = "SELECT COUNT(id_aula)FROM Ocupação_Campos";
            qtd = (int)cmd.ExecuteScalar();
            connect1.Close();
            return qtd;
        }
        private bool check3()
        {
            bool val = true;
            SqlConnection connect1 = new SqlConnection(Properties.Resources.Connect);
            //SqlConnection connect1 = new SqlConnection(Properties.Resources.Connect1);
            connect1.Open();
            SqlCommand cmd = connect1.CreateCommand();
            cmd.CommandText = "SELECT Dia,id_campo,Nome_desporto,Hora_Fim,Hora_Inic,Utente_1 from Ocupação_Campos";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetInt32(1) == result)
                    val = false;
            }
            connect1.Close();
            reader.Close();
            if (val == false)
                return false;
            else
                return true;
        }
        private bool check()
        {
            if (qtd1 == 0)
                return true;
            int Hinic;
            int Minic;
            int HFim;
            int MFim;
            bool val = true;
            SqlConnection connect1 = new SqlConnection(Properties.Resources.Connect);
            //SqlConnection connect1 = new SqlConnection(Properties.Resources.Connect1);
            connect1.Open();
            SqlCommand cmd = connect1.CreateCommand();
            cmd.CommandText = "SELECT Dia,id_campo,Nome_desporto,Hora_Fim,Hora_Inic,Utente_1 from Ocupação_Campos";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                strArray = reader.GetString(3).Split(':');
                strArray1 = reader.GetString(4).Split(':');
                HFim = Convert.ToInt32(strArray[0]);
                MFim = Convert.ToInt32(strArray[1]);
                Hinic = Convert.ToInt32(strArray1[0]);
                Minic = Convert.ToInt32(strArray1[1]);
                DateTime teste = reader.GetDateTime(0);
                int teste1 = reader.GetInt32(1);
                string teste2 = reader.GetString(2);

                if ((reader.GetDateTime(0) == Convert.ToDateTime(dtpData.Value) && reader.GetString(5) == txtNome.Text && // nao pode tar em ccampos diferentes a mesma hora o mesmo utente
                    (((HFim * 60) + (MFim)) == ((nupHFinal.Value * 60) + (nupMFinal.Value)) && ((Hinic * 60) + (Minic)) == ((nupHinicial.Value * 60) + (nupMinicial.Value))) && reader.GetInt32(1) != result)

                    || (reader.GetDateTime(0) == Convert.ToDateTime(dtpData.Value) && reader.GetString(5) != txtNome.Text && (((HFim * 60) + (MFim)) == ((nupHFinal.Value * 60) + (nupMFinal.Value)) &&
                    ((Hinic * 60) + (Minic)) == ((nupHinicial.Value * 60) + (nupMinicial.Value))) && reader.GetInt32(1) == result)// utentes diferentes no mesmo horario nao podem estar no mesmo campo

                    || ((reader.GetDateTime(0) == Convert.ToDateTime(dtpData.Value) //
                    && ((((nupHinicial.Value * 60) + (nupMinicial.Value)) < ((HFim * 60) + (MFim)))
                    && (((nupHinicial.Value * 60) + (nupMinicial.Value)) >= ((Hinic * 60) + (Minic)))) || ((((nupHFinal.Value * 60) + nupMFinal.Value) <= ((HFim * 60) + MFim)) &&
                    (((nupHFinal.Value * 60) + nupMFinal.Value) > ((Hinic * 60) + Minic)))) && reader.GetInt32(1) == result))

                    val = false;
            }
            connect1.Close();
            reader.Close();
            if (val == false)
                return false;
            else
                return true;
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
            cmd.CommandText = "Select Nome from Utente where id_utente ='" + pos + "'";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtNome.Text = reader.GetString(0);
                return;
            }
            Limpeza();
            Hide();
        }
        private void btnSeguinte_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(Properties.Resources.Connect);
            //SqlConnection connect = new SqlConnection(Properties.Resources.Connect1);
            connect.Open();
            SqlCommand cmd = connect.CreateCommand();
            if (pos > 0 && pos < check4())
            {
                pos = pos + 1;
            }
            else
            {
                pos = check4();
            }
            cmd.CommandText = "Select Nome from Utente where id_utente ='" + pos + "'";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtNome.Text = reader.GetString(0);
                return;
            }
            Limpeza();
            Hide();
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            if (((nupHinicial.Value * 60 + nupMinicial.Value) < (nupHFinal.Value * 60 + nupMFinal.Value)))
            {
                try
                {
                    qtd1 = check1();
                    SqlConnection connect = new SqlConnection(Properties.Resources.Connect);
                    //SqlConnection connect = new SqlConnection(Properties.Resources.Connect1);
                    connect.Open();
                    SqlCommand cmd = connect.CreateCommand();
                    teste();
                    teste1();
                    if (check2() == true)
                    {
                        if (check() == true)
                        {
                            Program.user = "luis";
                            qtd1 = qtd1 + 1;
                            cmd.CommandText = "dbo.Regist_Aula";
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_aula", qtd1);
                            cmd.Parameters.AddWithValue("@Nome_desporto", "Squash");
                            cmd.Parameters.AddWithValue("@id_campo", result);
                            cmd.Parameters.AddWithValue("@id_prof", result10);
                            cmd.Parameters.AddWithValue("@id_func", Program.user);
                            cmd.Parameters.AddWithValue("@Utente_1", txtNome.Text);
                            cmd.Parameters.AddWithValue("@Dia", Convert.ToDateTime(dtpData.Value));
                            cmd.Parameters.AddWithValue("@Hora_Inic", (nupHinicial.Value.ToString() + ":" + nupMinicial.Value.ToString()));
                            cmd.Parameters.AddWithValue("@Hora_Fim", (nupHFinal.Value.ToString() + ":" + nupMFinal.Value.ToString()));
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Professor adicionado à BD");
                            connect.Close();
                            Consumo();
                            Limpeza();
                            False();
                        }
                        else
                        {
                            MessageBox.Show("O Campo já está reservado ou a ser usado nesse intervalo de tempo");
                            Limpeza();
                            False();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erro, o Utente não está registado, por favor registe o utente antes de alugar o campo");
                        Limpeza();
                        False();
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                    Limpeza();
                    False();
                }
            }
            else
            {
                MessageBox.Show("Horário inserido inválido");
                False();
                Limpeza();
            }
        }
        private void False()
        {
            btnAnterior.Enabled = false;
            btnSeguinte.Enabled = false;
            txtNome.Enabled = false;
        }
        private void Limpeza()
        {
            txtNome.Text = "";
            cbbcampo.SelectedItem = null;
            nupHinicial.Value = 9;
            nupHFinal.Value = 9;
            nupMinicial.Value = 0;
            nupMFinal.Value = 0;
            cbbProfessor.SelectedItem= null;
        }

        private void frmMarcação_Aula_Squash_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connect1 = new SqlConnection(Properties.Resources.Connect);
                // SqlConnection connect1 = new SqlConnection(Properties.Resources.Connect1);
                connect1.Open();
                SqlCommand cmd = connect1.CreateCommand();
                cmd.CommandText = "Select Nome from Professor where Desporto='Squash'";
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbbProfessor.Items.Add(reader.GetString(0));
                }
                connect1.Close();
                reader.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private int check11()
        {
            int qtd;
            SqlConnection connect1 = new SqlConnection(Properties.Resources.Connect);
            //SqlConnection connect1 = new SqlConnection(Properties.Resources.Connect1);
            connect1.Open();
            SqlCommand cmd = connect1.CreateCommand();
            cmd.CommandText = "SELECT COUNT(id_Consumo)FROM Consumo";
            qtd = (int)cmd.ExecuteScalar();
            connect1.Close();
            return qtd;
        }
        private void Preço()
        {
            SqlConnection connect = new SqlConnection(Properties.Resources.Connect);
            //SqlConnection connect = new SqlConnection(Properties.Resources.Connect1);
            connect.Open();
            SqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "Select preço from Preço where id_desporto='Squash' and tipo_consumo='Aula'";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                preço = Convert.ToInt32(reader.GetInt32(0));
                return;
            }
        }
        private bool Socio(string teste)
        {
            SqlConnection connect = new SqlConnection(Properties.Resources.Connect);
            //SqlConnection connect = new SqlConnection(Properties.Resources.Connect1);
            connect.Open();
            SqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "Select Socio from Utente where Nome ='" + teste + "'";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetString(0) == "Sim")
                    return true;
                else
                    return false;
            }
            return true;
        }
        private void Consumo()
        {
            try
            {
                if (Socio(txtNome.Text) == true)
                {
                    qtd2 = check11();
                    Preço();
                    SqlConnection connect = new SqlConnection(Properties.Resources.Connect);
                    //SqlConnection connect = new SqlConnection(Properties.Resources.Connect1);
                    connect.Open();
                    SqlCommand cmd = connect.CreateCommand();
                    qtd2 = qtd2 + 1;
                    cmd.CommandText = "dbo.Regist_Consumo";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_Consumo", qtd2);
                    cmd.Parameters.AddWithValue("@id_prof", result10);
                    cmd.Parameters.AddWithValue("@id_func", Program.user);
                    cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@Tipo_Consumo", "Aula");
                    cmd.Parameters.AddWithValue("@Desporto", "Squash");
                    cmd.Parameters.AddWithValue("@id_campo", result);
                    cmd.Parameters.AddWithValue("@Preço", preço - (preço * 10));
                    cmd.Parameters.AddWithValue("@Dia", Convert.ToDateTime(dtpData.Value));
                    cmd.Parameters.AddWithValue("@Hora_Inic", (nupHinicial.Value.ToString() + ":" + nupMinicial.Value.ToString()));
                    cmd.Parameters.AddWithValue("@Hora_Fim", (nupHFinal.Value.ToString() + ":" + nupMFinal.Value.ToString()));
                    cmd.Parameters.AddWithValue("@Estado", "Por Pagar");
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registo adicionado à BD");
                    connect.Close();
                    Limpeza();
                }
                else
                {
                    qtd2 = check11();
                    Preço();
                    SqlConnection connect = new SqlConnection(Properties.Resources.Connect);
                    //SqlConnection connect = new SqlConnection(Properties.Resources.Connect1);
                    connect.Open();
                    SqlCommand cmd = connect.CreateCommand();
                    qtd2 = qtd2 + 1;
                    cmd.CommandText = "dbo.Regist_Consumo";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_Consumo", qtd2);
                    cmd.Parameters.AddWithValue("@id_prof", result10);
                    cmd.Parameters.AddWithValue("@id_func", Program.user);
                    cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@Tipo_Consumo", "Aula");
                    cmd.Parameters.AddWithValue("@id_campo", result);
                    cmd.Parameters.AddWithValue("@Desporto", "Squash");
                    cmd.Parameters.AddWithValue("@Preço", preço);
                    cmd.Parameters.AddWithValue("@Dia", Convert.ToDateTime(dtpData.Value));
                    cmd.Parameters.AddWithValue("@Hora_Inic", (nupHinicial.Value.ToString() + ":" + nupMinicial.Value.ToString()));
                    cmd.Parameters.AddWithValue("@Hora_Fim", (nupHFinal.Value.ToString() + ":" + nupMFinal.Value.ToString()));
                    cmd.Parameters.AddWithValue("@Estado", "Por Pagar");
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registo adicionado à BD");
                    connect.Close();
                    Limpeza();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                Limpeza();
            }
        }

        private void frmMarcação_Aula_Squash_FormClosing(object sender, FormClosingEventArgs e)
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
