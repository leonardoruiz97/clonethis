namespace RESTAPI_CORE.Logica
{
    public class Conexion
    {
        private IConfiguration Configuration;
        public string stringConexion { get; set; }

        public Conexion()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: false);
            IConfiguration configuration = builder.Build();
            stringConexion = configuration.GetValue<string>("ConnectionStrings:DefaultConnection");

        }
    }
}
