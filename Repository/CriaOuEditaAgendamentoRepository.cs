using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;
using System.Linq;
using ControleHospital.Forms;

namespace ControleHospital.Repository
{
    public class CriaOuEditaAgendamentoRepository
    {
        private FrmAgendaExame frmAgendaExame;

        public CriaOuEditaAgendamentoRepository(FrmAgendaExame frmAgendaExame, string nomeExame, DateTime dataExame, int codigoPaciente, string cpfPaciente, string nomePaciente, int crmMedico, string nomeMedico, string especialidade, int sala, int codigoAgendamento)
        {
            this.frmAgendaExame = frmAgendaExame;

            frmAgendaExame.TxtNomeExame.Text = nomeExame;
            frmAgendaExame.DateTimeExame.Value = dataExame;
            frmAgendaExame.TxtCodigoPaciente.Text = codigoPaciente.ToString();
            frmAgendaExame.TxtNomePaciente.Text = nomePaciente;
            frmAgendaExame.TxtCpfPaciente.Text = cpfPaciente;
            frmAgendaExame.TxtCrmMedico.Text = crmMedico.ToString();
            frmAgendaExame.txtMedicoResponsavelExame.Text = nomeMedico;
            frmAgendaExame.txtEspecialidadeExame.Text = especialidade;
            frmAgendaExame.txtSalaExame.Text = sala.ToString();
            frmAgendaExame.TxtCodigoAgendamento.Text = codigoAgendamento.ToString();

            frmAgendaExame.IsEditing = true;

            frmAgendaExame.Text = "Editar Exame";
            frmAgendaExame.BtnAgendaExame.Text = "Editar Agendamento";


            //Name = "Editar Exame";
            //TxtNomeExame.DroppedDown = false;
        }

        public CriaOuEditaAgendamentoRepository()
        {
        }

        public DateTime AjustarParaIntervalo(DateTime valor)
        {
            int minutos = valor.Minute;
            if (minutos % 30 != 0)
            {
                valor = new DateTime(valor.Year, valor.Month, valor.Day, valor.Hour, (minutos < 30 ? 0 : 30), 0);
            }
            return valor;
        }


        //Métodos
        #region Método para Mostrar dados do Paciente automaticamente
        public void MostrarDadosPaciente()
        {
            try
            {
                Conexao conexao = new Conexao();

                string sqlQuery = @"SELECT 
                                    HOSPITAL.dbo.PACIENTE.nm_paciente AS 'NOME PACIENTE',
                                    HOSPITAL.dbo.PACIENTE.cd_paciente AS 'CÓDIGO PACIENTE',
                                    HOSPITAL.dbo.PACIENTE.data_nascimento_paciente AS 'DATA NASCIMENTO'

                                    FROM HOSPITAL.dbo.PACIENTE                               

                                    WHERE HOSPITAL.dbo.PACIENTE.cpf_paciente = @cpfPaciente";

                // Defina os parâmetros para evitar SQL Injection
                SqlParameter[] parametros = {
                new SqlParameter("@cpfPaciente", frmAgendaExame.TxtCpfPaciente.Text.Trim())
                //new SqlParameter("@cpfPaciente", TxtCodigoExame.Text.Trim()
                };

                frmAgendaExame.TxtNomePaciente.Clear();
                frmAgendaExame.TxtCodigoPaciente.Clear();
                // Execute a consulta e obtenha o DataTable

                DataTable resultado = conexao.ExecutarConsulta(sqlQuery, parametros);

                if (resultado.Rows.Count > 0)
                {

                    DataRow dtr = resultado.Rows[0];
                    Paciente paciente = new Paciente();
                    {
                        paciente.Nome = dtr["NOME PACIENTE"].ToString();
                        paciente.Codigo = Convert.ToInt32(dtr["CÓDIGO PACIENTE"]);
                        paciente.DataNascimento = Convert.ToDateTime(dtr["DATA NASCIMENTO"]);
                    };

                    frmAgendaExame.TxtNomePaciente.Text = paciente.Nome;
                    frmAgendaExame.TxtCodigoPaciente.Text = paciente.Codigo.ToString();
                    frmAgendaExame.TxtDataNascimento.Text = paciente.DataNascimento.ToShortDateString();
                }

                else
                {
                    MessageBox.Show("CPF não corresponde a um paciente");
                    return;
                }
            }

            catch
            {
                MessageBox.Show("Erro ao buscar os dados.");
                return;
            }
        }
        #endregion


        #region Método para exibir exame
        public void ExibirExamesComboBox()
        {
            Conexao conexao = new Conexao();

            #region SQL Query
            string sqlQuery = @"SELECT 
                                 HOSPITAL.dbo.EXAME.nm_exame AS 'NOME EXAME',
                                 HOSPITAL.dbo.EXAME.cd_exame AS 'CÓDIGO EXAME',
                                 HOSPITAL.dbo.EXAME.cd_especialidade AS 'CÓDIGO ESPECIALIDADE',                              
                                 HOSPITAL.dbo.ESPECIALIDADE.nm_especialidade AS 'ESPECIALIDADE'                                
                                    FROM HOSPITAL.dbo.EXAME                              

                                    INNER JOIN HOSPITAL.dbo.ESPECIALIDADE
                                    ON HOSPITAL.dbo.ESPECIALIDADE.cd_especialidade = HOSPITAL.dbo.EXAME.cd_especialidade                                                                      

                                 WHERE HOSPITAL.dbo.EXAME.nm_exame LIKE @nomeExame + '%';";
            #endregion

            SqlParameter[] parametros = {
                new SqlParameter("@nomeExame", frmAgendaExame.TxtNomeExame.Text.Trim())
            };

            DataTable resultado = conexao.ExecutarConsulta(sqlQuery, parametros);

            if (resultado.Rows.Count > 0)
            {
                List<string> opcoesComboBox = new List<string>();
                Exame exame = new Exame();
                Especialidade especialidade = new Especialidade();

                DataRow dtr = resultado.Rows[0];
                {
                    opcoesComboBox.Add(dtr["NOME EXAME"].ToString());
                    especialidade.Nome = dtr["ESPECIALIDADE"].ToString();
                    exame.Codigo = Convert.ToInt32(dtr["CÓDIGO EXAME"]);
                    especialidade.Codigo = Convert.ToInt32(dtr["CÓDIGO ESPECIALIDADE"]);
                };

                string textoDigitado = frmAgendaExame.TxtNomeExame.Text;

                frmAgendaExame.TxtNomeExame.Items.Clear();
                frmAgendaExame.txtEspecialidadeExame.Clear();

                var opcoesFiltradas = opcoesComboBox.Where(O => O.StartsWith(textoDigitado, StringComparison.OrdinalIgnoreCase)).ToList();
                frmAgendaExame.TxtNomeExame.Items.AddRange(opcoesFiltradas.ToArray());

                frmAgendaExame.txtEspecialidadeExame.Text = especialidade.Nome;
                frmAgendaExame.TxtCodigoExame.Text = exame.Codigo.ToString();
                frmAgendaExame.TxtCodigoEspecialidade.Text = especialidade.Codigo.ToString();

                frmAgendaExame.TxtNomeExame.DroppedDown = true;
            }

            else
            {
                //txtNomeExame.Items.Clear();
            }
        }
        #endregion


        #region Método para exibir médico especialista
        public readonly Dictionary<string, int> medicoCrmMap = new Dictionary<string, int>();
        public void ExibirMedicoEspecializado()
        {
            Conexao conexao = new Conexao();

            //Consulta SQL
            string sqlQuery = @"SELECT  
                                    HOSPITAL.dbo.MEDICO.cd_crm_medico AS 'CRM MÉDICO',
                                    HOSPITAL.dbo.MEDICO.nm_medico AS 'NOME MÉDICO',
                                    HOSPITAL.dbo.ESPECIALIDADE.nm_especialidade AS 'ESPECIALIDADE',
                                    HOSPITAL.dbo.SALA.cd_sala AS 'SALA'
                                FROM HOSPITAL.dbo.ESPECIALIDADE

                                INNER JOIN HOSPITAL.dbo.MEDICO
                                ON HOSPITAL.dbo.MEDICO.cd_especialidade = HOSPITAL.dbo.ESPECIALIDADE.cd_especialidade

                                INNER JOIN HOSPITAL.dbo.SALA
                                ON HOSPITAL.dbo.MEDICO.cd_especialidade = HOSPITAL.dbo.SALA.cd_especialidade

                                WHERE HOSPITAL.dbo.ESPECIALIDADE.nm_especialidade = @especialidade";

            //Parâmetros SQL
            SqlParameter[] parametros = {
                new SqlParameter("@especialidade", frmAgendaExame.txtEspecialidadeExame.Text.Trim())
            };

            DataTable resultado = conexao.ExecutarConsulta(sqlQuery, parametros);

            if (resultado.Rows.Count > 0)
            {
                List<string> opcoesComboBoxMedico = new List<string>();
                List<string> opcoesComboBoxSala = new List<string>();

                Medico medico = new Medico();
                Sala sala = new Sala();

                foreach (DataRow dtr2 in resultado.Rows)
                {
                    opcoesComboBoxMedico.Add(dtr2["NOME MÉDICO"].ToString());
                    medico.Nome = dtr2["NOME MÉDICO"].ToString();

                    medico.CRM = Convert.ToInt32(dtr2["CRM MÉDICO"]);
                    medicoCrmMap[medico.Nome] = medico.CRM;
                };

                DataRow dtrSala = resultado.Rows[0];
                sala.Codigo = Convert.ToInt32(dtrSala["SALA"]);
                opcoesComboBoxSala.Add(dtrSala["SALA"].ToString());

                frmAgendaExame.txtMedicoResponsavelExame.Items.Clear();
                frmAgendaExame.txtMedicoResponsavelExame.Items.AddRange(opcoesComboBoxMedico.ToArray());

                frmAgendaExame.txtSalaExame.Items.Clear();
                frmAgendaExame.txtSalaExame.Items.AddRange(opcoesComboBoxSala.ToArray());
            }
        }
        #endregion


        #region Método para Agendar Exame
        public void AgendarOuEditarExame()
        {
            try
            {
                Conexao conexao = new Conexao();
                Especialidade especialidade = new Especialidade();

                string sqlQueryAgendar = @"INSERT INTO HOSPITAL.dbo.AGENDAMENTO_EXAME
                                            VALUES (@codigoExame, @dataExame, @codigoPaciente, @crmMedico, @especialidade, @sala);
                                           SELECT SCOPE_IDENTITY();";


                string sqlQueryEditarAgendamento = @"UPDATE HOSPITAL.dbo.AGENDAMENTO_EXAME
                                                    SET cd_exame = @codigoExame, dt_exame = @dataExame, cd_paciente = @codigoPaciente, cd_crm_medico = @crmMedico, cd_especialidade = @Especialidade, cd_sala = @sala
                                                    WHERE cd_agendamento_exame = @CodigoAgendamento";

                SqlParameter[] parametros =
                {
                    new SqlParameter("@codigoExame", frmAgendaExame.TxtCodigoExame.Text),
                    new SqlParameter("@dataExame", frmAgendaExame.DateTimeExame.Text),
                    new SqlParameter("@codigoPaciente", frmAgendaExame.TxtCodigoPaciente.Text),
                    new SqlParameter("@crmMedico", frmAgendaExame.TxtCrmMedico.Text),
                    new SqlParameter("@especialidade", frmAgendaExame.TxtCodigoEspecialidade.Text),
                    new SqlParameter("@sala", frmAgendaExame.txtSalaExame.Text),
                    new SqlParameter("@codigoAgendamento", frmAgendaExame.TxtCodigoAgendamento.Text)
                };

                if (frmAgendaExame.IsEditing == true)
                {
                    DataTable resultado = conexao.ExecutarConsulta(sqlQueryEditarAgendamento, parametros);
                    MessageBox.Show("Alterações realizadas com sucesso");
                    return;
                }

                else
                {
                    object resultado = conexao.ExecutarEscalar(sqlQueryAgendar, parametros);
                    int novoCodigoAgendamento = Convert.ToInt32(resultado);
                    //DataTable resultado = conexao.ExecutarConsulta(sqlQueryAgendar, parametros);
                    MessageBox.Show($"Código do Agendamento: {novoCodigoAgendamento} \r\nO e-mail sobre o exame foi enviado ao usuário.");
                    return;
                }
            }


            catch
            {
                MessageBox.Show("Dados não inseridos corretamente.");
                return;
            }
        }
        #endregion
    }
}
