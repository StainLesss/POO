using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{

    public enum Type { Direct, Explosife, AutoGuide, }

    public class Weapon{
        private int minimumDamage = 10;
        private int maximumDamage = 100;
        private int timeOfReload = 5;

        public string Name { get; set; }
        public float DamageAverage;
        public Type WeaponType { get; set; }
        private int countBeforeNextShot;


        public Weapon(string name, int damage, Type weaponType){
            Name = name;
            DamageAverage = damage;
            WeaponType = weaponType;
            this.countBeforeNextShot = timeOfReload;
        }
        public Weapon(string name,int damageMin,int damageMax, Type weaponType,int cadenceShot)
        {
            Name = name;
            DamageAverage = (damageMin + damageMax) / 2;
            minimumDamage = damageMin;
            maximumDamage = damageMax;
            WeaponType = weaponType;
            timeOfReload = cadenceShot;
            this.countBeforeNextShot = timeOfReload;

        }

        public override string ToString(){

            return "[Nom :"+Name.ToString() +" \t\t]\n"+ 
                "[  Dmgs :"+ minimumDamage +"-"+ maximumDamage + "\t\t]\n" +
                "[  Cadences:" + timeOfReload+ "\t\t]\n" +
                "[  Type : " + WeaponType +"\t]\n";
        }

        public int Shoting(){
            countBeforeNextShot--;
            if (countBeforeNextShot == 0) {
                countBeforeNextShot = timeOfReload;
                Random rnd = new Random();
                Random dodgePercent = new Random();
                switch (WeaponType){
                    case Type.Direct:
                        if (dodgePercent.Next(100) <= 10) return 0; // 1 out of 10 to miss = 10%
                        else return rnd.Next(minimumDamage, maximumDamage + 1);
                    case Type.Explosife:
                        if (dodgePercent.Next(100) <= 25) return 0; // 1 out of 4 to miss = 25%
                        else {
                            countBeforeNextShot = timeOfReload * 2;
                            return rnd.Next(minimumDamage, maximumDamage + 1)*2;
                        }
                    case Type.AutoGuide:
                        return minimumDamage;
                }

                return 0;
            }
            return 0;
        }

    }

     
}
