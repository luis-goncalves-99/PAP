using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PAP
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            mnuLogin.Enabled = true;                      
        }
        private void sAirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult test = MessageBox.Show("Tem a certeza que quer sair da aplicação", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (test == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mnuUtentes.Enabled = false;
            mnuProfessores.Enabled = false;
            tsRegister.Enabled = true;
            Program.user = "";
            frmLogin Logout = new frmLogin();            
            Logout.MdiParent = this;
            Logout.Show();      

        }
        private void tsLogin_Click(object sender, EventArgs e)
        {
            mnuLogin.Enabled = false;
            frmLogin login = new frmLogin();
            login.MdiParent = this;
            login.Show();

        }
        private void tsRegister_Click(object sender, EventArgs e)
        {
            mnuUtentes.Enabled = false;
            mnuLogin.Enabled = false;
            mnuProfessores.Enabled = false;
            frmRegistLogin registlogin = new frmRegistLogin();
            registlogin.MdiParent = this;
            registlogin.Show();   
        }
      
        private void criarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mnuLogin.Enabled = false;
            mnuUtentes.Enabled = false;
            mnuProfessores.Enabled = false;
            mnuCampos.Enabled = false;
            mnuAulas.Enabled = false;
            mnuPreços.Enabled = false;
            frmNovoUtente Utente = new frmNovoUtente();
            Utente.MdiParent = this;
            Utente.Show();
        }
        private void listagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mnuLogin.Enabled = false;
            mnuUtentes.Enabled = false;
            mnuProfessores.Enabled = false;
            mnuCampos.Enabled = false;
            mnuAulas.Enabled = false;
            mnuPreços.Enabled = false;
            frmFichaUtente Utentes = new frmFichaUtente();
            Utentes.MdiParent = this;
            Utentes.Show();

        }

        private void novosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mnuLogin.Enabled = false;
            mnuUtentes.Enabled = false;
            mnuProfessores.Enabled = false;
            mnuCampos.Enabled = false;
            mnuAulas.Enabled = false;
            mnuPreços.Enabled = false;
            frmNovoUtente Utente = new frmNovoUtente();
            Utente.MdiParent = this;
            Utente.Show();
        }
        private void tsNovoprof_Click(object sender, EventArgs e)
        {
            mnuLogin.Enabled = false;
            mnuUtentes.Enabled = false;
            mnuProfessores.Enabled = false;
            mnuCampos.Enabled = false;
            mnuAulas.Enabled = false;
            mnuPreços.Enabled = false;
            frmNewProf newprof = new frmNewProf();
            newprof.MdiParent = this;
            newprof.Show();
        }
        private void txListagemProf_Click(object sender, EventArgs e)
        {
            mnuLogin.Enabled = false;
            mnuUtentes.Enabled = false;
            mnuProfessores.Enabled = false;
            mnuCampos.Enabled = false;
            mnuAulas.Enabled = false;
            mnuPreços.Enabled = false;
            frmFichaProf ListProf = new frmFichaProf();
            ListProf.MdiParent = this;
            ListProf.Show();
        }
        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mnuLogin.Enabled = false;
            mnuUtentes.Enabled = false;
            mnuProfessores.Enabled = false;
            mnuCampos.Enabled = false;
            mnuAulas.Enabled = false;
            mnuPreços.Enabled = false;
            frmAdcionar_campo adcampo = new frmAdcionar_campo();
            adcampo.MdiParent = this;
            adcampo.Show();
        }
        private void marcaçãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mnuLogin.Enabled = false;
            mnuUtentes.Enabled = false;
            mnuProfessores.Enabled = false;
            mnuCampos.Enabled = false;
            mnuAulas.Enabled = false;
            mnuPreços.Enabled = false;
            frmMarcação_Aula_Ténis aula_tenis = new frmMarcação_Aula_Ténis();
            aula_tenis.MdiParent = this;
            aula_tenis.Show();
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mnuLogin.Enabled = false;
            mnuUtentes.Enabled = false;
            mnuProfessores.Enabled = false;
            mnuCampos.Enabled = false;
            mnuAulas.Enabled = false;
            mnuPreços.Enabled = false;
            frmPreço preço_aulas = new frmPreço();
            preço_aulas.MdiParent = this;
            preço_aulas.Show();
        }
        private void aluguerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mnuLogin.Enabled = false;
            mnuUtentes.Enabled = false;
            mnuProfessores.Enabled = false;
            mnuCampos.Enabled = false;
            mnuAulas.Enabled = false;
            mnuPreços.Enabled = false;
            frmAluguer_Ténis aluguer_tenis = new frmAluguer_Ténis();
            aluguer_tenis.MdiParent = this;
            aluguer_tenis.Show();
        }
        private void Aluguer_PadelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mnuLogin.Enabled = false;
            mnuUtentes.Enabled = false;
            mnuProfessores.Enabled = false;
            mnuCampos.Enabled = false;
            mnuAulas.Enabled = false;
            mnuPreços.Enabled = false;
            frmAlguer_Padel aluguer_padel = new frmAlguer_Padel();
            aluguer_padel.MdiParent = this;
            aluguer_padel.Show();
        }
        private void Aluguer_SquashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mnuLogin.Enabled = false;
            mnuUtentes.Enabled = false;
            mnuProfessores.Enabled = false;
            mnuCampos.Enabled = false;
            mnuAulas.Enabled = false;
            mnuPreços.Enabled = false;
            frmAlguer_Squash aluguer_squash = new frmAlguer_Squash();
            aluguer_squash.MdiParent = this;
            aluguer_squash.Show();
        }
        private void marcação_SquashToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            mnuLogin.Enabled = false;
            mnuUtentes.Enabled = false;
            mnuProfessores.Enabled = false;
            mnuCampos.Enabled = false;
            mnuAulas.Enabled = false;
            mnuPreços.Enabled = false;
            frmMarcação_Aula_Squash aula_squash = new frmMarcação_Aula_Squash();
            aula_squash.MdiParent = this;
            aula_squash.Show();
        }
        private void marcação_PadelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mnuLogin.Enabled = false;
            mnuUtentes.Enabled = false;
            mnuProfessores.Enabled = false;
            mnuCampos.Enabled = false;
            mnuAulas.Enabled = false;
            mnuPreços.Enabled = false;
            frmMarcação_Aula_Padel aula_padel = new frmMarcação_Aula_Padel();
            aula_padel.MdiParent = this;
            aula_padel.Show();
        }
        private void tsConsumosUtentes_Click(object sender, EventArgs e)
        {
            mnuLogin.Enabled = false;
            mnuUtentes.Enabled = false;
            mnuProfessores.Enabled = false;
            mnuCampos.Enabled = false;
            mnuAulas.Enabled = false;
            mnuPreços.Enabled = false;
            frmConsumo consumo = new frmConsumo();
            consumo.MdiParent = this;
            consumo.Show();
        }
    }
}
