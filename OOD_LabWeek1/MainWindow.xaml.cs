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
            Band b1 = new Band() { bandName = "Green Day",bandDateFormed =1986 , memberName = "Billie Joe Armstrong, Mike Dirnt, Tre Cool"};
            Band b2 = new Band() { bandName = "AC/DC", bandDateFormed = 1973, memberName = "Brian Johnson, Bon Scott, Dave Evans, Axl Rose"};
            Band b3 = new Band() { bandName = "The White Stripes", bandDateFormed = 1997, memberName = "Jack White, Meg White" };
            Band b4 = new Band() { bandName = "The Beatles", bandDateFormed = 1960, memberName = "John Lennon, Ringo Starr, Paul McCartney, George Harrison" };
            Band b5 = new Band() { bandName = "My Chemical Romance", bandDateFormed = 2001, memberName = "Gerard Way, Ray Toro, Mikey Way, Frank Iero" };
            Band b6 = new Band() { bandName = "Daft Punk", bandDateFormed = 1993, memberName = "Guy-Manuel de Homem-Christo, Thomas Bangalter" };

            allBands.Add(b1);
            allBands.Add(b2);
            allBands.Add(b3);
            allBands.Add(b4);
            allBands.Add(b5);
            allBands.Add(b6);

            LtBxBandNames.ItemsSource = allBands;
        }
    }
}
