using BookLib.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookLib
{

    public class BookLibContext : DbContext
    {

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<UserBooks> UserBooks { get; set; }
        public virtual DbSet<Reviews> Reviews { get; set; }
        public virtual DbSet<Reminders> Reminders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=BookLibDataBase.db");

    }
}
