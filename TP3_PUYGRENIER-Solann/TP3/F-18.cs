using System;
using System.Collections.Generic;
using System.Text;
using TP2_Puygrenier_Solann;

namespace TP3
{
    public class F_18 : Vaisseau,IAptitude{

        public F_18() : base(){
            initHealth = 15;
            initShield = 0;
            Health = initHealth;
            Shield = initShield;
            //Weapon falseAndUselessWeapon = new Weapon("", 0, 0, Type.Direct, -1); //useles weapon, can prevent some errors
        }
        public void Utilise(List<Vaisseau> aSpaceshipList){
            if (aSpaceshipList[0] == this) this.Attaque(ThePlayerOne.spaceShip);
            Health = 0;
            this.Alive = false;
        }
        public override void Attaque(Vaisseau targetedSpaceShip){
            targetedSpaceShip.getShoot(10);
        }

        public override string ToString()
        {
            string str = "";
            str = "[Health :" + Health + "/" + initHealth + "\t]\n" +
                "[Shield :" + Shield + "/" + initShield + "\t]\n" +
                "[Curent weapon no:" + equipedWeapon + "/" + LIMIT_INVENTORY + "\t]\n";
            foreach (Weapon weap in weaponInventory)
            {
                str = str + weap.ToString();
            }
            return str;
        }

    }
}
