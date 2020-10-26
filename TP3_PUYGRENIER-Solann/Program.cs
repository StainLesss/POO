/* PUYGRNEIER Solann
 * 1A - EICNAM
 * 4/10/2020
 * 270 lignes de codes
 * */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Puygrenier_Solann
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PUYGRENIER Solann - le 4/10/20");
            Console.WriteLine("======================");
            SpaceInvaders TheBestGame = new SpaceInvaders();
            TheBestGame.Main();
            TheBestGame.ShowPlayer();
            TheBestGame.ShowArmory();
            TheBestGame.ShowAllBattleShip();

            //Test exception
            Armory ArmoryForTest = new Armory();
            Weapon WeaponForTest = new Weapon();
            Console.WriteLine("\nStatement :\n ArmoryForTest.AddWeapon(WeaponForTest)\n ArmoryForTest.AddWeapon(WeaponForTest)");
            ArmoryForTest.AddWeapon(WeaponForTest);
            ArmoryForTest.AddWeapon(WeaponForTest);
            Console.ReadLine();
        }
    }
}
