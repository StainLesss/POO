using MVVMDemoCnam.ViewModel;
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
using System.Windows.Shapes;
using TP3;
/*https://riptutorial.com/wpf/example/992/basic-mvvm-example-using-wpf-and-csharp*/
/*https://nathanaelmarchand.developpez.com/tutoriels/dotnet/comprendre-binding-wpf-et-silverlight/?page=les-parametres-de-binding-et-les-conversions#LV-B-1*/

namespace MVVMDemoCnam.View
{
    /// <summary>
    /// Logique d'interaction pour PlayerView.xaml
    /// </summary>
    public partial class PlayerView : Window
    {

        private PlayerViewModel _playerViewModel;  // Vue modéle update  _playerViewModel.Add  + updated
        public PlayerView()
        {
            InitializeComponent();
            // The DataContext serves as the starting point of Binding Paths
            DataContext = _playerViewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string firstName = boxFirstName.Text;
            string lastName = boxLastName.Text;
            string userPseudo = boxPseudo.Text;
            _playerViewModel = new PlayerViewModel(firstName, lastName, userPseudo);
            Close();
        }
    }
}
