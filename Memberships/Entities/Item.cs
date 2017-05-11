using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

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

        [MaxLength(2048)]
        public string Description { get; set; }

        [MaxLength(1024)]
        public string Url { get; set; }

        [MaxLength(1024)]
        public string ImageUrl { get; set; }

        [AllowHtml]
        public string HTML { get; set; }

        [DefaultValue(0)]
        public int WaitDays { get; set; }

        public string HTMLShort
        {
            get
            {
                return HTML == null ||
                    HTML.Length < 50 ? HTML : HTML.Substring(0, 50);
            }
        }



    }

}