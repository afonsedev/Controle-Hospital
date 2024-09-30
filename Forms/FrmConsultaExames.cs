using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using QRCoder;

namespace ControleHospital
{
    public partial class FrmConsultaExames : Form
    {
        public FrmConsultaExames()
        {
            InitializeComponent();
        }

        private void FilaExames_Load(object sender, EventArgs e)
        {
 

        }

        private void BtnPesquisa_Click(object sender, EventArgs e)
        {
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
                new SqlParameter("@codigoAgendamento", TxtCodigoExame.Text.Trim()),
                //new SqlParameter("@cpfPaciente", TxtCodigoExame.Text.Trim()
                };

                // Execute a consulta e obtenha o DataTable
                DataTable resultado = conexao.ExecutarConsulta(sqlQuery, parametros);
                

                if (string.IsNullOrEmpty(TxtCodigoExame.Text) || resultado.Rows.Count == 0)
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
                        dataGridView1.DataSource = resultado;

                        // var qrCodeInfo = paciente.Nome.ToString() + paciente.Codigo + exame.Nome + exame.Codigo + exame.Data + exame.Descricao + medico.CRM + medico.Nome
                        //                                         + especialidade.Nome + sala.Codigo + exame.CodigoAgendamento;
                        
                        var qrCodeInfo = $"Nome {paciente.Nome} | Código Paciente: {paciente.Codigo} | Exame: {exame.Nome} | Código Exame: {exame.Codigo} | Data: {exame.Data} | Descrição: {exame.Descricao} | CRM do Médico: {medico.CRM} | Nome do Médico: {medico.Nome} | Especialidade: {especialidade.Nome} | Sala: {sala.Codigo} | Código do Agendamento: {exame.CodigoAgendamento}";

                        QRCodeGenerator qrg = new QRCodeGenerator();
                        QRCodeData qRCodeData = qrg.CreateQrCode(qrCodeInfo, QRCodeGenerator.ECCLevel.Q);
                        PngByteQRCode qrCode = new PngByteQRCode(qRCodeData);
                        byte[] qrCodeImage = qrCode.GetGraphic(20);
                        MemoryStream ms = new MemoryStream(qrCodeImage);
                        ImgQrCodeExame.Image = Image.FromStream(ms);                      

                    }
                }
            }



            catch
            {
                MessageBox.Show("Ocorreu um problema técnico. Tente novamente em 5 segundos");
                return;
            }
        }


        private void TxtCodigoExame_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloqueia a tecla pressionada
            }
        }


        private void btnApagaExame_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza de que quer apagar o agendamento?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            
            if(result == DialogResult.Yes)
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
                new SqlParameter("@codigoAgendamento", TxtCodigoExame.Text)
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
    }
}
