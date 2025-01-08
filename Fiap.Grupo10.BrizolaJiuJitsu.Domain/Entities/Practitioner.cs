using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Fiap.Grupo10.BrizolaJiuJitsu.Domain.Entities
{
    [Table("Practitioner")]
    public class Practitioner
    {
        public Guid Id { get; set; }

        [Required]
        [DeniedValues("admin", "administrator", "root","",null,"string", ErrorMessage = "Nome de usuário não permitido!")]
        public required string FullName { get; set; }

        [AllowedValues("A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-", ErrorMessage = "Valor não permitido!")]
        public string? BloodType { get; set; }
    }
}
