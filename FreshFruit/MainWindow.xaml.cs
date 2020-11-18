using FreshFruit.Controller;
using FreshFruit.Model;
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

namespace FreshFruit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, BucketEventListener
    {
        Seller toni;
        public MainWindow()
        {
            InitializeComponent();
            Bucket keranjangBuah = new Bucket(2);
            BucketController bucketController = new BucketController(keranjangBuah, this);

            toni = new Seller("Toni", bucketController);

            ListBoxBucked.ItemsSource = keranjangBuah.findAll();
        }

        public void onsucceed(string message)
        {
            ListBoxBucked.Items.Refresh();
        }

        public void onvailed(string message)
        {
            MessageBox.Show(message);
        }

        private void OnButtonAddAnggur(object sender, RoutedEventArgs e)
        {
            Fruit anggur = new Fruit("anggur");
            toni.addFruit(anggur);

            ListBoxBucked.Items.Refresh();
        }

        private void OnButtonAddAppleClicked(object sender, RoutedEventArgs e)
        {
            Fruit apple = new Fruit("apple");
            toni.addFruit(apple);

            ListBoxBucked.Items.Refresh();
        }

        private void OnButtonAddBananaClicked(object sender, RoutedEventArgs e)
        {
            Fruit banana = new Fruit("banana");
            toni.addFruit(banana);

            ListBoxBucked.Items.Refresh();
        }

        private void OnButtonAddOrangeClicked(object sender, RoutedEventArgs e)
        {
            Fruit orange = new Fruit("orange");
            toni.addFruit(orange);

            ListBoxBucked.Items.Refresh();
        }
    }
}
