using System;
using System.Collections.Generic;
using System.Text;

namespace TP3
{
    public class BWings : Vaisseau {
        public BWings() : base(){
            initHealth = 30;
            initShield = 0;
            Health = initHealth;
            Shield = initShield;
            Weapon bWingstWeapon = new Weapon("MC-Hammer", 1, 8, Type.Explosife, 2);
            this.AddWeapon(bWingstWeapon);
        }
        public override void Attaque(Vaisseau targetedSpaceShip){
            targetedSpaceShip.getShoot(this.GetWeapon().Shoting());
        }
    }
}
