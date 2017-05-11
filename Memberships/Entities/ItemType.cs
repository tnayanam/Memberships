using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Memberships.Entities
{
    [Table("ItemType")]
    public class ItemType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // this auto incement the id
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Title { get; set; }
    }
}