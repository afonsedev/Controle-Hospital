using ControleHospital.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleHospital.Handler
{
    public class HandlersFrmPai
    {
        public void ExibirFormAgendaExames()
        {
            FrmAgendaExame frmAgendaExame = new FrmAgendaExame();
            frmAgendaExame.Show();
        }


        public void ExibirFormConsultaExames()
        {
            FrmConsultaExames consultaExames = new FrmConsultaExames();
            consultaExames.Show();
        }


        public void ExibirOpcoesHemobanco(ContextMenuStrip contextMenu, Button button)
        {
            contextMenu.Show(button, new System.Drawing.Point(0, button.Height));
            if (contextMenu.Visible)
            {
                contextMenu.Hide();
            }

            else
            {
                contextMenu.Show(button, new System.Drawing.Point(0, button.Height));
            }
        }
        

        public void ExibirFormaAgendaTransfusao()
        {
            FrmAgendaTransfusao frmAgendaTransfusao = new FrmAgendaTransfusao();
            frmAgendaTransfusao.ShowDialog();
        }


        public void FecharApp(object sender, FormClosingEventArgs e)
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
    }
}