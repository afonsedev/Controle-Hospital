using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace ControleHospital.Repository
{
    public class CriaOuEditaAgendamentoRepository
    {

        readonly Conexao conexao = new Conexao();


        #region Método para Agendar Exame
        public void AgendarOuEditar(bool IsEditing, string codigoExame, DateTime dataExame, int codigoPaciente, string crmMedico, int especialidade, int sala, int codigoAgendamento)
        {
            try
            {
                string sqlQueryAgendar = @"INSERT INTO HOSPITAL.dbo.AGENDAMENTO_EXAME
                                               (cd_exame, dt_exame, cd_paciente, cd_crm_medico, cd_especialidade, cd_sala)
                                               VALUES (@codigoExame, @dataExame, @codigoPaciente, @crmMedico, @especialidade, @sala);
                                               SELECT SCOPE_IDENTITY()";

                string sqlQueryEditarAgendamento = @"UPDATE HOSPITAL.dbo.AGENDAMENTO_EXAME
                                                        SET cd_exame = @codigoExame, dt_exame = @dataExame, cd_paciente = @codigoPaciente, cd_crm_medico = @crmMedico, cd_especialidade = @especialidade, cd_sala = @sala
                                                        WHERE cd_agendamento_exame = @CodigoAgendamento";


                SqlParameter[] parametros =
                {
                    new SqlParameter("@codigoExame", codigoExame),
                    new SqlParameter("@dataExame",  dataExame),
                    new SqlParameter("@codigoPaciente", codigoPaciente),
                    new SqlParameter("@crmMedico", crmMedico),
                    new SqlParameter("@especialidade", especialidade),
                    new SqlParameter("@sala", sala),
                    new SqlParameter("@codigoAgendamento", codigoAgendamento)
                };


                if (IsEditing == true)
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


            catch (Exception ex)
            {
                MessageBox.Show($"Dados não inseridos corretamente: {ex.Message}");
                return;
            }
        }
        #endregion


        #region Método para mostrar dados do paciente
        public void MostrarDadosPaciente(TextBox cpf, TextBox nome, TextBox codigo, TextBox dataNascimento)
        {
            try
            {

                #region SQL Query
                string sqlQuery = @"SELECT 
                                    HOSPITAL.dbo.PACIENTE.nm_paciente AS 'NOME PACIENTE',
                                    HOSPITAL.dbo.PACIENTE.cd_paciente AS 'CÓDIGO PACIENTE',
                                    HOSPITAL.dbo.PACIENTE.data_nascimento_paciente AS 'DATA NASCIMENTO'

                                    FROM HOSPITAL.dbo.PACIENTE                               

                                    WHERE HOSPITAL.dbo.PACIENTE.cpf_paciente = @cpfPaciente";
                #endregion


                SqlParameter[] parametros =
                {
                    new SqlParameter("@cpfPaciente", cpf.Text)
                };


                nome.Clear();
                codigo.Clear();


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

                    nome.Text = paciente.Nome;
                    codigo.Text = paciente.Codigo.ToString();
                    dataNascimento.Text = paciente.DataNascimento.ToShortDateString();
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
        public void ExibirExamesComboBox(ComboBox nomeExame, TextBox codigoExame, TextBox nomeEspecialidade, TextBox codigoEspecialidade)
        {
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

            SqlParameter[] parametros =
            {
                new SqlParameter("@nomeExame", nomeExame.Text)
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

                string textoDigitado = nomeExame.Text;

                nomeExame.Items.Clear();
                nomeEspecialidade.Clear();

                var opcoesFiltradas = opcoesComboBox.Where(O => O.StartsWith(textoDigitado, StringComparison.OrdinalIgnoreCase)).ToList();
                nomeExame.Items.AddRange(opcoesFiltradas.ToArray());

                nomeEspecialidade.Text = especialidade.Nome;
                codigoExame.Text = exame.Codigo.ToString();
                codigoEspecialidade.Text = especialidade.Codigo.ToString();

                nomeExame.DroppedDown = true;
            }

            else
            {
                //txtNomeExame.Items.Clear();
            }
        }
        #endregion


        #region Método para exibir médico especializado
        public readonly Dictionary<string, int> medicoCrmMap = new Dictionary<string, int>();
        public void ExibirMedicoEspecializado(TextBox nomeEspecialidade, ComboBox medicoEspecializado, ComboBox salaExame)
        {

            #region Consulta SQL
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
            #endregion

            //Parâmetros SQL
            SqlParameter[] parametros = {
                new SqlParameter("@especialidade", nomeEspecialidade.Text.Trim())
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

                medicoEspecializado.Items.Clear();
                medicoEspecializado.Items.AddRange(opcoesComboBoxMedico.ToArray());

                salaExame.Items.Clear();
                salaExame.Items.AddRange(opcoesComboBoxSala.ToArray());
            }
        }
        #endregion

    }
}
