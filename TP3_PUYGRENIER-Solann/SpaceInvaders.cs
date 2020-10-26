using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Puygrenier_Solann
{
    public class SpaceInvaders{
        private Player playerOne;
        private Player playerTwo;
        private Player playerThree;
        private Armory sharedArmory;

        public Player PlayerOne { get; set;}
        public Player PlayerTwo { get; set; }
        public Player PlayerThree { get; set; }

        public SpaceInvaders(){
            Init();
        }
        public void Main(){
            SpaceInvaders myGame = new SpaceInvaders();
            Console.WriteLine(myGame.ToString());
            

        } 
        private void Init(){
            PlayerOne = new Player("AlphaGamer", "john", "doe");
            PlayerTwo = new Player("noob69", "brice", "deNice");
            PlayerThree = new Player("RandomPlayer", "rogers", "smith");
            sharedArmory = new Armory();
        }
        public void ShowPlayer(){
            Console.WriteLine("Les Joueurs :");
            Console.WriteLine("|Joueur 1: " + this.PlayerOne.ToString());
            Console.WriteLine("|Joueur 2: " + this.PlayerTwo.ToString() );
            Console.WriteLine("|Joueur 3: " + this.PlayerThree.ToString());
        }
        public void ShowArmory(){
            Console.WriteLine("Armurerie :\n"+this.sharedArmory.ToString());
        }
        public void ShowAllBattleShip(){
            ShowBattleShip(PlayerOne);
            ShowBattleShip(PlayerTwo);
            ShowBattleShip(PlayerThree);
        }
        private void ShowBattleShip(Player aPlayer){
            Console.WriteLine("# # # # #");
            Console.WriteLine("Joueur :" + aPlayer.UserFullName);
            Console.WriteLine("Santé :" + aPlayer.UserSpaceShip.Health);
            Console.WriteLine("Bouclier:" + aPlayer.UserSpaceShip.Shield);
            Console.WriteLine("Arme  :"+ aPlayer.UserSpaceShip.GetWeapon());
            Console.WriteLine("Degat moyen:"+aPlayer.UserSpaceShip.AverageDamage());
            
        }
    }
}
