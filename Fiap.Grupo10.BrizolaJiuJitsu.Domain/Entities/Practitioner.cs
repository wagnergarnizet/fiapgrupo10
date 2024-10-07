using System.ComponentModel.DataAnnotations.Schema;

namespace Fiap.Grupo10.BrizolaJiuJitsu.Domain.Entities
{
    [Table("Practitioner")]
    public class Practitioner
    {
        public Guid Id { get; set; }

        public string FullName { get; set; }

        public string BloodType { get; set; }
    }
}
