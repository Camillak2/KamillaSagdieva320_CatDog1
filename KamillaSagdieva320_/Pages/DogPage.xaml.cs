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
        public static Animal animal { get; set; }
        public DogPage()
        {
            InitializeComponent();
            animals = new List<Animal>
                (DBConnection.catDogEntities.Animal.ToList());
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
 
        private void SearchTB_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            if (SearchTB.Text.Length > 0)
                AnimalsLV.ItemsSource = DBConnection.catDogEntities.Animal.Where(i => i.Action.Contains(SearchTB.Text.Trim())).ToList();
            else
                AnimalsLV.ItemsSource = new List<Animal>(DBConnection.catDogEntities.Animal.ToList());
        }
    }
        
        

    //private void AddBTN_Click(object sender, RoutedEventArgs e)
    //    {
    //        var a = ActionAddCB.SelectedItem as Actionn;
    //        animal.ID_Action = a.ID;

    //        DBConnection.catDogEntities.Animal.Add(animal);
    //        DBConnection.catDogEntities.SaveChanges();

    //        AnimalsLV.ItemsSource = new List<Animal>
    //            (DBConnection.catDogEntities.Animal.ToList());
    //    }
    //}
}
