﻿using ControleHospital;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleHospital.Forms
{
    public partial class FrmAgendaExame : Form
    {
        public FrmAgendaExame()
        {
            InitializeComponent();
        }

        private void FrmAdicionaAgendamentoExame_Load(object sender, EventArgs e)
        {

        }

        private void BtnAgendaExame_Click(object sender, EventArgs e)
        {
            AgendarExame();
        }


        private void TxtCpfPaciente_TextChanged(object sender, EventArgs e)
        {
            TxtCpfPaciente.MaxLength = 11;
            if (TxtCpfPaciente.Text.Length == 11)
            {
                MostrarDadosPaciente();
            }
        }


        private void txtNomeExame_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtCpfPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloqueia a tecla pressionada
            }
        }


        private void txtNomeExame_TextChanged(object sender, EventArgs e)
        {
            ExibirExamesComboBox();
        }


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
                new SqlParameter("@cpfPaciente", TxtCpfPaciente.Text.Trim())
                //new SqlParameter("@cpfPaciente", TxtCodigoExame.Text.Trim()
                };

                TxtNomePaciente.Clear();
                TxtCodigoPaciente.Clear();
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

                    TxtNomePaciente.Text = paciente.Nome;
                    TxtCodigoPaciente.Text = paciente.Codigo.ToString();
                    TxtDataNascimento.Text = paciente.DataNascimento.ToShortDateString();
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
                new SqlParameter("@nomeExame", txtNomeExame.Text.Trim())
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

                string textoDigitado = txtNomeExame.Text;

                txtNomeExame.Items.Clear();
                txtEspecialidadeExame.Clear();

                var opcoesFiltradas = opcoesComboBox.Where(O => O.StartsWith(textoDigitado, StringComparison.OrdinalIgnoreCase)).ToList();
                txtNomeExame.Items.AddRange(opcoesFiltradas.ToArray());

                txtNomeExame.DroppedDown = true;
                // txtNomeExame.SelectionStart = textoDigitado.Length;
                txtEspecialidadeExame.Text = especialidade.Nome;
                TxtCodigoExame.Text = exame.Codigo.ToString();
                TxtCodigoEspecialidade.Text = especialidade.Codigo.ToString();
            }

            else
            {
                //txtNomeExame.Items.Clear();
            }


        }
        #endregion

        public void ExibirMedicoEspecializado()
        {
            Conexao conexao = new Conexao();

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

            SqlParameter[] parametros = {
                new SqlParameter("@especialidade", txtEspecialidadeExame.Text.Trim())
            };

            DataTable resultado = conexao.ExecutarConsulta(sqlQuery, parametros);

            if (resultado.Rows.Count > 0)
            {
                List<string> opcoesComboBoxMedico = new List<string>();
                List<string> opcoesComboBoxSala = new List<string>();
                Medico medico = new Medico();
                Sala sala = new Sala();
                DataRow dtr = resultado.Rows[0];
                {
                    opcoesComboBoxMedico.Add(dtr["NOME MÉDICO"].ToString());
                    medico.Nome = dtr["NOME MÉDICO"].ToString();

                    sala.Codigo = Convert.ToInt32(dtr["SALA"]);
                    opcoesComboBoxSala.Add(dtr["SALA"].ToString());

                    medico.CRM = Convert.ToInt32(dtr["CRM MÉDICO"]);

                };

                txtMedicoResponsavelExame.Items.Clear();
                txtMedicoResponsavelExame.Items.AddRange(opcoesComboBoxMedico.ToArray());

                txtSalaExame.Items.Clear();
                txtSalaExame.Items.AddRange(opcoesComboBoxSala.ToArray());

                TxtCrmMedico.Text = medico.CRM.ToString();
                // txtMedicoResponsavelExame.Text = opcoesComboBox.ToString();
                //txtMedicoResponsavelExame.DroppedDown = true;
            }

        }

        private void txtMedicoResponsavelExame_DropDown(object sender, EventArgs e)
        {
            ExibirMedicoEspecializado();
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
            if(minutos % 30 != 0)
            {
                valor = new DateTime(valor.Year, valor.Month, valor.Day, valor.Hour, (minutos < 30 ? 0 : 30), 0);
            }
            return valor;
        }

        public void AgendarExame()
        {

            try
            {
                Conexao conexao = new Conexao();
                Especialidade especialidade = new Especialidade();


                string sqlQuery = @"INSERT INTO HOSPITAL.dbo.AGENDAMENTO_EXAME
                                    VALUES (@codigoExame, @dataExame, @codigoPaciente, @crmMedico, @especialidade, @sala)";

                SqlParameter[] parametros = {
                    new SqlParameter("@codigoExame", TxtCodigoExame.Text),
                    new SqlParameter("@dataExame", DateTimeExame.Text),
                    new SqlParameter("@codigoPaciente", TxtCodigoPaciente.Text),
                    new SqlParameter("@crmMedico", TxtCrmMedico.Text),
                    new SqlParameter("@especialidade", TxtCodigoEspecialidade.Text),
                    new SqlParameter("@sala", txtSalaExame.Text)
                };

                DataTable resultado = conexao.ExecutarConsulta(sqlQuery, parametros);


                MessageBox.Show("Agendamento realizado com sucesso");
            }

            catch
            {
                MessageBox.Show("Dados não inseridos corretamente.");
                return;
            }
            
        }
        
    }
}