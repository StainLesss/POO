using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TP3
{
    public class Player
    {
        public string Pseudo { get; set; }
        public string UserFullName { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }

        public int IdJoueur { get; }

        public ViperMKII spaceShip;

        public static int counterPlayer = 0;
        public static IDictionary<int, Player> AllPlayer = new Dictionary<int, Player>();


        public Player(string pseudo,string firstName,string lastName){
            counterPlayer++;
            IdJoueur = counterPlayer;
            Pseudo = pseudo;
            UserFirstName = firstName;
            UserLastName = lastName;
            UserFullName = FormatPlayerInformation(firstName) + " "+ FormatPlayerInformation(lastName);
            spaceShip = new ViperMKII();
            AllPlayer.Add(IdJoueur,this);
        }

        public Player()
        {
            counterPlayer++;
            IdJoueur = counterPlayer;
            Pseudo = "?";
            UserFirstName = "?";
            UserLastName = "?";
            UserFullName = "?";
            spaceShip = new ViperMKII();
            AllPlayer.Add(IdJoueur,this);
        }
        public string GetPseudo() {return Pseudo; }
        public string GetUserFullName() { return UserFullName; }
        public ViperMKII GetSpaceShip() { return spaceShip; }

        public override string ToString(){
            return this.GetPseudo(); //+ " (" + this.GetFullName() + ")";
        }

        public override bool Equals(object obj){
            if (obj.ToString() == this.ToString()) { return true; }
            else { return false; }
        }

        private static string FormatPlayerInformation(string anInformation){
            return anInformation.Substring(0, 1).ToUpper() + anInformation.Substring(1, anInformation.Length - 1).ToLower();
        }


    }
}
