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

namespace WpfÜlesanne
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Inimesed> items = new List<Inimesed>();
            items.Add(new Inimesed() { EesNimi = "Markus", PereNimi = "Klein", Vanus = 25 });
            items.Add(new Inimesed() { EesNimi = "Bread", PereNimi = "Kivi", Vanus = 40 });
            items.Add(new Inimesed() { EesNimi = "Vaas", PereNimi = "Montenegro", Vanus = 30 });
            items.Add(new Inimesed() { EesNimi = "Maasikas", PereNimi = "Kõva", Vanus = 18 });
            items.Add(new Inimesed() { EesNimi = "Harilik", PereNimi = "Skane", Vanus = 42 });
            items.Add(new Inimesed() { EesNimi = "Sindi", PereNimi = "Peen", Vanus = 76 });
            items.Add(new Inimesed() { EesNimi = "Furious", PereNimi = "Pit", Vanus = 99 });
            items.Add(new Inimesed() { EesNimi = "Kellog", PereNimi = "???", Vanus = 6 });
            items.Add(new Inimesed() { EesNimi = "Nik", PereNimi = "Valentain", Vanus = 14 });
            items.Add(new Inimesed() { EesNimi = "Mariia", PereNimi = "Klonk", Vanus = 66 });

            InimesedListBox.ItemsSource = items;
        }

        public class Inimesed
        {
            public string EesNimi { get; set; }
            public string PereNimi { get; set; }
            public int Vanus { get; set; }
        }
    }
}
