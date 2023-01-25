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

namespace OOD_LabWeek1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Band> allBands = new List<Band>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            PopBand b1 = new PopBand() { bandName = "Green Day",bandDateFormed =1986 , memberName = "Billie Joe Armstrong, Mike Dirnt, Tre Cool"};
            RockBand b2 = new RockBand() { bandName = "AC/DC", bandDateFormed = 1973, memberName = "Brian Johnson, Bon Scott, Dave Evans, Axl Rose"};
            IndieBand b3 = new IndieBand() { bandName = "The White Stripes", bandDateFormed = 1997, memberName = "Jack White, Meg White" };
            RockBand b4 = new RockBand() { bandName = "The Beatles", bandDateFormed = 1960, memberName = "John Lennon, Ringo Starr, Paul McCartney, George Harrison" };
            PopBand b5 = new PopBand() { bandName = "My Chemical Romance", bandDateFormed = 2001, memberName = "Gerard Way, Ray Toro, Mikey Way, Frank Iero" };
            ElectronicBand b6 = new ElectronicBand() { bandName = "Daft Punk", bandDateFormed = 1993, memberName = "Guy-Manuel de Homem-Christo, Thomas Bangalter" };

            allBands.Add(b1);
            allBands.Add(b2);
            allBands.Add(b3);
            allBands.Add(b4);
            allBands.Add(b5);
            allBands.Add(b6);

            allBands.Sort();

            LtBxBandNames.ItemsSource = allBands;
        }
    }
}
