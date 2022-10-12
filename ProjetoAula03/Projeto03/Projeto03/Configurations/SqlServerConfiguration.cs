namespace Projeto03.Configurations
{
    public static class SqlServerConfiguration
    {
        public static string GetConneciontString()
        {
            return @"Data Source = (localdb)\MSSQLLocalDB; 
                            Initial Catalog = BDProjeto03; 
                            Integrated Security = True;
                            Connect Timeout = 30;
                            Encrypt = False;
                            TrustServerCertificate = False;
                            ApplicationIntent = ReadWrite;
                            MultiSubnetFailover = False";
        }
    }
}
