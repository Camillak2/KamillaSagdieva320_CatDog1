using KamillaSagdieva320_.DB;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для DogPage.xaml
    /// </summary>
    public partial class DogPage : Page
    {
        public static List<Animal> animals { get; set; }
        public static List<Owner> owners { get; set; }
        public static List<Action> actions { get; set; }
        public static Animal animal { get; set; }
        public DogPage()
        {
            InitializeComponent();
            animals = new List<Animal>
                (DBConnection.catDogEntities.Animal.ToList());
            owners = new List<Owner>
                (DBConnection.catDogEntities.Owner.ToList());
            this.DataContext = this;
        }
        private void AddPhotoBTN_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "*.png|*.png|*.jpeg|*.jpeg|*.jpg|*.jpg"
            };
            if (openFileDialog.ShowDialog().GetValueOrDefault())
            {
                animal.Photo = File.ReadAllBytes(openFileDialog.FileName);
                TestImage.Source = new BitmapImage(new Uri(openFileDialog.FileName));
                //DBConnection.strayKidsEntities.SaveChanges();
            }
        }
        private void PositionFilterCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            var filtred = DBConnection.catDogEntities.Animal.ToList();

            var action = ActionFilterCB.SelectedItem as Action;
            var surchText = SearchTB.Text.ToLower();

            filtred = filtred.Where(x => x.ID_Action == action.ID).ToList();

            if (!string.IsNullOrWhiteSpace(surchText))
                filtred = filtred.Where(x => x.Surname.ToLower().Contains(surchText)).ToList();
            AnimalsLV.ItemsSource = filtred.ToList();

        }
        private void SearchTB_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            Refresh();
        }

        private void AddBTN_Click(object sender, RoutedEventArgs e)
        {
            var a = ActionAddCB.SelectedItem as Action;
            animal.ID_Action = a.ID;

            DBConnection.catDogEntities.Animal.Add(animals);
            DBConnection.catDogEntities.SaveChanges();

            AnimalsLV.ItemsSource = new List<Animal>
                (DBConnection.catDogEntities.Animal.ToList());
        }
    }
}
