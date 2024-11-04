using QRCoder;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using ControleHospital.Forms;

namespace ControleHospital.Repository
{
    public class ConsultaAgendamentoRepository
    {
        #region Método para Consultar Agendamento
        public void ConsultarAgendamento(FrmConsultaExames frmConsultaExames, int codigoAgendamento)
        {

            var CampoCodigoAgendamento = frmConsultaExames.CampoCodigoAgendamento;
            var GridViewExame = frmConsultaExames.DataGridViewExame;
            
            try
            {
                Conexao conexao = new Conexao();

                #region Consulta SQL
                string sqlQuery = @"SELECT
                                AGENDAMENTO_EXAME.cd_agendamento_exame AS 'CÓDIGO AGENDAMENTO',
                                AGENDAMENTO_EXAME.cd_exame AS 'CÓDIGO EXAME', 
                                AGENDAMENTO_EXAME.dt_exame AS 'DATA', 
                                AGENDAMENTO_EXAME.cd_crm_medico AS 'CRM MÉDICO',
                                AGENDAMENTO_EXAME.cd_paciente AS 'CÓDIGO PACIENTE', 
                                AGENDAMENTO_EXAME.cd_sala AS 'SALA',
                                EXAME.nm_exame AS 'NOME EXAME', 
                                EXAME.ds_exame AS 'DESCRIÇÃO',                                 
                                PACIENTE.nm_paciente AS 'NOME PACIENTE',
                                PACIENTE.cpf_paciente AS 'CPF',
                                MEDICO.nm_medico AS 'NOME MÉDICO',
                                ESPECIALIDADE.nm_especialidade AS 'ESPECIALIDADE'
                            FROM HOSPITAL.dbo.AGENDAMENTO_EXAME

                            INNER JOIN HOSPITAL.dbo.PACIENTE
                            ON PACIENTE.cd_paciente = AGENDAMENTO_EXAME.cd_paciente

                            INNER JOIN HOSPITAL.dbo.ESPECIALIDADE
                            ON ESPECIALIDADE.cd_especialidade = AGENDAMENTO_EXAME.cd_especialidade

                            INNER JOIN HOSPITAL.dbo.MEDICO
                            ON MEDICO.cd_crm_medico = AGENDAMENTO_EXAME.cd_crm_medico

                            INNER JOIN HOSPITAL.dbo.EXAME
                            ON EXAME.cd_exame = AGENDAMENTO_EXAME.cd_exame

                           WHERE AGENDAMENTO_EXAME.cd_agendamento_exame = @codigoAgendamento";
                #endregion


                // Defina os parâmetros para evitar SQL Injection
                SqlParameter[] parametros = {
                new SqlParameter("@codigoAgendamento", codigoAgendamento),
                //new SqlParameter("@cpfPaciente", TxtCodigoExame.Text.Trim()
                };

                // Execute a consulta e obtenha o DataTable
                DataTable resultado = conexao.ExecutarConsulta(sqlQuery, parametros);


                if (string.IsNullOrEmpty(CampoCodigoAgendamento) || resultado.Rows.Count == 0)
                {
                    MessageBox.Show("Insira o código corretamente.");
                    return;
                }


                if (resultado.Rows.Count > 0)
                {
                    List<Exame> exames = new List<Exame>();
                    List<Paciente> pacientes = new List<Paciente>();
                    List<Medico> medicos = new List<Medico>();
                    List<Especialidade> especialidades = new List<Especialidade>();
                    List<Sala> salas = new List<Sala>();

                    foreach (DataRow dtr in resultado.Rows)
                    {
                        Exame exame = new Exame();
                        Paciente paciente = new Paciente();
                        Medico medico = new Medico();
                        Especialidade especialidade = new Especialidade();
                        Sala sala = new Sala();
                        {
                            paciente.Nome = dtr["NOME PACIENTE"].ToString();
                            paciente.Codigo = Convert.ToInt32(dtr["CÓDIGO PACIENTE"]);
                            paciente.CPF = dtr["CPF"].ToString();
                            exame.Nome = dtr["NOME EXAME"].ToString();
                            exame.CodigoAgendamento = Convert.ToInt32(dtr["CÓDIGO AGENDAMENTO"]);
                            exame.Codigo = Convert.ToInt32(dtr["CÓDIGO EXAME"]);
                            exame.Data = Convert.ToDateTime(dtr["DATA"]); // Mantém o DateTime
                            exame.Descricao = dtr["DESCRIÇÃO"].ToString();
                            medico.CRM = Convert.ToInt32(dtr["CRM MÉDICO"]);
                            medico.Nome = dtr["NOME MÉDICO"].ToString();
                            especialidade.Nome = dtr["ESPECIALIDADE"].ToString();
                            sala.Codigo = Convert.ToInt32(dtr["SALA"]);
                        };

                        exames.Add(exame);
                        pacientes.Add(paciente);
                        medicos.Add(medico);
                        especialidades.Add(especialidade);
                        salas.Add(sala);
                        GridViewExame.DataSource = resultado;
                        GridViewExame.Rows[0].Selected = true;

                        var qrCodeInfo = $"Nome {paciente.Nome} | Código Paciente: {paciente.Codigo} | Exame: {exame.Nome} | Código Exame: {exame.Codigo} | Data: {exame.Data} | Descrição: {exame.Descricao} | CRM do Médico: {medico.CRM} | Nome do Médico: {medico.Nome} | Especialidade: {especialidade.Nome} | Sala: {sala.Codigo} | Código do Agendamento: {exame.CodigoAgendamento}";

                        QRCodeGenerator qrg = new QRCodeGenerator();
                        QRCodeData qRCodeData = qrg.CreateQrCode(qrCodeInfo, QRCodeGenerator.ECCLevel.Q);
                        PngByteQRCode qrCode = new PngByteQRCode(qRCodeData);
                        byte[] qrCodeImage = qrCode.GetGraphic(20);
                        MemoryStream ms = new MemoryStream(qrCodeImage);
                        frmConsultaExames.PictureBoxQrCode.Image = Image.FromStream(ms);
                    }
                }
            }

            catch
            {
                MessageBox.Show("Ocorreu um problema técnico. Tente novamente em 5 segundos");
                return;
            }
        }
        #endregion


        #region Método para Apagar Agendamento
        public void ApagarAgendamento(FrmConsultaExames frmConsultaExames)
        {
            try
            {
                var CampoCodigoAgendamento = frmConsultaExames.CampoCodigoAgendamento;
                DialogResult result = MessageBox.Show("Tem certeza de que quer apagar o agendamento?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    Conexao conexao = new Conexao();



                    #region Consulta SQL
                    string sqlQuery = @"DELETE 
                                    FROM 
                                      HOSPITAL.dbo.AGENDAMENTO_EXAME
                                    WHERE 
                                      cd_agendamento_exame = @codigoAgendamento";
                    #endregion


                    // Defina os parâmetros para evitar SQL Injection
                    SqlParameter[] parametros = {
                new SqlParameter("@codigoAgendamento", CampoCodigoAgendamento)
                };

                    // Execute a consulta e obtenha o DataTable
                    DataTable resultado = conexao.ExecutarConsulta(sqlQuery, parametros);



                    MessageBox.Show("Agendamento apagado.");
                    //dataGridView1.Rows.Clear();
                    return;
                }

                else
                {
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Erro ao mostrar os dados");
            }
        }
        #endregion


        #region Método para abrir o form no modo edição
        public void AbrirTelaEdicao(FrmConsultaExames frmConsultaExames)
        {
            try
            {
                var GridViewExame = frmConsultaExames.DataGridViewExame;

                if (GridViewExame.Rows.Count > 0 && GridViewExame.SelectedRows.Count > 0)
                {
                    // Pega os valores da linha selecionada no DataGridView
                    string nomePaciente = GridViewExame.SelectedRows[0].Cells["NomePaciente"].Value.ToString();
                    string cpfPaciente = GridViewExame.SelectedRows[0].Cells["CPF"].Value.ToString();
                    int codigoAgendamento = Convert.ToInt32(GridViewExame.SelectedRows[0].Cells["CodigoAgendamento"].Value);
                    DateTime dataExame = Convert.ToDateTime(GridViewExame.SelectedRows[0].Cells["DATA"].Value);
                    int crmMedico = Convert.ToInt32(GridViewExame.SelectedRows[0].Cells["CrmMedico"].Value);
                    int codigoPaciente = Convert.ToInt32(GridViewExame.SelectedRows[0].Cells["CodigoPaciente"].Value);
                    string nomeMedico = GridViewExame.SelectedRows[0].Cells["NomeMedico"].Value.ToString();
                    string nomeExame = GridViewExame.SelectedRows[0].Cells["NomeExame"].Value.ToString();
                    string especialidade = GridViewExame.SelectedRows[0].Cells["Especialidade"].Value.ToString();
                    int sala = Convert.ToInt32(GridViewExame.SelectedRows[0].Cells["SALA"].Value);

                    // Cria uma instância do formulário de edição e passa os dados
                    FrmAgendaExame frmAgendaExame = new FrmAgendaExame(
                        nomeExame,
                        dataExame,
                        codigoPaciente,
                        cpfPaciente,
                        nomePaciente,
                        crmMedico,
                        nomeMedico,
                        especialidade,
                        sala,
                        codigoAgendamento
                    );

                    // Abre o formulário como diálogo
                    frmAgendaExame.ShowDialog();
                }
            }
            catch
            {
                MessageBox.Show("Selecione um agendamento para editar.");
            }
        }
        #endregion
    }
}
