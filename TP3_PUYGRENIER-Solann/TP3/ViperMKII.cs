using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using TP2_Puygrenier_Solann;

namespace TP3
{
    public class ViperMKII : Vaisseau
    {
        public ViperMKII() : base(){
            initHealth = 10;
            initShield = 15;
            Health = initHealth;
            Shield = initShield;
            Weapon directPlayerWeapon = new Weapon("Mitrail", 2, 3, Type.Direct, 1);
            Weapon explosifePlayerWeapon = new Weapon("EMG ", 1, 7, Type.Explosife, 2);
            Weapon autoGuidePlayerWeapon = new Weapon("Missile", 4, 10, Type.AutoGuide, 4);
            this.AddWeapon(directPlayerWeapon);
            this.AddWeapon(explosifePlayerWeapon);
            this.AddWeapon(autoGuidePlayerWeapon);
        }

        public override void Attaque(Vaisseau targetedSpaceShip){
            targetedSpaceShip.getShoot(this.GetWeapon().Shoting());
        }
    }
}
