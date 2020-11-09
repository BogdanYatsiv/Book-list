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
using System.Windows.Navigation;
using System.Windows.Shapes;
using BookLib.Entities;

namespace BookLib
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        BookLibContext db;
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        public string[] RegistrationContainerInfo;

        private void RegistrationButton(object sender, RoutedEventArgs e)
        {

            if (passwordTextBox.Text == confirmPassTextBox.Text)
            {
                using (db)
                {
                    var newUser = new User();
                    {
                        newUser.Login = loginTextBox.Text;
                        newUser.Password = passwordTextBox.Text;
                        newUser.Email = emailTextBox.Text;
                        newUser.NameOfUser = nameTextBox.Text;
                    }

                    db.Users.Add(newUser);
                    db.SaveChanges();
                }
                MessageBox.Show("You have been successfully registered");
                //перехід на головну сторінку
            }
            else MessageBox.Show("Password confirmation does not match the password itself!");
        }
    }
    
}
