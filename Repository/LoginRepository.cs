using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ControleHospital.Repository
{
    public class LoginRepository
    {  
        
        public void AutenticarUsuario(FrmLogin frmLogin)
        {
            var usuario = frmLogin.CampoUsuario;
            var senha = frmLogin.CampoSenha;

            try
            {
                Conexao conexao = new Conexao();

                #region Consulta SQL
                string sqlQuery = @"SELECT 
                                    u.cd_usuario AS 'CÓDIGO USUÁRIO',
                                    u.nm_usuario AS 'NOME USUÁRIO',
                                    u.senha_usuario AS 'SENHA', 
                                    s.nm_setor AS 'SETOR',
                                    f.nm_funcionario AS 'NOME FUNCIONÁRIO'
                                FROM 
                                    HOSPITAL.dbo.USUARIO u
                                INNER JOIN 
                                    HOSPITAL.dbo.SETOR s
                                ON 
                                    s.cd_setor = u.cd_setor
                                INNER JOIN 
                                    HOSPITAL.dbo.FUNCIONARIO f
                                ON
                                    f.cd_funcionario = u.cd_usuario
                                WHERE 
                                    u.nm_usuario = @nomeUsuario
                                AND 
                                    u.senha_usuario = @senhaUsuario";
                #endregion

                string nomeUsuario = usuario;
                string senhaUsuario = senha;


                // Defina os parâmetros para evitar SQL Injection
                SqlParameter[] parametros = 
                {
                    new SqlParameter("@nomeUsuario", nomeUsuario),
                    new SqlParameter("@senhaUsuario", senhaUsuario)
                };


                // Execute a consulta e obtenha o DataTable
                DataTable resultado = conexao.ExecutarConsulta(sqlQuery, parametros);
                if (resultado.Rows.Count > 0)
                {

                    Usuario usuarioLogado = new Usuario();

                    foreach (DataRow dtr in resultado.Rows)
                    {
                        usuarioLogado.Nome = dtr["NOME FUNCIONÁRIO"].ToString();
                        usuarioLogado.Setor = dtr["SETOR"].ToString();
                    }
                    FrmPai frmPai = new FrmPai(usuarioLogado);
                    frmPai.Show();
                    frmLogin.Hide();
                }

                else
                {
                    frmLogin.LblDadosIncorretos.Visible = true;
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

