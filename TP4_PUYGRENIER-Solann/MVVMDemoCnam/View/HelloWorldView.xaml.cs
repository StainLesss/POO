using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Microsoft.Win32;
using MVVMDemoCnam.ViewModel;
using TP3;

namespace MVVMDemoCnam.View
{
    /// <summary>
    /// Logique d'interaction pour HelloWorldView.xaml
    /// </summary>
    public partial class HelloWorldView : Window
    {
        
        public HelloWorldView()
        {
            InitializeComponent();

            List<Player> items = new List<Player>();
            items.Add(new Player("noob69", "Brice", "DeNice"));
            items.Add(new Player("kiki","Roger","Rabbit"));
            items.Add(new Player("Killeur94","Bernard","Du pont"));
            
            ListViewJoueurTitle.ItemsSource = items;

            //this.ListViewJoueurTitle.Items.Add(new { Binding JoueurName } { Id = 1, Name = "David" });
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           // HelloWorldViewModel.CreatePlayer();

            PlayerView anotherWindows = new PlayerView();
            anotherWindows.Top = 100;
            anotherWindows.Left = 400;
            this.Visibility = Visibility.Collapsed;
            anotherWindows.ShowDialog();
            this.Visibility = Visibility.Visible;
            ListViewJoueurTitle.ClearValue(ItemsControl.ItemsSourceProperty);
            ListViewJoueurTitle.ItemsSource = Player.AllPlayer.Values.ToList();

        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (ListViewJoueurTitle.SelectedItems.Count == 0) 
                return;

            var selectedPlayer = ListViewJoueurTitle.SelectedItems[0] as Player;
            int key = selectedPlayer.IdJoueur;

            Player.AllPlayer.Remove(key);

            ListViewJoueurTitle.ClearValue(ItemsControl.ItemsSourceProperty);
            ListViewJoueurTitle.ItemsSource = Player.AllPlayer.Values.ToList();
        }

        private void MenList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListViewJoueurTitle.SelectedIndex != -1)
            {
                buttonVessel.Visibility = Visibility.Visible;
                buttonDollars.Visibility = Visibility.Visible;
                var selectedPlayer = ListViewJoueurTitle.SelectedItems[0] as Player;
                Player thePlayer = Player.AllPlayer[selectedPlayer.IdJoueur];
                pictureVessel.Source = new BitmapImage(new Uri(thePlayer.spaceShip.SpaceShipSource, UriKind.Relative));
                if (pictureVessel.Source == null) pictureVessel.Source = new BitmapImage(new Uri("../Graphics/defaultSpaceShip.png", UriKind.Relative));
                
                UpdateWeaponList(thePlayer);
            }
            else
            {
                Clean();
                buttonVessel.Visibility = Visibility.Collapsed;
                buttonDollars.Visibility = Visibility.Collapsed;
                //pictureVessel.Source. = "";
            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var selectedPlayer = ListViewJoueurTitle.SelectedItems[0] as Player;
            int key = selectedPlayer.IdJoueur;

            PlayerView anotherWindows = new PlayerView();
            anotherWindows.Top = 100;
            anotherWindows.Left = 400;
            this.Visibility = Visibility.Collapsed;

            anotherWindows.boxPseudo.Text = Player.AllPlayer[key].Pseudo; 
            anotherWindows.boxFirstName.Text = Player.AllPlayer[key].UserFirstName;
            anotherWindows.boxLastName.Text = Player.AllPlayer[key].UserLastName;
            Player.AllPlayer.Remove(key);

            anotherWindows.ShowDialog();

            this.Visibility = Visibility.Visible;

            ListViewJoueurTitle.ClearValue(ItemsControl.ItemsSourceProperty);
            ListViewJoueurTitle.ItemsSource = Player.AllPlayer.Values.ToList();
        }


        private void UpdateWeaponList(Player myPlayer)
        {
            NameSpaceship.Content = myPlayer.spaceShip.GetType().Name;
            HealthSpaceShip.Content = myPlayer.spaceShip.Health;
            ShieldSpaceShip.Content = myPlayer.spaceShip.Shield;

            ListViewWeapon.ItemsSource = myPlayer.spaceShip.weaponInventory;
            //gridWeapon.ItemsSource = myPlayer.spaceShip.weaponInventory.ToString();

        }

        private void Clean()
        {
            NameSpaceship.Content = "";
            HealthSpaceShip.Content = "";
            ShieldSpaceShip.Content = "";
            //pictureVessel.Source.= "";

        }

        private void buttonVessel_Click(object sender, RoutedEventArgs e)
        {
            

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                string sFileName = openFileDialog.FileName;
                var convertor = new ImageSourceConverter();
                
                pictureVessel.Source = (ImageSource)convertor.ConvertFromString(sFileName); ;

                var selectedPlayer = ListViewJoueurTitle.SelectedItems[0] as Player;
                Player.AllPlayer[selectedPlayer.IdJoueur].spaceShip.SpaceShipSource = sFileName;

            }
            
        }
    }
}
