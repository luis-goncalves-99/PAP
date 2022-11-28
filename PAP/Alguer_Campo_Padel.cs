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
    public partial class frmAlguer_Padel : Form
    {
        string[] strArray;
        string[] strArray1;
        int qtd1;
        int qtd2;
        int result;
        int pos;
        string textbox;
        int preço;
        string nome;
        public frmAlguer_Padel()
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
                cmd.CommandText = "Select id_Campo from Campo where Nome='" + cbbcampo.SelectedItem.ToString() + "'and Nome_Desporto='Padel'";
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

        private void cbbqtdpessoas_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            txtNome1.Enabled = true;
            txtNome2.Enabled = true;
            txtNome3.Enabled = true;
            if (cbbqtdpessoas.SelectedItem == "1")
            {
                txtNome1.Enabled = false;
                txtNome2.Enabled = false;
                txtNome3.Enabled = false;
            }
            if (cbbqtdpessoas.SelectedItem == "2")
            {
                txtNome2.Enabled = false;
                txtNome3.Enabled = false;
            }
            if (cbbqtdpessoas.SelectedItem == "3")
            {
                txtNome3.Enabled = false;
            }

        }
        private bool check2()
        {
            if (qtd1 == 0)
                return true;
            if (cbbqtdpessoas.SelectedItem == "1")
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
            if (cbbqtdpessoas.SelectedItem == "2")
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
                    if (reader.GetString(0) != txtNome.Text && reader.GetString(0) != txtNome1.Text)
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
            if (cbbqtdpessoas.SelectedItem == "3")
            {
                bool val = true;
                SqlConnection connect1 = new SqlConnection(Properties.Resources.Connect);
                //SqlConnection connect1 = new SqlConnection(Properties.Resources.Connect1);
                connect1.Open();
                SqlCommand cmd = connect1.CreateCommand();
                cmd.CommandText = "SELECT Nome from Utente";
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetString(0) != txtNome.Text && reader.GetString(0) != txtNome1.Text && reader.GetString(0) != txtNome2.Text)
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
            else
            {
                bool val = true;
                SqlConnection connect1 = new SqlConnection(Properties.Resources.Connect);
                //SqlConnection connect1 = new SqlConnection(Properties.Resources.Connect1);
                connect1.Open();
                SqlCommand cmd = connect1.CreateCommand();
                cmd.CommandText = "SELECT Nome from Utente";
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetString(0) != txtNome.Text && reader.GetString(0) != txtNome1.Text && reader.GetString(0) != txtNome2.Text && reader.GetString(0) != txtNome3.Text)
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
            cmd.CommandText = "SELECT Dia,id_campo,Nome_desporto,Hora_Fim,Hora_Inic,Utente_1,Utente_2,Utente_3,Utente_4 from Ocupação_Campos";
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
            cmd.CommandText = "SELECT Dia,id_campo,Nome_desporto,Hora_Fim,Hora_Inic,Utente_1,Utente_2,Utente_3,Utente_4 from Ocupação_Campos";
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
                if (cbbqtdpessoas.SelectedItem == "1")
                {
                    if ((reader.GetDateTime(0) == Convert.ToDateTime(dtpData.Value) && reader.GetString(5) == txtNome.Text && // nao pode tar em ccampos diferentes a mesma hora o mesmo utente
                        (((HFim * 60) + (MFim)) == ((nupHFinal.Value * 60) + (nupMFinal.Value)) && ((Hinic * 60) + (Minic)) == ((nupHinicial.Value * 60) + (nupMinicial.Value))) && reader.GetInt32(1) != result)

                        || (reader.GetDateTime(0) == Convert.ToDateTime(dtpData.Value) && reader.GetString(5) != txtNome.Text && (((HFim * 60) + (MFim)) == ((nupHFinal.Value * 60) + (nupMFinal.Value)) &&
                        ((Hinic * 60) + (Minic)) == ((nupHinicial.Value * 60) + (nupMinicial.Value))) && reader.GetInt32(1) == result)// utentes diferentes no mesmo horario nao podem estar no mesmo campo

                        || /*(((Hinic * 60) + (Minic)) > ((HFim * 60) + (MFim)) && */((reader.GetDateTime(0) == Convert.ToDateTime(dtpData.Value) //
                        && ((((nupHinicial.Value * 60) + (nupMinicial.Value)) < ((HFim * 60) + (MFim)))
                        && (((nupHinicial.Value * 60) + (nupMinicial.Value)) >= ((Hinic * 60) + (Minic)))) || ((((nupHFinal.Value * 60) + nupMFinal.Value) <= ((HFim * 60) + MFim)) &&
                        (((nupHFinal.Value * 60) + nupMFinal.Value) > ((Hinic * 60) + Minic)))) && reader.GetInt32(1) == result))

                        val = false;
                }
                if (cbbqtdpessoas.SelectedItem == "2")
                {
                    if (txtNome.Text == txtNome1.Text)
                        return false;
                    if ( reader.GetString(2) == "Padel" &&(reader.GetDateTime(0) == Convert.ToDateTime(dtpData.Value) && reader.GetString(5) == txtNome.Text && reader.GetString(6) == txtNome1.Text &&// nao pode tar em ccampos diferentes a mesma hora o mesmo utente
                        (((HFim * 60) + (MFim)) == ((nupHFinal.Value * 60) + (nupMFinal.Value)) && ((Hinic * 60) + (Minic)) == ((nupHinicial.Value * 60) + (nupMinicial.Value))) && reader.GetInt32(1) != result)

                        || (reader.GetDateTime(0) == Convert.ToDateTime(dtpData.Value) && reader.GetString(5) != txtNome.Text && reader.GetString(6) != txtNome1.Text && (((HFim * 60) + (MFim)) == ((nupHFinal.Value * 60) + (nupMFinal.Value)) &&
                        ((Hinic * 60) + (Minic)) == ((nupHinicial.Value * 60) + (nupMinicial.Value))) && reader.GetInt32(1) == result)// utentes diferentes no mesmo horario nao podem estar no mesmo campo

                        || ((reader.GetDateTime(0) == Convert.ToDateTime(dtpData.Value) //
                        && ((((nupHinicial.Value * 60) + (nupMinicial.Value)) < ((HFim * 60) + (MFim)))
                        && (((nupHinicial.Value * 60) + (nupMinicial.Value)) >= ((Hinic * 60) + (Minic)))) || ((((nupHFinal.Value * 60) + nupMFinal.Value) <= ((HFim * 60) + MFim)) &&
                        (((nupHFinal.Value * 60) + nupMFinal.Value) > ((Hinic * 60) + Minic)))) && reader.GetInt32(1) == result))

                        val = false;
                }
                if (cbbqtdpessoas.SelectedItem == "3")
                {
                    if (txtNome.Text == txtNome1.Text || txtNome.Text == txtNome2.Text || txtNome1.Text == txtNome2.Text)
                        return false;
                    if (reader.GetString(2) == "Padel" && (reader.GetDateTime(0) == Convert.ToDateTime(dtpData.Value) && reader.GetString(5) == txtNome.Text && reader.GetString(6) == txtNome1.Text && reader.GetString(7) == txtNome2.Text &&// nao pode tar em ccampos diferentes a mesma hora o mesmo utente
                    (((HFim * 60) + (MFim)) == ((nupHFinal.Value * 60) + (nupMFinal.Value)) && ((Hinic * 60) + (Minic)) == ((nupHinicial.Value * 60) + (nupMinicial.Value))) && reader.GetInt32(1) != result)

                    || (reader.GetDateTime(0) == Convert.ToDateTime(dtpData.Value) && reader.GetString(5) != txtNome.Text && reader.GetString(6) != txtNome1.Text && reader.GetString(7) == txtNome2.Text || reader.GetString(6) != txtNome3.Text && (((HFim * 60) + (MFim)) == ((nupHFinal.Value * 60) + (nupMFinal.Value)) &&
                    ((Hinic * 60) + (Minic)) == ((nupHinicial.Value * 60) + (nupMinicial.Value))) && reader.GetInt32(1) == result)// utentes diferentes no mesmo horario nao podem estar no mesmo campo

                    || ((reader.GetDateTime(0) == Convert.ToDateTime(dtpData.Value) //
                    && ((((nupHinicial.Value * 60) + (nupMinicial.Value)) < ((HFim * 60) + (MFim)))
                    && (((nupHinicial.Value * 60) + (nupMinicial.Value)) >= ((Hinic * 60) + (Minic)))) || ((((nupHFinal.Value * 60) + nupMFinal.Value) <= ((HFim * 60) + MFim)) &&
                    (((nupHFinal.Value * 60) + nupMFinal.Value) > ((Hinic * 60) + Minic)))) && reader.GetInt32(1) == result))
                        return false;
                }
                if (cbbqtdpessoas.SelectedItem == "4")
                {

                    if (txtNome.Text == txtNome1.Text || txtNome.Text == txtNome2.Text || txtNome.Text == txtNome3.Text || txtNome1.Text == txtNome2.Text || txtNome1.Text == txtNome3.Text || txtNome2.Text == txtNome3.Text)
                        return false;
                    if (txtNome.Text == txtNome1.Text || txtNome.Text == txtNome2.Text || txtNome1.Text == txtNome2.Text)
                        if ((reader.GetDateTime(0) == Convert.ToDateTime(dtpData.Value) && reader.GetString(5) == txtNome.Text && reader.GetString(6) == txtNome1.Text && reader.GetString(7) == txtNome2.Text && reader.GetString(8) == txtNome3.Text && // nao pode tar em ccampos diferentes a mesma hora o mesmo utente
                        (((HFim * 60) + (MFim)) == ((nupHFinal.Value * 60) + (nupMFinal.Value)) && ((Hinic * 60) + (Minic)) == ((nupHinicial.Value * 60) + (nupMinicial.Value))) && reader.GetInt32(1) != result)

                        || (reader.GetDateTime(0) == Convert.ToDateTime(dtpData.Value) && reader.GetString(5) != txtNome.Text && reader.GetString(6) != txtNome1.Text && reader.GetString(7) == txtNome2.Text || reader.GetString(7) != txtNome3.Text && reader.GetString(8) != txtNome3.Text && (((HFim * 60) + (MFim)) == ((nupHFinal.Value * 60) + (nupMFinal.Value)) &&
                        ((Hinic * 60) + (Minic)) == ((nupHinicial.Value * 60) + (nupMinicial.Value))) && reader.GetInt32(1) == result)// utentes diferentes no mesmo horario nao podem estar no mesmo campo

                        || ((reader.GetDateTime(0) == Convert.ToDateTime(dtpData.Value) //
                        && ((((nupHinicial.Value * 60) + (nupMinicial.Value)) < ((HFim * 60) + (MFim)))
                        && (((nupHinicial.Value * 60) + (nupMinicial.Value)) >= ((Hinic * 60) + (Minic)))) || ((((nupHFinal.Value * 60) + nupMFinal.Value) <= ((HFim * 60) + MFim)) &&
                        (((nupHFinal.Value * 60) + nupMFinal.Value) > ((Hinic * 60) + Minic)))) && reader.GetInt32(1) == result))
                            return false;
                }
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
                    if (check2() == true)
                    {
                        if (check() == true)
                        {
                            Program.user = "luis";
                            qtd1 = qtd1 + 1;
                            cmd.CommandText = "dbo.Regist_Aluguer";
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_aula", qtd1);
                            cmd.Parameters.AddWithValue("@Nome_desporto", "Padel");
                            cmd.Parameters.AddWithValue("@id_campo", result);
                            cmd.Parameters.AddWithValue("@id_func", Program.user);
                            cmd.Parameters.AddWithValue("@Utente_1", txtNome.Text);
                            cmd.Parameters.AddWithValue("@Utente_2", txtNome1.Text);
                            cmd.Parameters.AddWithValue("@Utente_3", txtNome2.Text);
                            cmd.Parameters.AddWithValue("@Utente_4", txtNome3.Text);
                            cmd.Parameters.AddWithValue("@Dia", Convert.ToDateTime(dtpData.Value));
                            cmd.Parameters.AddWithValue("@Hora_Inic", (nupHinicial.Value.ToString() + ":" + nupMinicial.Value.ToString()));
                            cmd.Parameters.AddWithValue("@Hora_Fim", (nupHFinal.Value.ToString() + ":" + nupMFinal.Value.ToString()));
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Aluguer de Padel adicionado à BD");
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
                //Limpeza();
            }
        }
        private void Limpeza()
        {
            txtNome.Text = "";
            txtNome1.Text = "";
            txtNome2.Text = "";
            txtNome3.Text = "";
            cbbcampo.SelectedItem = null;
            cbbqtdpessoas.SelectedItem = null;
            nupHinicial.Value = 9;
            nupHFinal.Value = 9;
            nupMinicial.Value = 0;
            nupMFinal.Value = 0;
        }
        private void False()
        {
            txtNome.Enabled = false;
            txtNome1.Enabled = false;
            txtNome2.Enabled = false;
            txtNome3.Enabled = false;
        }

        private void btnRegistar_Utente_Click(object sender, EventArgs e)
        {
            frmNovoUtente Form = new frmNovoUtente();
            Form.ShowDialog();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            g(textbox);
        }
        private void btnSeguinte_Click(object sender, EventArgs e)
        {
            g1(textbox);
        }
        private void txtNome_MouseClick(object sender, MouseEventArgs e)
        {
            textbox = "1";
        }
        private void txtNome1_MouseClick(object sender, MouseEventArgs e)
        {
            textbox = "2";
        }
        private void txtNome2_MouseClick(object sender, MouseEventArgs e)
        {
            textbox = "3";

        }
        private void txtNome3_MouseClick(object sender, MouseEventArgs e)
        {
            textbox = "4";
        }
        private void g(string teste)
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
                if (teste == "1")
                {
                    txtNome.Text = reader.GetString(0);
                    return;
                }
                if (teste == "2")
                {
                    txtNome1.Text = reader.GetString(0);
                    return;
                }
                if (teste == "3")
                {
                    txtNome2.Text = reader.GetString(0);
                    return;
                }
                if (teste == "4")
                {
                    txtNome3.Text = reader.GetString(0);
                    return;
                }
            }
            Limpeza();
            Hide();
        }
        private void g1(string teste)
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
                if (teste == "1")
                {
                    txtNome.Text = reader.GetString(0);
                    return;
                }
                if (teste == "2")
                {
                    txtNome1.Text = reader.GetString(0);
                    return;
                }
                if (teste == "3")
                {
                    txtNome2.Text = reader.GetString(0);
                    return;
                }
                if (teste == "4")
                {
                    txtNome3.Text = reader.GetString(0);
                    return;
                }
            }
            Limpeza();
            Hide();
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
            cmd.CommandText = "Select preço from Preço where id_desporto='Padel' and tipo_consumo='Aluguer'";
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
        private void qtd()
        {
            for(int idx = 0; idx < Convert.ToInt32(cbbqtdpessoas.SelectedItem);idx++)
            {
                
            }
        }        
        private void Consumo()
        {
            if (cbbqtdpessoas.SelectedItem == "1")
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
                        cmd.Parameters.AddWithValue("@id_prof", "");
                        cmd.Parameters.AddWithValue("@id_func", Program.user);
                        cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                        cmd.Parameters.AddWithValue("@Tipo_Consumo", "Aluguer");
                        cmd.Parameters.AddWithValue("@Desporto", "Padel");
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
                        cmd.Parameters.AddWithValue("@id_prof", "");
                        cmd.Parameters.AddWithValue("@id_func", Program.user);
                        cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                        cmd.Parameters.AddWithValue("@Tipo_Consumo", "Aluguer");
                        cmd.Parameters.AddWithValue("@id_campo", result);
                        cmd.Parameters.AddWithValue("@Desporto", "Padel");
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
            if(cbbqtdpessoas.SelectedItem=="2")
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
                        cmd.Parameters.AddWithValue("@id_prof", "");
                        cmd.Parameters.AddWithValue("@id_func", Program.user);
                        cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                        cmd.Parameters.AddWithValue("@Tipo_Consumo", "Aluguer");
                        cmd.Parameters.AddWithValue("@Desporto", "Padel");
                        cmd.Parameters.AddWithValue("@id_campo", result);
                        cmd.Parameters.AddWithValue("@Preço", preço - (preço * 10));
                        cmd.Parameters.AddWithValue("@Dia", Convert.ToDateTime(dtpData.Value));
                        cmd.Parameters.AddWithValue("@Hora_Inic", (nupHinicial.Value.ToString() + ":" + nupMinicial.Value.ToString()));
                        cmd.Parameters.AddWithValue("@Hora_Fim", (nupHFinal.Value.ToString() + ":" + nupMFinal.Value.ToString()));
                        cmd.Parameters.AddWithValue("@Estado", "Por Pagar");
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registo adicionado à BD");
                        connect.Close();                        
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
                        cmd.Parameters.AddWithValue("@id_prof", "");
                        cmd.Parameters.AddWithValue("@id_func", Program.user);
                        cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                        cmd.Parameters.AddWithValue("@Tipo_Consumo", "Aluguer");
                        cmd.Parameters.AddWithValue("@id_campo", result);
                        cmd.Parameters.AddWithValue("@Desporto", "Padel");
                        cmd.Parameters.AddWithValue("@Preço", preço);
                        cmd.Parameters.AddWithValue("@Dia", Convert.ToDateTime(dtpData.Value));
                        cmd.Parameters.AddWithValue("@Hora_Inic", (nupHinicial.Value.ToString() + ":" + nupMinicial.Value.ToString()));
                        cmd.Parameters.AddWithValue("@Hora_Fim", (nupHFinal.Value.ToString() + ":" + nupMFinal.Value.ToString()));
                        cmd.Parameters.AddWithValue("@Estado", "Por Pagar");
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registo adicionado à BD");
                        connect.Close();                        
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                    Limpeza();
                }
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
                        cmd.Parameters.AddWithValue("@id_prof", "");
                        cmd.Parameters.AddWithValue("@id_func", Program.user);
                        cmd.Parameters.AddWithValue("@Nome", txtNome1.Text);
                        cmd.Parameters.AddWithValue("@Tipo_Consumo", "Aluguer");
                        cmd.Parameters.AddWithValue("@Desporto", "Padel");
                        cmd.Parameters.AddWithValue("@id_campo", result);
                        cmd.Parameters.AddWithValue("@Preço", preço - (preço * 10));
                        cmd.Parameters.AddWithValue("@Dia", Convert.ToDateTime(dtpData.Value));
                        cmd.Parameters.AddWithValue("@Hora_Inic", (nupHinicial.Value.ToString() + ":" + nupMinicial.Value.ToString()));
                        cmd.Parameters.AddWithValue("@Hora_Fim", (nupHFinal.Value.ToString() + ":" + nupMFinal.Value.ToString()));
                        cmd.Parameters.AddWithValue("@Estado", "Por Pagar");
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registo adicionado à BD");
                        connect.Close();                        
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
                        cmd.Parameters.AddWithValue("@id_prof", "");
                        cmd.Parameters.AddWithValue("@id_func", Program.user);
                        cmd.Parameters.AddWithValue("@Nome", txtNome1.Text);
                        cmd.Parameters.AddWithValue("@Tipo_Consumo", "Aluguer");
                        cmd.Parameters.AddWithValue("@id_campo", result);
                        cmd.Parameters.AddWithValue("@Desporto", "Padel");
                        cmd.Parameters.AddWithValue("@Preço", preço);
                        cmd.Parameters.AddWithValue("@Dia", Convert.ToDateTime(dtpData.Value));
                        cmd.Parameters.AddWithValue("@Hora_Inic", (nupHinicial.Value.ToString() + ":" + nupMinicial.Value.ToString()));
                        cmd.Parameters.AddWithValue("@Hora_Fim", (nupHFinal.Value.ToString() + ":" + nupMFinal.Value.ToString()));
                        cmd.Parameters.AddWithValue("@Estado", "Por Pagar");
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registo adicionado à BD");
                        connect.Close();                        
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                    Limpeza();
                }

            }
            if (cbbqtdpessoas.SelectedItem == "3")
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
                        cmd.Parameters.AddWithValue("@id_prof", "");
                        cmd.Parameters.AddWithValue("@id_func", Program.user);
                        cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                        cmd.Parameters.AddWithValue("@Tipo_Consumo", "Aluguer");
                        cmd.Parameters.AddWithValue("@Desporto", "Padel");
                        cmd.Parameters.AddWithValue("@id_campo", result);
                        cmd.Parameters.AddWithValue("@Preço", preço - (preço * 10));
                        cmd.Parameters.AddWithValue("@Dia", Convert.ToDateTime(dtpData.Value));
                        cmd.Parameters.AddWithValue("@Hora_Inic", (nupHinicial.Value.ToString() + ":" + nupMinicial.Value.ToString()));
                        cmd.Parameters.AddWithValue("@Hora_Fim", (nupHFinal.Value.ToString() + ":" + nupMFinal.Value.ToString()));
                        cmd.Parameters.AddWithValue("@Estado", "Por Pagar");
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registo adicionado à BD");
                        connect.Close();                        
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
                        cmd.Parameters.AddWithValue("@id_prof", "");
                        cmd.Parameters.AddWithValue("@id_func", Program.user);
                        cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                        cmd.Parameters.AddWithValue("@Tipo_Consumo", "Aluguer");
                        cmd.Parameters.AddWithValue("@id_campo", result);
                        cmd.Parameters.AddWithValue("@Desporto", "Padel");
                        cmd.Parameters.AddWithValue("@Preço", preço);
                        cmd.Parameters.AddWithValue("@Dia", Convert.ToDateTime(dtpData.Value));
                        cmd.Parameters.AddWithValue("@Hora_Inic", (nupHinicial.Value.ToString() + ":" + nupMinicial.Value.ToString()));
                        cmd.Parameters.AddWithValue("@Hora_Fim", (nupHFinal.Value.ToString() + ":" + nupMFinal.Value.ToString()));
                        cmd.Parameters.AddWithValue("@Estado", "Por Pagar");
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registo adicionado à BD");
                        connect.Close();                        
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                    Limpeza();
                }
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
                        cmd.Parameters.AddWithValue("@id_prof", "");
                        cmd.Parameters.AddWithValue("@id_func", Program.user);
                        cmd.Parameters.AddWithValue("@Nome", txtNome1.Text);
                        cmd.Parameters.AddWithValue("@Tipo_Consumo", "Aluguer");
                        cmd.Parameters.AddWithValue("@Desporto", "Padel");
                        cmd.Parameters.AddWithValue("@id_campo", result);
                        cmd.Parameters.AddWithValue("@Preço", preço - (preço * 10));
                        cmd.Parameters.AddWithValue("@Dia", Convert.ToDateTime(dtpData.Value));
                        cmd.Parameters.AddWithValue("@Hora_Inic", (nupHinicial.Value.ToString() + ":" + nupMinicial.Value.ToString()));
                        cmd.Parameters.AddWithValue("@Hora_Fim", (nupHFinal.Value.ToString() + ":" + nupMFinal.Value.ToString()));
                        cmd.Parameters.AddWithValue("@Estado", "Por Pagar");
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registo adicionado à BD");
                        connect.Close();                        
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
                        cmd.Parameters.AddWithValue("@id_prof", "");
                        cmd.Parameters.AddWithValue("@id_func", Program.user);
                        cmd.Parameters.AddWithValue("@Nome", txtNome1.Text);
                        cmd.Parameters.AddWithValue("@Tipo_Consumo", "Aluguer");
                        cmd.Parameters.AddWithValue("@id_campo", result);
                        cmd.Parameters.AddWithValue("@Desporto", "Padel");
                        cmd.Parameters.AddWithValue("@Preço", preço);
                        cmd.Parameters.AddWithValue("@Dia", Convert.ToDateTime(dtpData.Value));
                        cmd.Parameters.AddWithValue("@Hora_Inic", (nupHinicial.Value.ToString() + ":" + nupMinicial.Value.ToString()));
                        cmd.Parameters.AddWithValue("@Hora_Fim", (nupHFinal.Value.ToString() + ":" + nupMFinal.Value.ToString()));
                        cmd.Parameters.AddWithValue("@Estado", "Por Pagar");
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registo adicionado à BD");
                        connect.Close();                        
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                    Limpeza();
                }
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
                        cmd.Parameters.AddWithValue("@id_prof", "");
                        cmd.Parameters.AddWithValue("@id_func", Program.user);
                        cmd.Parameters.AddWithValue("@Nome", txtNome2.Text);
                        cmd.Parameters.AddWithValue("@Tipo_Consumo", "Aluguer");
                        cmd.Parameters.AddWithValue("@Desporto", "Padel");
                        cmd.Parameters.AddWithValue("@id_campo", result);
                        cmd.Parameters.AddWithValue("@Preço", preço - (preço * 10));
                        cmd.Parameters.AddWithValue("@Dia", Convert.ToDateTime(dtpData.Value));
                        cmd.Parameters.AddWithValue("@Hora_Inic", (nupHinicial.Value.ToString() + ":" + nupMinicial.Value.ToString()));
                        cmd.Parameters.AddWithValue("@Hora_Fim", (nupHFinal.Value.ToString() + ":" + nupMFinal.Value.ToString()));
                        cmd.Parameters.AddWithValue("@Estado", "Por Pagar");
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registo adicionado à BD");
                        connect.Close();                        
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
                        cmd.Parameters.AddWithValue("@id_prof", "");
                        cmd.Parameters.AddWithValue("@id_func", Program.user);
                        cmd.Parameters.AddWithValue("@Nome", txtNome2.Text);
                        cmd.Parameters.AddWithValue("@Tipo_Consumo", "Aluguer");
                        cmd.Parameters.AddWithValue("@id_campo", result);
                        cmd.Parameters.AddWithValue("@Desporto", "Padel");
                        cmd.Parameters.AddWithValue("@Preço", preço);
                        cmd.Parameters.AddWithValue("@Dia", Convert.ToDateTime(dtpData.Value));
                        cmd.Parameters.AddWithValue("@Hora_Inic", (nupHinicial.Value.ToString() + ":" + nupMinicial.Value.ToString()));
                        cmd.Parameters.AddWithValue("@Hora_Fim", (nupHFinal.Value.ToString() + ":" + nupMFinal.Value.ToString()));
                        cmd.Parameters.AddWithValue("@Estado", "Por Pagar");
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registo adicionado à BD");
                        connect.Close();                        
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                    Limpeza();
                }

            }
            if (cbbqtdpessoas.SelectedItem == "4")
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
                        cmd.Parameters.AddWithValue("@id_prof", "");
                        cmd.Parameters.AddWithValue("@id_func", Program.user);
                        cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                        cmd.Parameters.AddWithValue("@Tipo_Consumo", "Aluguer");
                        cmd.Parameters.AddWithValue("@Desporto", "Padel");
                        cmd.Parameters.AddWithValue("@id_campo", result);
                        cmd.Parameters.AddWithValue("@Preço", preço - (preço * 10));
                        cmd.Parameters.AddWithValue("@Dia", Convert.ToDateTime(dtpData.Value));
                        cmd.Parameters.AddWithValue("@Hora_Inic", (nupHinicial.Value.ToString() + ":" + nupMinicial.Value.ToString()));
                        cmd.Parameters.AddWithValue("@Hora_Fim", (nupHFinal.Value.ToString() + ":" + nupMFinal.Value.ToString()));
                        cmd.Parameters.AddWithValue("@Estado", "Por Pagar");
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registo adicionado à BD");
                        connect.Close();                        
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
                        cmd.Parameters.AddWithValue("@id_prof", "");
                        cmd.Parameters.AddWithValue("@id_func", Program.user);
                        cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                        cmd.Parameters.AddWithValue("@Tipo_Consumo", "Aluguer");
                        cmd.Parameters.AddWithValue("@id_campo", result);
                        cmd.Parameters.AddWithValue("@Desporto", "Padel");
                        cmd.Parameters.AddWithValue("@Preço", preço);
                        cmd.Parameters.AddWithValue("@Dia", Convert.ToDateTime(dtpData.Value));
                        cmd.Parameters.AddWithValue("@Hora_Inic", (nupHinicial.Value.ToString() + ":" + nupMinicial.Value.ToString()));
                        cmd.Parameters.AddWithValue("@Hora_Fim", (nupHFinal.Value.ToString() + ":" + nupMFinal.Value.ToString()));
                        cmd.Parameters.AddWithValue("@Estado", "Por Pagar");
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registo adicionado à BD");
                        connect.Close();                        
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                    Limpeza();
                }
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
                        cmd.Parameters.AddWithValue("@id_prof", "");
                        cmd.Parameters.AddWithValue("@id_func", Program.user);
                        cmd.Parameters.AddWithValue("@Nome", txtNome1.Text);
                        cmd.Parameters.AddWithValue("@Tipo_Consumo", "Aluguer");
                        cmd.Parameters.AddWithValue("@Desporto", "Padel");
                        cmd.Parameters.AddWithValue("@id_campo", result);
                        cmd.Parameters.AddWithValue("@Preço", preço - (preço * 10));
                        cmd.Parameters.AddWithValue("@Dia", Convert.ToDateTime(dtpData.Value));
                        cmd.Parameters.AddWithValue("@Hora_Inic", (nupHinicial.Value.ToString() + ":" + nupMinicial.Value.ToString()));
                        cmd.Parameters.AddWithValue("@Hora_Fim", (nupHFinal.Value.ToString() + ":" + nupMFinal.Value.ToString()));
                        cmd.Parameters.AddWithValue("@Estado", "Por Pagar");
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registo adicionado à BD");
                        connect.Close();                        
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
                        cmd.Parameters.AddWithValue("@id_prof", "");
                        cmd.Parameters.AddWithValue("@id_func", Program.user);
                        cmd.Parameters.AddWithValue("@Nome", txtNome1.Text);
                        cmd.Parameters.AddWithValue("@Tipo_Consumo", "Aluguer");
                        cmd.Parameters.AddWithValue("@id_campo", result);
                        cmd.Parameters.AddWithValue("@Desporto", "Padel");
                        cmd.Parameters.AddWithValue("@Preço", preço);
                        cmd.Parameters.AddWithValue("@Dia", Convert.ToDateTime(dtpData.Value));
                        cmd.Parameters.AddWithValue("@Hora_Inic", (nupHinicial.Value.ToString() + ":" + nupMinicial.Value.ToString()));
                        cmd.Parameters.AddWithValue("@Hora_Fim", (nupHFinal.Value.ToString() + ":" + nupMFinal.Value.ToString()));
                        cmd.Parameters.AddWithValue("@Estado", "Por Pagar");
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registo adicionado à BD");
                        connect.Close();                        
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                    Limpeza();
                }
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
                        cmd.Parameters.AddWithValue("@id_prof", "");
                        cmd.Parameters.AddWithValue("@id_func", Program.user);
                        cmd.Parameters.AddWithValue("@Nome", txtNome2.Text);
                        cmd.Parameters.AddWithValue("@Tipo_Consumo", "Aluguer");
                        cmd.Parameters.AddWithValue("@Desporto", "Padel");
                        cmd.Parameters.AddWithValue("@id_campo", result);
                        cmd.Parameters.AddWithValue("@Preço", preço - (preço * 10));
                        cmd.Parameters.AddWithValue("@Dia", Convert.ToDateTime(dtpData.Value));
                        cmd.Parameters.AddWithValue("@Hora_Inic", (nupHinicial.Value.ToString() + ":" + nupMinicial.Value.ToString()));
                        cmd.Parameters.AddWithValue("@Hora_Fim", (nupHFinal.Value.ToString() + ":" + nupMFinal.Value.ToString()));
                        cmd.Parameters.AddWithValue("@Estado", "Por Pagar");
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registo adicionado à BD");
                        connect.Close();                        
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
                        cmd.Parameters.AddWithValue("@id_prof", "");
                        cmd.Parameters.AddWithValue("@id_func", Program.user);
                        cmd.Parameters.AddWithValue("@Nome", txtNome2.Text);
                        cmd.Parameters.AddWithValue("@Tipo_Consumo", "Aluguer");
                        cmd.Parameters.AddWithValue("@id_campo", result);
                        cmd.Parameters.AddWithValue("@Desporto", "Padel");
                        cmd.Parameters.AddWithValue("@Preço", preço);
                        cmd.Parameters.AddWithValue("@Dia", Convert.ToDateTime(dtpData.Value));
                        cmd.Parameters.AddWithValue("@Hora_Inic", (nupHinicial.Value.ToString() + ":" + nupMinicial.Value.ToString()));
                        cmd.Parameters.AddWithValue("@Hora_Fim", (nupHFinal.Value.ToString() + ":" + nupMFinal.Value.ToString()));
                        cmd.Parameters.AddWithValue("@Estado", "Por Pagar");
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registo adicionado à BD");
                        connect.Close();                        
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                    Limpeza();
                }
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
                        cmd.Parameters.AddWithValue("@id_prof", "");
                        cmd.Parameters.AddWithValue("@id_func", Program.user);
                        cmd.Parameters.AddWithValue("@Nome", txtNome3.Text);
                        cmd.Parameters.AddWithValue("@Tipo_Consumo", "Aluguer");
                        cmd.Parameters.AddWithValue("@Desporto", "Padel");
                        cmd.Parameters.AddWithValue("@id_campo", result);
                        cmd.Parameters.AddWithValue("@Preço", preço - (preço * 10));
                        cmd.Parameters.AddWithValue("@Dia", Convert.ToDateTime(dtpData.Value));
                        cmd.Parameters.AddWithValue("@Hora_Inic", (nupHinicial.Value.ToString() + ":" + nupMinicial.Value.ToString()));
                        cmd.Parameters.AddWithValue("@Hora_Fim", (nupHFinal.Value.ToString() + ":" + nupMFinal.Value.ToString()));
                        cmd.Parameters.AddWithValue("@Estado", "Por Pagar");
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registo adicionado à BD");
                        connect.Close();                        
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
                        cmd.Parameters.AddWithValue("@id_prof", "");
                        cmd.Parameters.AddWithValue("@id_func", Program.user);
                        cmd.Parameters.AddWithValue("@Nome", txtNome3.Text);
                        cmd.Parameters.AddWithValue("@Tipo_Consumo", "Aluguer");
                        cmd.Parameters.AddWithValue("@id_campo", result);
                        cmd.Parameters.AddWithValue("@Desporto", "Padel");
                        cmd.Parameters.AddWithValue("@Preço", preço);
                        cmd.Parameters.AddWithValue("@Dia", Convert.ToDateTime(dtpData.Value));
                        cmd.Parameters.AddWithValue("@Hora_Inic", (nupHinicial.Value.ToString() + ":" + nupMinicial.Value.ToString()));
                        cmd.Parameters.AddWithValue("@Hora_Fim", (nupHFinal.Value.ToString() + ":" + nupMFinal.Value.ToString()));
                        cmd.Parameters.AddWithValue("@Estado", "Por Pagar");
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registo adicionado à BD");
                        connect.Close();                        
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                    Limpeza();
                }
            }
        }
        private void frmAlguer_Padel_FormClosing(object sender, FormClosingEventArgs e)
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
