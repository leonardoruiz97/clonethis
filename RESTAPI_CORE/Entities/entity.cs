using System.ComponentModel.DataAnnotations;

namespace RESTAPI_CORE.Entities
{
    public class entity
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string code { get; set; }
    }
}
