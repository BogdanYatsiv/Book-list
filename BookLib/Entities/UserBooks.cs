using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookLib.Entities
{
    
    [Table("IntermediateUserBookTable")]
    public class UserBooks
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int UserId { get; set; }
        public int BookId { get; set; }

        [ForeignKey("UserId")]
        [Required]
        public User User { get; set; }

        [ForeignKey("BookId")]
        [Required]
        public Book Book { get; set; }

    }
}
