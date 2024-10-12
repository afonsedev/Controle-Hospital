using ControleHospital.Forms;
using System;
using System.Windows.Forms;


namespace ControleHospital
{
    public partial class FrmPai : Form
    {
        private Usuario usuario;

        public FrmPai(Usuario usuarioPassado)
        {
            InitializeComponent();
            this.usuario = usuarioPassado;
            InfoUsuario();
        }
    
        private void BtnConsultarExame_Click(object sender, EventArgs e)
        {
            FrmConsultaExames consultaExames = new FrmConsultaExames();
            consultaExames.Show();            
        }
      

        private void BtnHemoBanco_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(BtnHemoBanco, new System.Drawing.Point(0, BtnHemoBanco.Height));
        }

        private void InfoUsuario()
        {
            Conexao conexao = new Conexao();
           // Usuario usuario = new Usuario();

            if (conexao.AbrirConexao() != null)
            {
                LblConectado.Text = $"Conectado | Funcionário: {usuario.Nome} | Setor: {usuario.Setor}";
                ImgCheck.Visible = true;                
            }
        }

        private void FrmPai_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza de que deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            
            if (result == DialogResult.No) 
            { 
                e.Cancel = true;
            }

            else 
            { 
              Application.Exit();                
            }
        
        }

        private void BtnAgendarExame_Click(object sender, EventArgs e)
        {
            FrmAgendaExame frmAgendaExame = new FrmAgendaExame();
            frmAgendaExame.Show();
        }

        private void transfusãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgendaTransfusao frmAgendaTransfusao = new FrmAgendaTransfusao();
            frmAgendaTransfusao.ShowDialog();
        }

        private void FrmPai_Load(object sender, EventArgs e)
        {

        }
    }
}
