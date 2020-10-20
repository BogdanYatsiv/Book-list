using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public enum ReminderStatus
{
    On = 1,
    Off = 0
}

namespace BookLib.Entities
{
    [Table("ReminderTable")]
    public class Reminders //Нагадування
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ReminderId { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }

        public ReminderStatus ReminderStatus { get; set; }

        [Required]
        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        [Required]
        [ForeignKey("BookId")]
        public virtual Book Book { get; set; }

        [Required]
        [Column(TypeName = "DATE")]
        public DateTime ReminderDate { get; set; }

        [Column("Description", TypeName = "TEXT")]
        public String DescriptionForReminder { get; set; }

    }
}
