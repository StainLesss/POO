using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TP3;

namespace MVVMDemoCnam.ViewModel
{
    public class PlayerViewModel : INotifyPropertyChanged
    {
    public Player player;
    public Weapon weapon;


    public string FirstName
    {
        get { return player.UserFirstName; }//player.UserFirstName
            set
        {
            if (player.UserFirstName != value)
            {
                    player.UserFirstName = value;
                OnPropertyChange("FirstName");
                // If the first name has changed, the FullName property needs to be udpated as well.
                OnPropertyChange("FullName");
            }
        }
    }

    public string LastName
    {
        get { return player.UserLastName; }
        set
        {
            if (player.UserLastName != value)
            {
                player.UserLastName = value;
                OnPropertyChange("LastName");
                // If the first name has changed, the FullName property needs to be udpated as well.
                OnPropertyChange("FullName");
            }
        }
    }

    // This property is an example of how model properties can be presented differently to the View.
    // In this case, we transform the birth date to the player's age, which is read only.
    public int Id
    {
        get
        {
            int id = player.IdJoueur + 10;
            return id;
        }
    }

    // This property is just for display purposes and is a composition of existing data.
    public string FullName
        {
        get { return FirstName + " " + LastName; }
    }

    public string Pseudo{
            get { return player.Pseudo; }
            set { }

    }

    public string TypeWeapon
        {
            get { return weapon.WeaponType.ToString(); }
        }
    public string NameWeapon
        {
            get { return weapon.Name; }
        }
    public string DommageMin
        {
            get { return weapon.minimumDamage.ToString(); }
        }
    public string DommageMax
        {
            get { return weapon.maximumDamage.ToString(); }
        }



    public PlayerViewModel()
    {
        player = new Player("noob69", "Brice", "DeNice");
       
    }
    public PlayerViewModel(string firstName,string lastName,string pseudo)
     {
            player = new Player(pseudo, firstName, lastName);
            FirstName = firstName;
            LastName = lastName;


     }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChange(string propertyName)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    }
}

