using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Memberships.Entities
{
    [Table("ProductLinkText")]
    public class ProductLinkText
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // this auto incement the id
        public int Id { get; set; }
        [Required]
        [MaxLength(25)]
        public string Title { get; set; }
    }
}
