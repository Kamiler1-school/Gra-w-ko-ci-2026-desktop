using Gra_w_kości_2026_desktop;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Gra_w_kości_2026_desktop
{
    public partial class MainWindow : Window
    {
        private Kosc[] kosci;

        public MainWindow()
        {
            InitializeComponent();

            kosci = new Kosc[]
            {
                new Kosc(0),
                new Kosc(0),
                new Kosc(0),
                new Kosc(0),
                new Kosc(0)
            };
        }

        private void RzutButton_Click(object sender, RoutedEventArgs e)
        {
            Kosc1Rzut(0, Kosc1Obraz);
            Kosc1Rzut(1, Kosc2Obraz);
            Kosc1Rzut(2, Kosc3Obraz);
            Kosc1Rzut(3, Kosc4Obraz);
            Kosc1Rzut(4, Kosc5Obraz);

            int suma = 0;

            for (int i = 0; i < kosci.Length; i++)
            {
                suma += kosci[i].LiczbaOczek;
            }

            WynikText.Text = suma.ToString();
        }

        private void Kosc1Rzut(int numer, Image obraz)
        {
            kosci[numer].RzutKoscia();

            obraz.Source = new BitmapImage(
                new Uri("/Image/"+kosci[numer].PlikiObrazow[kosci[numer].IdentyfikatorPliku],
                UriKind.Relative));
        }

        private void ZmienDostepnosc(int numer, Image obraz)
        {
            if (kosci[numer].CzyDostepna)
            {
                kosci[numer].BlokujKosc();
                obraz.Opacity = 0.5;
            }
            else
            {
                kosci[numer].OdblokujKosc();
                obraz.Opacity = 1.0;
            }
        }

        private void Kosc1_Click(object sender, MouseButtonEventArgs e)
        {
            ZmienDostepnosc(0, Kosc1Obraz);
        }

        private void Kosc2_Click(object sender, MouseButtonEventArgs e)
        {
            ZmienDostepnosc(1, Kosc2Obraz);
        }

        private void Kosc3_Click(object sender, MouseButtonEventArgs e)
        {
            ZmienDostepnosc(2, Kosc3Obraz);
        }

        private void Kosc4_Click(object sender, MouseButtonEventArgs e)
        {
            ZmienDostepnosc(3, Kosc4Obraz);
        }

        private void Kosc5_Click(object sender, MouseButtonEventArgs e)
        {
            ZmienDostepnosc(4, Kosc5Obraz);
        }
    }
}