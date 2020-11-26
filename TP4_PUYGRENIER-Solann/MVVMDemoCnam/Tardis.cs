using System;
using System.Collections.Generic;
using System.Text;

namespace TP3
{
    public class Tardis : Vaisseau, IAptitude
    {

        public Tardis() : base(){
            initHealth = 1;
            initShield = 0;
            Health = initHealth;
            Shield = initShield;
            //Weapon falseAndUselessWeapon = new Weapon("", 0, 0, Type.Direct, -1); //useles weapon, can prevent some errors
        }
        public void Utilise(List<Vaisseau> aSpaceShipList){
            Random randomPosition = new Random();
            int hazardousIndexA = randomPosition.Next(0, aSpaceShipList.Count);
            int hazardousIndexB = randomPosition.Next(0, aSpaceShipList.Count);

            Vaisseau tmp = aSpaceShipList[hazardousIndexA];
            aSpaceShipList[hazardousIndexA] = aSpaceShipList[hazardousIndexB];
            aSpaceShipList[hazardousIndexB] = aSpaceShipList[hazardousIndexA];

        }
        public override void Attaque(Vaisseau targetedSpaceShip){
        }
    }
}
