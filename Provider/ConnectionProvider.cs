namespace ControleHospital.Provider
{
    public class ConnectionProvider
    {
        private static readonly string _hospitalConnectionString = "Server=tcp:server-hospital.database.windows.net,1433;Initial Catalog=HOSPITAL;Persist Security Info=False;User ID=dba;Password=senhaForte123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public static string HospitalConnectionString
        {
            get { return _hospitalConnectionString; }
        }
    }
}
