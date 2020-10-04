using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Puygrenier_Solann
{

    public enum Type { Direct, Explosife, AutoGuide, }

    public class Weapon{
        private const int MINIMUM_DAMAGE = 10;
        private const int MAXIMUM_DAMAGE = 100;
        public string Name { get; set; }
        public int Damage { get; set; }
        public Type WeaponType { get; set; }

        /// <summary>
        /// Default Weapon
        /// </summary>
        public Weapon(){
            this.Name = "Crycket";
            this.Damage = MINIMUM_DAMAGE;
            this.WeaponType = Type.Direct;
        }

        public Weapon(string name, int damage, Type weaponType){
            Name = name;
            Damage = damage;
            WeaponType = weaponType;
        }

        public override string ToString(){
            return Name.ToString() +"/"+ Damage.ToString()+"dmg/"+ WeaponType.ToString();
        }

    }

     
}
