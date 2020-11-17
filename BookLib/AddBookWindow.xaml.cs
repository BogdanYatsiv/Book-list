using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BookLib.Entities;

namespace BookLib
{
    /// <summary>
    /// Interaction logic for AddBookWindow.xaml
    /// </summary>
    public partial class AddBookWindow : Window
    {
        public AddBookWindow()
        {
            InitializeComponent();
        }

        BookLibContext db;

        private void create_button_Click(object sender, RoutedEventArgs e)
        {
            if (name_book.Text == null) 
            {
                MessageBox.Show("Input title of book!");
            }
            else using (db)
            {
                var newBook = new Book();
                {
                    newBook.BookName = name_book.Text;
                    newBook.BookAddedAt = DateTime.Now;
                    newBook.BookId = Convert.ToInt32(id_book.Text);
                    newBook.NumberOfPages = Convert.ToInt32(num_pages.Text);
                    newBook.YearOfPublication = Convert.ToInt32(year_publ.Text);
                }

                db.Books.Add(newBook);
                db.SaveChanges();
            }
            MessageBox.Show("Your book was registered succesfully");
        }
    }
}
