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

namespace ControleHospital
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao conexao = new Conexao();               
                #region Consulta SQL
                string sqlQuery = @"SELECT 
                                        u.cd_usuario AS 'CÓDIGO USUÁRIO',
                                        u.nm_usuario AS 'NOME USUÁRIO', 
                                        u.senha_usuario AS 'SENHA', 
                                        s.nm_setor AS 'SETOR'
                                    FROM 
                                        HOSPITAL.dbo.USUARIO u
                                    INNER JOIN 
                                        HOSPITAL.dbo.SETOR s
                                    ON 
                                        s.cd_setor = u.cd_setor
                                    WHERE 
                                        u.nm_usuario = @nomeUsuario
                                    AND 
                                        u.senha_usuario = @senhaUsuario";
                #endregion

                string nomeUsuario = TxtNome.Text;
                string senhaUsuario = TxtSenha.Text;
                // Defina os parâmetros para evitar SQL Injection
                SqlParameter[] parametros = {
                new SqlParameter("@nomeUsuario", nomeUsuario),
                new SqlParameter("@senhaUsuario", senhaUsuario)

                };

                // Execute a consulta e obtenha o DataTable
                DataTable resultado = conexao.ExecutarConsulta(sqlQuery, parametros);
                if (resultado.Rows.Count > 0)
                {

                    Usuario usuarioLogado = new Usuario();
                    FrmPai frmPai = new FrmPai();

                    foreach (DataRow dtr in resultado.Rows)
                    {
                       
                            usuarioLogado.Nome = dtr["NOME USUÁRIO"].ToString();                       
                            usuarioLogado.Setor = dtr["SETOR"].ToString();                       
                    }

                    frmPai.Show();
                    this.Hide();
                }

                else
                {
                    LblDadosIncorretos.Visible = true;
                }

            }

            catch
            {
                MessageBox.Show("Ocorreu um problema técnico. Tente novamente em 5 segundos");
                return;
            }
        }
    }
}
