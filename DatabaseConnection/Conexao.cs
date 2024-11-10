using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using ControleHospital.Provider;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;

namespace ControleHospital
{
    internal class Conexao
    {
        private readonly string connectionString;
        public bool isConnected = false;


        public Conexao()
        {
            // Inicialize a string de conexão aqui.
            // connectionString = @"Data Source = ACER-ASPIRE; Integrated Security = True; Connect Timeout = 30; Encrypt=True; TrustServerCertificate= True; ApplicationIntent = ReadWrite; MultiSubnetFailover=False";
            //connectionString = @"Server=tcp:server-database-hospital.database.windows.net,1433;Initial Catalog=HOSPITAL;Persist Security Info=False;User ID=dba;Password=senhaForte123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";


            //var keyVault = new SecretClient(new Uri("https://key-hospital.vault.azure.net/"), new DefaultAzureCredential());
            //KeyVaultSecret secret = keyVault.GetSecret("DatabaseConnectionString");
            //connectionString = secret.Value;
            
            //connectionString = "Server=tcp:server-hospital.database.windows.net,1433;Initial Catalog=HOSPITAL;Persist Security Info=False;User ID=dba;Password=senhaForte123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";         

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
