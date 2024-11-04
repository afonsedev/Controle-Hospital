using ControleHospital.Repository;
using System;
using System.Windows.Forms;

namespace ControleHospital
{
    public partial class FrmConsultaExames : Form
    {
        public ConsultaAgendamentoRepository consultaAgendamentoRepository = new ConsultaAgendamentoRepository();

        public FrmConsultaExames()
        {
            InitializeComponent();
        }

        public string CampoCodigoAgendamento
        {
            get { return TxtCodigoExame.Text; }
        }


        public DataGridView DataGridViewExame
        {
            get { return dataGridView1; }
        }


        private void BtnPesquisa_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TxtCodigoExame.Text.Trim(), out int codigoAgendamento))
            {
                consultaAgendamentoRepository.ConsultarAgendamento(this, codigoAgendamento);
            }
        }


        private void BtnApagaExame_Click1(object sender, EventArgs e)
        {
            consultaAgendamentoRepository.ApagarAgendamento(this);
        }


        private void BtnEditaExame_Click(object sender, EventArgs e)
        {
            consultaAgendamentoRepository.AbrirTelaEdicao(this);
        }


        private void TxtCodigoExame_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloqueia a tecla pressionada
            }

            if (e.KeyChar == (char)Keys.Enter && (int.TryParse(TxtCodigoExame.Text.Trim(), out int codigoAgendamento)))
            {
                e.Handled = true;
                consultaAgendamentoRepository.ConsultarAgendamento(this, codigoAgendamento);
            }
        }
    }
}
