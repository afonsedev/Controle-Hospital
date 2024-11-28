using ControleHospital.Handler;
using ControleHospital.Repository;
using System;
using System.Windows.Forms;

namespace ControleHospital.Forms
{
    public partial class FrmAgendaExame : Form
    {

        public bool IsEditing = false;
        internal readonly Conexao conexao = new Conexao();
        public HandlersFrmAgendaExame handlersFrmAgendaExame = new HandlersFrmAgendaExame();
        public CriaOuEditaAgendamentoRepository criaOuEditaAgendamentoRepository = new CriaOuEditaAgendamentoRepository();



        public FrmAgendaExame()
        {
            InitializeComponent();
        }


        public FrmAgendaExame(string nomeExame, DateTime dataExame, int codigoPaciente, string cpfPaciente, string nomePaciente, int crmMedico, string nomeMedico, string especialidade, int sala, int codigoAgendamento)
        {
            InitializeComponent();
            IsEditing = true;

            TxtNomeExame.Text = nomeExame;
            DateTimeExame.Value = dataExame;
            TxtCodigoPaciente.Text = codigoPaciente.ToString();
            TxtNomePaciente.Text = nomePaciente;
            TxtCpfPaciente.Text = cpfPaciente;
            TxtCrmMedico.Text = crmMedico.ToString();
            txtMedicoResponsavelExame.Text = nomeMedico;
            txtEspecialidadeExame.Text = especialidade;
            txtSalaExame.Text = sala.ToString();
            TxtCodigoAgendamento.Text = codigoAgendamento.ToString();

            Text = "Editar Exame";
            BtnAgendaExame.Text = "Editar Agendamento";
        }


        //Eventos
        private void BtnAgendaExame_Click(object sender, EventArgs e)
        {
            string codigoExame = TxtCodigoExame.Text;
            DateTime dataExame = DateTimeExame.Value;
            int codigoPaciente = int.Parse(TxtCodigoPaciente.Text);
            string crmMedico = TxtCrmMedico.Text;
            int especialidade = int.Parse(TxtCodigoEspecialidade.Text);
            int sala = int.Parse(txtSalaExame.Text);
            int codigoAgendamento = string.IsNullOrEmpty(TxtCodigoAgendamento.Text) ? 0 : int.Parse(TxtCodigoAgendamento.Text);


            criaOuEditaAgendamentoRepository.AgendarOuEditar(IsEditing, codigoExame, dataExame, codigoPaciente, crmMedico, especialidade, sala, codigoAgendamento);
        }


        private void TxtCpfPaciente_TextChanged(object sender, EventArgs e)
        {
            TxtCpfPaciente.MaxLength = 11;
            if (TxtCpfPaciente.Text.Length == 11)
            {
                criaOuEditaAgendamentoRepository.MostrarDadosPaciente(TxtCpfPaciente, TxtNomePaciente, TxtCodigoPaciente, TxtDataNascimento);
            }
        }


        private void TxtCpfPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloqueia a tecla pressionada
            }
        }


        private void TxtNomeExame_TextChanged(object sender, EventArgs e)
        {
            criaOuEditaAgendamentoRepository.ExibirExamesComboBox(TxtNomeExame, TxtCodigoExame, txtEspecialidadeExame, TxtCodigoEspecialidade);
        }


        private void TxtMedicoResponsavelExame_DropDown(object sender, EventArgs e)
        {
            criaOuEditaAgendamentoRepository.ExibirMedicoEspecializado(txtEspecialidadeExame, txtMedicoResponsavelExame, txtSalaExame);
        }


        private void DateTimeExame_KeyDown(object sender, KeyEventArgs e)
        {
            if (sender is DateTimePicker dtp && dtp.Value != null)
            {
                if (e.KeyCode == Keys.Up)
                {
                    dtp.Value = AjustarParaIntervalo(dtp.Value.AddMinutes(30));
                }

                else if
                (e.KeyCode == Keys.Down)
                {
                    dtp.Value = AjustarParaIntervalo(dtp.Value.AddMinutes(-30));
                }
            }
        }


        private DateTime AjustarParaIntervalo(DateTime valor)
        {
            int minutos = valor.Minute;
            if (minutos % 30 != 0)
            {
                valor = new DateTime(valor.Year, valor.Month, valor.Day, valor.Hour, (minutos < 30 ? 0 : 30), 0);
            }
            return valor;
        }


        private void TxtMedicoResponsavelExame_SelectedIndexChanged(object sender, EventArgs e)
        {
            handlersFrmAgendaExame.ExibirCRM(txtMedicoResponsavelExame, TxtCrmMedico, criaOuEditaAgendamentoRepository.medicoCrmMap);
        }
    }
}

