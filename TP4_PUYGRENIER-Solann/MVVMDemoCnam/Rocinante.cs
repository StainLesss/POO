using System;
using System.Collections.Generic;
using System.Text;

namespace TP3
{
    class Rocinante : Vaisseau {

        public Rocinante() : base(){
            initHealth = 3;
            initShield = 5;
            Health = initHealth;
            Shield = initShield;
            Weapon rocinanteWeapon = new Weapon("ElTorpillas", 3, 3, Type.AutoGuide, 2);
            this.AddWeapon(rocinanteWeapon);
        }

        public override void Attaque(Vaisseau targetedSpaceShip){
            targetedSpaceShip.getShoot(this.GetWeapon().Shoting());
        }

    }
}
