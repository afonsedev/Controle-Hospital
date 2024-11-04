using ControleHospital.Forms;
using ControleHospital.Handler;
using ControleHospital.Provider;
using System;
using System.Windows.Forms;


namespace ControleHospital
{
    public partial class FrmPai : Form
    {
        private HandlersFrmPai handlersFrmPai = new HandlersFrmPai();

        public FrmPai(Usuario usuarioPassado)
        {
            InitializeComponent();
            UsuarioProvider usuarioProvider = new UsuarioProvider();
            usuarioProvider.usuario = usuarioPassado;
            usuarioProvider.InfoUsuario(this);
        }
    

        private void BtnConsultarExame_Click(object sender, EventArgs e)
        {
            handlersFrmPai.ExibirFormConsultaExames();       
        }
      

        private void BtnHemoBanco_Click(object sender, EventArgs e)
        {
            handlersFrmPai.ExibirOpcoesHemobanco(contextMenuStrip1, BtnHemoBanco);
        }


        private void FrmPai_FormClosing(object sender, FormClosingEventArgs e)
        {
            handlersFrmPai.FecharApp(sender, e);        
        }


        private void BtnAgendarExame_Click(object sender, EventArgs e)
        {
            handlersFrmPai.ExibirFormAgendaExames();
        }


        private void transfusãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            handlersFrmPai.ExibirFormaAgendaTransfusao();
        }       
    }
}
