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

