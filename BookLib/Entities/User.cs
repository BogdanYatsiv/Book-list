using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookLib.Entities
{

    [Table("UsersTable")]
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int UserId { get; set; }

        [MaxLength(30), MinLength(6)]
        [Column(TypeName = "VARCHAR")]
        [Required] //Обов'язкове поле NOT NULL
        [Index(IsUnique = true)] //Підвищує продуктивність пошуку та дає елементу бути унікальним
        public String Login { get; set; }

        [MaxLength(30), MinLength(8)]
        [Column(TypeName = "VARCHAR")]
        [Required]
        public String Password { get; set; }

        [Column(TypeName = "VARCHAR")]
        [Required]
        [Index(IsUnique = true)]
        public String Email { get; set; }

        [Column(TypeName = "VARCHAR")]
        [NotMapped] //Не обов'язковий для створення стовпця в бд
        public String NameOfUser { get; set; }

        [Column(TypeName = "DATE")]
        public DateTime AccountCreatedAt { get; set; }
        public List<UserBooks> UserBooks { get; set; }
        public List<Reminders> UserReminders { get; set; }
        public List<Reviews> UserReviews { get; set; }
    }
}
