using MVVMDemoCnam.Model;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using TP3;

namespace MVVMDemoCnam.ViewModel
{
    // Implements INotifyPropertyChanged interface to support bindings
    public class HelloWorldViewModel : INotifyPropertyChanged
    {
        private string titleString;
        private string titleElementPlayer;
        

        public event PropertyChangedEventHandler PropertyChanged;

        public string VesselPicturePath
        {
            get
            {
                return "../Graphics/VIPERMKII.png";

            }
            set
            {

            }
        }

        public string TitleString
        {
            get
            {
                return titleString;
            }
            set
            {
                titleString = value;
                OnPropertyChanged();
            }
        }

        public string NameSpaceship
        {
            get
            {
                return ".";
            }
            set
            {
                NameSpaceship = value;
                OnPropertyChanged();
            }
        }


        public string JoueurName
        {
            get { return titleElementPlayer; } 
            set
            {
                titleElementPlayer = value;
                OnPropertyChanged();
            }
        }


        public static void CreatePlayer(){
            Player instanceOf = new Player();
        }

        /// <summary>
        /// Raises OnPropertychangedEvent when property changes
        /// </summary>
        /// <param name="name">String representing the property name</param>
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

      



        public HelloWorldViewModel()
        {
            HelloWorldModel helloWorldModel = new HelloWorldModel();
            titleString = helloWorldModel.ImportantInfo;
            JoueurName = "Joueur";
        }
    }
}
