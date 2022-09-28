using RESTAPI_CORE.Entities.enEntity;
using System.Net;

namespace RESTAPI_CORE.Entities
{
    public class enSales
    {
        public class master
        {
            public int id { get; set; }
            public string quotation { get; set; }
            public string file { get; set; }
            public string correlative { get; set; }
            public string creationDate { get; set; }
            public string title { get; set; }
            public DateEntity.range travelDate { get; set; }
            public int days { get; set; }
            public decimal total { get; set; }
            public string status { get; set; }
            public string processStatus { get; set; }
        }

        public class responseSummary : master
        {
            public entity client { get; set; }
            public entity user { get; set; }
            public entity counter { get; set; }
        }

        public class salesDetail
        {
            public string Estado { get; set; }
            public string Fecha { get; set; }
            public string FecInicio { get; set; }
            public string FechaOut { get; set; }
            public string Creador { get; set; }
            public string Responsable { get; set; }
            public string tipoFile { get; set; }
            public string Cliente { get; set; }
            public string totVta { get; set; }
            public string Counter { get; set; }
            public string paxGrupo { get; set; }
            public string programa { get; set; }
            public string idioma { get; set; }
            public string nroAdulto { get; set; }
            public string nroAdultoE { get; set; }
            public string nroNino { get; set; }
            public string nroNinoE { get; set; }
            public string nroPax { get; set; }
            public string nroLiberados { get; set; }
            public string fecha_cierre { get; set; }

        }

        public class salesDetailServices
        {
            public string Ubigeo { get; set; }

            public string Proveedor { get; set; }

            public string detalle { get; set; }

            public string Dia { get; set; }
            public string DiaFin { get; set; }
            public string Estado { get; set; }

            public string NroPax { get; set; }
            
            public string noches { get; set; }

            public string Total { get; set; }

            public string Orden { get; set; }

            public string IDCAB { get; set; }

            public string IDDET { get; set; }

            public string CodReserva { get; set; }

            public string Notas { get; set; }
        }
        public class response : master
        {
            public enClient client { get; set; }
            public enUser user { get; set; }
            public CounterEntity counter { get; set; }
        }
        public class parameters
        {
            public int id { get; set; }
            public string quotation { get; set; }
            public string file { get; set; }
            public string correlative { get; set; }
            public int code { get; set; }
            public entity client { get; set; }
            public entity user { get; set; }
            public CounterEntity counter { get; set; }
            public DateEntity.range creationDate { get; set; }
            public DateEntity.range startDate { get; set; }
            public DateEntity.range outDate { get; set; }
            public DateEntity.range dateTimeLimit { get; set; }
            public string status { get; set; }
            public string processStatus { get; set; }
            public int New { get; set; }
            public string program { get; set; }
        }
    }
}

