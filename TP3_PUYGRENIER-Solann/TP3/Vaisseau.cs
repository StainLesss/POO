using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    public abstract class Vaisseau{
        protected int initHealth ;
        protected int initShield;
        protected const int LIMIT_INVENTORY = 3;
        protected int equipedWeapon=1;

        protected List<Weapon> weaponInventory;
        public int Health { get; set; }
        public int Shield { get; set; }
        public bool Alive { get; set; }

        public abstract void Attaque(Vaisseau targetedSpaceShip);

        /// <summary>
        /// Default space ship
        /// </summary>
        public Vaisseau(){
            weaponInventory = new List<Weapon>();
            Alive = true;
            Health = initHealth;
            Shield = initShield;
        }

        public void getShoot(int damageReceived){
            if (Alive == false) { Console.WriteLine("Have a look on this : dead Space ship CANNOT be shotable!"); }
            else if (Shield > damageReceived) Shield -= damageReceived;
            else if ((Shield <= damageReceived) && (Shield > 0)) {
                Shield = 0;
                Health = Health - (damageReceived - Shield); }
            else if ((Shield == 0) && (Health > damageReceived)) { Health -= damageReceived;}
            else {
                Health = 0;
                Alive = false; 
            }
        }

        public bool AddWeapon(Weapon anotherWeapon){
            if (weaponInventory.Count < LIMIT_INVENTORY){
                weaponInventory.Add(anotherWeapon);
                equipedWeapon = weaponInventory.Count; // auto update weapon
                return true;
            }
            else return false;
        }

        public bool DropWeapon(Weapon anotherWeapon){
            if (weaponInventory.Contains(anotherWeapon)){
                weaponInventory.Remove(anotherWeapon);
                equipedWeapon = 1;
                return true;
            }
            return false;
        }

        public void ShowWeapon(){
            int cnt = 0;
            foreach(Weapon weap in weaponInventory){
                cnt++;
                Console.WriteLine($"Weapon no°{cnt}: {weap.ToString()}");
            }
        }

        public override string ToString(){
            string str = "";
            str = "[Health :" + Health + "/" + initHealth + "\t]\n" +
                "[Shield :" + Shield + "/" + initShield + "\t]\n" +
                "[Curent weapon no:" + equipedWeapon + "/" + LIMIT_INVENTORY + "\t]\n";
            foreach (Weapon weap in weaponInventory){
                str = str + weap.ToString();
            }
            return str;
        }

        public Weapon GetWeapon(){
            return weaponInventory[equipedWeapon-1];
        }

        public void ChangeWeapon(){
            if (equipedWeapon == LIMIT_INVENTORY) equipedWeapon = 1;
            else equipedWeapon++;
        }


        public float AverageDamage(){
            float sum = 0;
            int cnt=0;
            foreach (Weapon weap in weaponInventory){
                cnt++;
                sum = sum + weap.DamageAverage;
            }
            if(sum == 0) { return 0; }
            else { return sum / cnt; }
        }
    }
}
