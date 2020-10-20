using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookLib.Entities
{
    [Table("BooksTable")]
    public class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int BookId { get; set; }

        [Column(TypeName = "INT")]
        [Required]
        public int NumberOfPages { get; set; }

        [Column(TypeName = "INT")]
        [Required]
        public int YearOfPublication { get; set; }

        [Column(TypeName = "VARCHAR")]
        [Index(IsUnique = true)]
        [Required]
        public String BookName { get; set; }

        [Column(TypeName = "DATE")]
        public DateTime BookAddedAt { get; set; }
        public List<UserBooks> UserBooks { get; set; }

    }
}
