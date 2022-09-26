using System.Data.SqlClient;

namespace RESTAPI_CORE.Datos
{
    public class Conexion
    {
        private readonly string cadenaSQL;
        public Conexion(IConfiguration config)
        {
            cadenaSQL = config.GetConnectionString("CadenaSQL");
        }


    }
}
