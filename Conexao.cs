using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace ControleHospital
{
    internal class Conexao
    {
        private readonly string connectionString;
        public bool isConnected = false;


        public Conexao()
        {
            // Inicialize a string de conexão aqui.
            connectionString = @"Data Source = ACER-ASPIRE; Integrated Security = True; Connect Timeout = 30; Encrypt=True; TrustServerCertificate= True; ApplicationIntent = ReadWrite; MultiSubnetFailover=False";
        }

        // Método para abrir uma conexão
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

       


        // Método para executar uma consulta SQL e retornar um DataTable
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

    }
}