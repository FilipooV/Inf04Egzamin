using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Inf04Egzamin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string GetImie= Imie.Text;
            string GetNazwisko = Nazwisko.Text;
            string GetOczy;



            if (Numer.Text.Length <= 0 || Imie.Text.Length <= 0 || Nazwisko.Text.Length <= 0)
            {
                MessageBox.Show("Wprowadź dane");
            }
            else
            {
                if (Niebieskie.IsChecked == true)
                {
                    GetOczy = "niebieskie";
                }
                else if(Zielone.IsChecked == true)
                {
                    GetOczy = "zielone";
                }
                else
                {
                    GetOczy = "piwne";
                }
                MessageBox.Show(GetImie + " " + GetNazwisko + " kolor oczu " + GetOczy);
            }
       
        }

        private void Numer_LostFocus(object sender, RoutedEventArgs e)
        {
            string numer = Numer.Text;
            string twarzFace = $"{numer}-zdjecie.jpg";
            string twarzOdcisk = $"{numer}-odcisk.jpg";

            zdjecie_twarz.Source = new BitmapImage(new Uri(twarzFace, UriKind.Relative));

            zdjecie_palec.Source = new BitmapImage(new Uri(twarzOdcisk, UriKind.Relative));


        }
    }
}