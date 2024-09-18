using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleHospital
{
    public partial class FrmPai : Form
    {


        public FrmPai( )
        {
            InitializeComponent();
            InfoUsuario();
        }

     


        private void BtnConsultarExame_Click(object sender, EventArgs e)
        {
            FrmConsultaExames consultaExames = new FrmConsultaExames();
            consultaExames.Show();
        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {

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
                LblConectado.Text = $"Conectado";
                ImgCheck.Visible = true;                
            }
        }

        private void ImgCheck_Click(object sender, EventArgs e)
        {

        }
    }
}
