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

namespace Przesyłki
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();

            BitmapImage aktualneZdjecie = new BitmapImage();
            aktualneZdjecie.BeginInit();
            aktualneZdjecie.UriSource = new Uri(@"C:\Users\filip\Desktop\ćwiczenia samodzielne\wpf\Przesyłki\Przesyłki\resource\Pocztówka.png");
            zdjecie.Source = aktualneZdjecie;
            aktualneZdjecie.EndInit();
        }

        private void Sprawdz_cene(object sender, RoutedEventArgs e)
        {

             
            BitmapImage aktualneZdjecie = new BitmapImage();
            aktualneZdjecie.BeginInit();
           

            if(pocztowka.IsChecked == true)
            {
                aktualneZdjecie.UriSource = new Uri(@"C:\Users\filip\Desktop\ćwiczenia samodzielne\wpf\Przesyłki\Przesyłki\resource\Pocztówka.png");
                cena.Content = "Cena: 1zł";
                zdjecie.Source = aktualneZdjecie;
            }
            else if(list.IsChecked == true)
            {
                aktualneZdjecie.UriSource = new Uri(@"C:\Users\filip\Desktop\ćwiczenia samodzielne\wpf\Przesyłki\Przesyłki\resource\List.png");
                zdjecie.Source = aktualneZdjecie;
                cena.Content = "Cena: 1,5zł";
            }
            else
            {
                aktualneZdjecie.UriSource = new Uri(@"C:\Users\filip\Desktop\ćwiczenia samodzielne\wpf\Przesyłki\Przesyłki\resource\Paczka.png");
                zdjecie.Source = aktualneZdjecie;
                cena.Content = "Cena: 10zł";
            }



            aktualneZdjecie.EndInit();
        }

        private void Zatwierdz(object sender, RoutedEventArgs e)
        {
            String kod = kodPocztowy.Text;
            kod = kod.Replace("-", "");
            if(kod.Length == 5)
            {

                MessageBox.Show("git");

            }
            else
            {
                MessageBox.Show("niegit");

            }


        }
    }
}
