using System.ComponentModel.DataAnnotations;

namespace HospitalAPI.Persistence.Models
{
    public class Feedback
    {
        public int id { get; set; }

        public string name { get; set; }

        [Required, EmailAddress(ErrorMessage = "O email deve ser um email válido")]
        public string email { get; set; }

        public string avaliacao { get; set; }

        public int estrelas { get; set; }

        public Boolean autorizacao { get; set; }
    }
}
