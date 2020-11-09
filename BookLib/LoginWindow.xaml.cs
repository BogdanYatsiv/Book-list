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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            User logUser = null;

            using (BookLibContext db = new BookLibContext())
            {
                logUser = db.Users.Where(b => b.Login == loginTextBox.Text && b.Password == passwordTextBox.Text).FirstOrDefault();
            }

            if (logUser != null) MessageBox.Show("Login was successful");
            //перехід на головну сторінку
        }
      
    }
}
