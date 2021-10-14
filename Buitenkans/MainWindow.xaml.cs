using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Threading;

namespace Buitenkans
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer _timer;

        public ObservableCollection<Pokemon> GevangenPokemonLijst { get; set; }

        private Pokemon PokemonOpScherm;

        public MainWindow()
        {
            GevangenPokemonLijst = new ObservableCollection<Pokemon>();
            InitializeComponent();
        }

        private void Callback(object? sender, EventArgs e)
        {
            var random = new Random();
            var pokemonLijst = PokemonDatabase.PokemonLijst();
            var randomPokemon = pokemonLijst[random.Next(0, pokemonLijst.Count)];
            PokemonOpScherm = randomPokemon;
            PokemonNaam.Text = randomPokemon.Naam;
            HP.Text = randomPokemon.HP;
            var color = Colors.Red;
            switch (randomPokemon.Type)
            {
                case "Grass":
                    color = Colors.Green;
                    break;
                case "Fire":
                    color = Colors.Red;
                    break;
                case "Water":
                    color = Colors.Blue;
                    break;
                case "Bug":
                    color = Colors.DarkOliveGreen;
                    break;
                case "Psychic":
                    color = Colors.Purple;
                    break;
                case "Dragon":
                    color = Colors.DarkSlateBlue;
                    break;
                case "Electric":
                    color = Colors.Yellow;
                    break;
                default:
                    break;
            }
            Background = new SolidColorBrush(color);
            var url = $"Images/{randomPokemon.Nummer}.png";
            var bmim = new BitmapImage(new Uri(url, UriKind.Relative));
            PokemonImage.Source = bmim;
            Canvas.SetTop(PokemonButton, random.Next((int)GameCanvas.ActualHeight - (int)PokemonButton.ActualHeight));
            Canvas.SetLeft(PokemonButton, random.Next((int)GameCanvas.ActualWidth - (int)PokemonButton.ActualWidth));
        }

        private void PokemonButton_OnClick(object sender, RoutedEventArgs e)
        {
            GevangenPokemonLijst.Add(PokemonOpScherm);
            MessageBox.Show("Gevangen!");
        }

        private void StartKnop_Click(object sender, RoutedEventArgs e)
        {
            Callback(null, null);
            _timer = new DispatcherTimer(new TimeSpan(0, 0, 3), DispatcherPriority.Render, Callback, Dispatcher.CurrentDispatcher);
            PokemonButton.Visibility = Visibility.Visible;
            StartKnop.Visibility = Visibility.Collapsed;
            MenuKnop.Visibility = Visibility.Visible;
            GevangenPokemonListBox.Visibility = Visibility.Visible;
        }

        private void MenuKnop_Click(object sender, RoutedEventArgs e)
        {
            _timer.Stop();
            GevangenPokemonLijst.Clear();
            PokemonButton.Visibility = Visibility.Hidden;
            StartKnop.Visibility = Visibility.Visible;
            MenuKnop.Visibility = Visibility.Collapsed;
            GevangenPokemonListBox.Visibility = Visibility.Hidden;
        }
    }
}
