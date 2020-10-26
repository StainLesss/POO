using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Puygrenier_Solann
{
    class Armory{
        private List<Weapon> myWeapon = new List<Weapon>();
        
        public Armory(){
            Init();
        }
        private void Init(){
            AddWeapon(new Weapon("Crycket", 30, Type.Direct));
            AddWeapon(new Weapon("Kawabonga", 100, Type.Explosife));
            AddWeapon(new Weapon("WallE", 50, Type.AutoGuide));
        }

        public bool DropWeapon(Weapon removedWeapon){
            if (myWeapon.Contains(removedWeapon)){
                myWeapon.Remove(removedWeapon);
                return true;
            }
            return false;
        }
        public bool AddWeapon(Weapon anotherWeapon){
            try{
                if (myWeapon.Contains(anotherWeapon)){
                    throw new ArmurerieException("EXCEPTION : Already exist"); 
                    //return false;
                }
                myWeapon.Add(anotherWeapon);
            }
            catch (ArmurerieException ex){
                Console.WriteLine(ex.Message);
            }
            return true;
        }
        public override string ToString(){
            string str = "";
            foreach (Weapon weap in myWeapon){
                str = str + "|" + weap.ToString() + "|\n";
            }
            return str;
        }
    }
}
