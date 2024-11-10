using ControleHospital.Provider;
using System;
using System.Data;
using System.Data.SqlClient;
using MessageBox = System.Windows.MessageBox;

namespace ControleHospital
{
    internal class Conexao
    {
        private readonly string connectionString;
        public bool isConnected = false;

        public Conexao()
        {           
            connectionString = ConnectionProvider.HospitalConnectionString;
        }


        public SqlConnection AbrirConexao()
        {
            SqlConnection conexao = new SqlConnection(connectionString);

            try
            {
                conexao.Open();
                isConnected = true;
            }

            catch (Exception)
            {
                MessageBox.Show("Falha :(");
            }

            return conexao;
        }


        public void FecharConexao(SqlConnection conexao)
        {
            try
            {
                if (conexao != null && conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao fechar processo.");
            }
        }


        public DataTable ExecutarConsulta(string query, SqlParameter[] parametros = null)
        {
            using (SqlConnection conexao = AbrirConexao())
            {
                using (SqlCommand comando = new SqlCommand(query, conexao))
                {
                    // Adiciona parâmetros se existirem
                    if (parametros != null)
                    {
                        comando.Parameters.AddRange(parametros);
                    }

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        DataTable tabela = new DataTable();
                        adaptador.Fill(tabela);

                        return tabela;
                    }
                }
            }
        }


        public object ExecutarEscalar(string query, SqlParameter[] parametros = null)
        {
            using (SqlConnection conexao = AbrirConexao())
            {
                using (SqlCommand comando = new SqlCommand(query, conexao))
                {
                    if (parametros != null && query.Contains("SCOPE_IDENTITY()"))
                    {
                        comando.Parameters.AddRange(parametros);
                    }

                    return comando.ExecuteScalar();
                }
            }
        }
    }
}
