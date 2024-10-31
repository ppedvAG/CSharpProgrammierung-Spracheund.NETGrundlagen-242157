using FahrzeugLib;
using Fahrzeugpark;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;

namespace FahrzeugWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Fahrzeug> Fahrzeuge { get;  } = new ObservableCollection<Fahrzeug>();

        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;
        }

        private void btnHinzufügen_Click(object sender, RoutedEventArgs e)
        {
            Fahrzeuge.Add(Generator.Fahrzeug());
        }

        private void btnEntfernen_Click(object sender, RoutedEventArgs e)
        {
            if (lstFahrzeuge.SelectedIndex > -1)
            {
                Fahrzeuge.RemoveAt(lstFahrzeuge.SelectedIndex);
            }
        }

        private void lstFahrzeuge_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (lstFahrzeuge.SelectedIndex > -1)
            {
                txtPreis.Text = $"{Fahrzeuge[lstFahrzeuge.SelectedIndex].Preis} €";
            }
            else
            {
                txtPreis.Text = string.Empty;
            }
        }
    }
}