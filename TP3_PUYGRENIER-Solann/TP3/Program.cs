/* PUYGRNEIER Solann
 * 1A - EICNAM
 * 26/10/2020
 * lignes de codes :
 * */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3;

namespace TP2_Puygrenier_Solann
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PUYGRENIER Solann - le 26/10/20");
            Console.WriteLine("======================");
            /*
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
            */

            ViperMKII thePlayerspaceShipp = new ViperMKII();
            BWings enemySpaceShip = new BWings();

            Console.WriteLine(thePlayerspaceShipp.ToString());

            enemySpaceShip.Attaque(thePlayerspaceShipp);
            enemySpaceShip.Attaque(thePlayerspaceShipp);
            enemySpaceShip.Attaque(thePlayerspaceShipp);
            enemySpaceShip.Attaque(thePlayerspaceShipp);
            enemySpaceShip.Attaque(thePlayerspaceShipp);
            enemySpaceShip.Attaque(thePlayerspaceShipp);
            enemySpaceShip.Attaque(thePlayerspaceShipp);
            enemySpaceShip.Attaque(thePlayerspaceShipp);

            Console.WriteLine(thePlayerspaceShipp.ToString());
        }
    }
}
