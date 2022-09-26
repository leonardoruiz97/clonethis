using System.ComponentModel.DataAnnotations;

namespace RESTAPI_CORE.Entities
{
    public class enUser
    {
        public class parameters
        {
            [Required]
            public string code { get; set; }
        }

        public class response : entity
        {
            public bool access { get; set; }
            public string user { get; set; }
            public string password { get; set; }
            public string vendor { get; set; }
            public string intranet { get; set; }
            public string email { get; set; }
            public string acronym { get; set; }
            public enEntity.BranchOfficeEntity branchOffice { get; set; }
            public enEntity.AreaEntity area { get; set; }
        }

        public class Login
        {
            public class response : entity
            {
                public bool access { get; set; }
                public string user { get; set; }
                public string password { get; set; }
            }
            public class parameters
            {
                [Required]
                public string user { get; set; }
                [Required]
                public string password { get; set; }
            }
        }
    }
}

