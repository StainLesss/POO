using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2_Puygrenier_Solann;

namespace TP3
{
    public class Player
    {
        public string pseudo;
        public string userFullName;
        public ViperMKII spaceShip;

        public Player(string pseudo,string firstName,string lastName){
            this.pseudo = pseudo;
            this.userFullName = FormatPlayerInformation(firstName) + " "+ FormatPlayerInformation(lastName);
            ViperMKII spaceShip = new ViperMKII();
        }
        public string GetPseudo() {return pseudo;}
        public string GetUserFullName() { return userFullName; }
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
