using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookLib.Entities
{
    [Table("ReviewsTable")]
    public class Reviews //Відгуки
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ReviewId { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }

        [Required]
        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        [Required]
        [ForeignKey("BookId")]
        public virtual Book Book { get; set; }

        [Required]
        [Column(TypeName = "DATE")]
        public DateTime ReviewDate { get; set; }

        [Column("Review", TypeName = "TEXT")]
        public String ReviewText { get; set; }

    }
}
