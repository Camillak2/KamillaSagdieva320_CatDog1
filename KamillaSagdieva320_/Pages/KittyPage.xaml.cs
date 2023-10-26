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
    /// Логика взаимодействия для KittyPage.xaml
    /// </summary>
    //public partial class KittyPage : Page
    //{
    //    public static List<Animal> animals { get; set; }
    //    public static List<Actionn> actions { get; set; }
    //    public static Animal animal { get; set; }
    //    public KittyPage()
    //    {
    //        InitializeComponent();
    //        animals = new List<Animal>
    //            (DBConnection.catDogEntities.Animal.ToList());
    //        actions = new List<Actionn>
    //            (DBConnection.catDogEntities.Actionn.ToList());

    //        this.DataContext = this;
    //    }
    //    private void AddPhotoBTN_Click(object sender, RoutedEventArgs e)
    //    {
    //        OpenFileDialog openFileDialog = new OpenFileDialog()
    //        {
    //            Filter = "*.png|*.png|*.jpeg|*.jpeg|*.jpg|*.jpg"
    //        };
    //        if (openFileDialog.ShowDialog().GetValueOrDefault())
    //        {
    //            animal.Photo = File.ReadAllBytes(openFileDialog.FileName);
    //            TestImage.Source = new BitmapImage(new Uri(openFileDialog.FileName));
    //            //DBConnection.strayKidsEntities.SaveChanges();
    //        }
    //    }
    //    private void PositionFilterCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
    //    {
    //        Refresh();
    //    }

    //    private void Refresh()
    //    {
    //        var filtred = DBConnection.catDogEntities.Actionn.ToList();

    //        var action = ActionFilterCB.SelectedItem as Action;
    //        var surchText = SearchTB.Text.ToLower();

    //        filtred = filtred.Where(x => x.Name == actions.ID).ToList();

    //        if (!string.IsNullOrWhiteSpace(surchText))
    //            filtred = filtred.Where(x => x.Name.ToLower().Contains(surchText)).ToList();
    //        AnimalsLV.ItemsSource = filtred.ToList();

    //    }
    //    private void SearchTB_TextChanged_1(object sender, TextChangedEventArgs e)
    //    {
    //        Refresh();
    //    }

    //    private void AddBTN_Click(object sender, RoutedEventArgs e)
    //    {
    //        var a = ActionAddCB.SelectedItem as Actionn;
    //        animal.ID_Action = a.ID;

    //        DBConnection.catDogEntities.Animal.Add(animal);
    //        DBConnection.catDogEntities.SaveChanges();

    //        AnimalsLV.ItemsSource = new List<Animal>
    //            (DBConnection.catDogEntities.Animal.ToList());
    //    }
    }

