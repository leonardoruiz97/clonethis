using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RESTAPI_CORE.Entities;
using RESTAPI_CORE.Entities.enEntity;
using RESTAPI_CORE.Datos;
using System.Data;
using System.Data.SqlClient;

namespace RESTAPI_CORE.Logica

{
    public class SalesLogica:Conexion
    {
        public async Task<List<enSales.responseSummary>> ListadoVentas(enSales.parameters Item)
        {
            List<enSales.responseSummary> oSales = null;
            using (SqlConnection cn = new SqlConnection(this.stringConexion))
            {
                await cn.OpenAsync();
                DatosSales oDatos = new DatosSales();
                oSales = await oDatos.Lista(cn, Item);
            }
            return oSales;
        }
    }
}
