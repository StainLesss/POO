using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Puygrenier_Solann
{
    public class Player
    {
        private string pseudo;
        private string userFullName;
        private Vaisseau userSpaceShip;

        public Vaisseau UserSpaceShip{
            get;set;
        }
        public Player(string pseudo,string firstName,string lastName){
            this.pseudo = pseudo;
            this.userFullName = FormatPlayerInformation(firstName) + " "+ FormatPlayerInformation(lastName);
            UserSpaceShip = new Vaisseau();
        }
        public string GetPseudo() {return pseudo;}

        public string UserFullName{
            get{ return userFullName;}
            set{ this.userFullName = value; }
        }

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
