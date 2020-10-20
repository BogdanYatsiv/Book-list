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
    public partial class MainWindow : Window
    {
        BookLibContext DataBase;
        public MainWindow()
        {
            InitializeComponent();
        }

        public string[] RegistrationContainerInfo;

        public User NewUser { get; set; }
        private void RegistrationButton(object sender, RoutedEventArgs e)
        {
            
            NewUser = new User
            {
                
            };
            
            MessageBox.Show("You have been successfully registered");
        }

        private void TextBox_LoginEntering(object sender, TextChangedEventArgs e)
        {

        }
    }
}
