using System;
using System.Runtime.CompilerServices;
using TP2_Puygrenier_Solann;

namespace TP3 {
public class Dart : Vaisseau { 
	public Dart() : base(){
        initHealth = 10;
        initShield = 3;
        Health = initHealth;
        Shield = initShield;
        Weapon dartWeapon = new Weapon("MajorLazer", 1, 2, Type.Direct,1);
        this.AddWeapon(dartWeapon);
    }
    public override void Attaque(Vaisseau targetedSpaceShip){
            targetedSpaceShip.getShoot(this.GetWeapon().Shoting());
    }
}
}
