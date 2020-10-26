using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    public class SpaceInvaders{

        public static List<Vaisseau> ListEnemy;
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

            BWings enemy1 = new BWings();
            Dart enemy2 = new Dart();
            F_18 enemy3 = new F_18();
            Rocinante enemy4 = new Rocinante();
            Tardis enemy5 = new Tardis();

            ListEnemy.Add(enemy1);
            ListEnemy.Add(enemy2);
            ListEnemy.Add(enemy3);
            ListEnemy.Add(enemy4);
            ListEnemy.Add(enemy5);
        }

        private void MakeOneCompleteTurnOfGame(){
            int cnt = 0;
            int percentInitiative;
            bool playerHaveShot = false;
            Random randomPercentageOfChance = new Random();
            

            foreach (Vaisseau v in ListEnemy){
                if (PlayerOne.spaceShip.Alive){
                    cnt++; 
                     percentInitiative = cnt * 100 / ListEnemy.Count;
                    if (randomPercentageOfChance.Next(100) > percentInitiative){
                        if (v is IAptitude){
                            (IAptitude)v.Utilise(ListEnemy);
                        }
                        v.Attaque(PlayerOne.spaceShip);

                    }
                    else { }
                    
                }
                else
               
                

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
            Console.WriteLine("Joueur :" + aPlayer.userFullName);
            Console.WriteLine("Santé :" + aPlayer.spaceShip.Health);
            Console.WriteLine("Bouclier:" + aPlayer.spaceShip.Shield);
            Console.WriteLine("Arme  :"+ aPlayer.spaceShip.GetWeapon());
            Console.WriteLine("Degat moyen:"+aPlayer.spaceShip.AverageDamage());
            
        }
    }
}
