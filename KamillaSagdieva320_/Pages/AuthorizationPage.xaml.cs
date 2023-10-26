using KamillaSagdieva320_.DB;
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

namespace KamillaSagdieva320_.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public static List<Owner> owners { get; set; }
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void EnterBTN_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTB.Text.Trim();
            string password = PasswordTB.Password.Trim();

            Owner owner = new Owner();
            owners = new List<Owner>(DBConnection.catDogEntities.Owner.ToList());
            Owner currentUser = owners.FirstOrDefault(i => i.Login == login && i.Password == password);
            if (currentUser != null)
            {
                if (currentUser.ID == 1)
                    NavigationService.Navigate(new KittyPage());
                else if (currentUser.ID == 2)
                    NavigationService.Navigate(new DogPage());
            }
            else
                MessageBox.Show("Неверный логин или пароль. Попробуйте снова.");
        }
    }
}
