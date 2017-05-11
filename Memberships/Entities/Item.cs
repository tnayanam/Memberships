namespace Memberships.Entities
{
    [Table("Item")]
    public class Item
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // this auto incement the id
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Title { get; set; }
    }

}