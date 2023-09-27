using System.ComponentModel.DataAnnotations;

namespace HospitalAPI.Persistence.Models
{
    public class UserCaracteristcs
    {
        [Key]
        public string crm { get; set; }

        public string especialidade { get; set;}
    }
}
