using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Puygrenier_Solann
{
    public class Vaisseau{
        private const int INIT_HEALTH = 100;
        private const int INIT_SHIELD = 100;
        private const int LIMIT_INVENTORY = 3;

        private List<Weapon> weaponInventory;
        public int Health { get; set; }
        public int Shield { get; set; }
        public bool Alive { get; set; }

        /// <summary>
        /// Default space ship
        /// </summary>
        public Vaisseau(){
            weaponInventory = new List<Weapon>();
            weaponInventory.Add(new Weapon());
            Alive = true;
            Health = INIT_HEALTH;
            Shield = INIT_SHIELD;
        }


        public bool AddWeapon(Weapon anotherWeapon){
            if (weaponInventory.Count < LIMIT_INVENTORY){
                weaponInventory.Add(anotherWeapon);
                return true;
            }
            else return false;
        }

        public bool DropWeapon(Weapon anotherWeapon){
            if (weaponInventory.Contains(anotherWeapon)){
                weaponInventory.Remove(anotherWeapon);
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

        public string GetWeapon(){
            string str = "";
            foreach(Weapon weap in weaponInventory){
                str = str + weap.ToString()+"/";
            }
            return str;
        }

        public float AverageDamage(){
            float sum = 0;
            int cnt=0;
            foreach (Weapon weap in weaponInventory)
            {
                cnt++;
                sum = sum + weap.Damage;
            }
            if(sum == 0) { return 0; }
            else { return sum / cnt; }
        }
    }
}
