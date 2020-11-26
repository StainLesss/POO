using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    public class SpaceInvaders{
        public static List<Vaisseau> AllSpaceShip = new List<Vaisseau>();
        public static List<Vaisseau> ListEnemy = new List<Vaisseau>();
        private Armory sharedArmory;
        public Player PlayerOne { get; set;}
        public Player PlayerTwo { get; set; }
        public Player PlayerThree { get; set; }
        public SpaceInvaders(){
            Init();
        }

        public void Main(){
            int tourNo=0;
            ShowInit();
            while ((ThePlayerOne.spaceShip.Alive) && (ListEnemy.Count > 1)){ 
                tourNo++;
                Console.WriteLine("\n=="+tourNo+"==");
                ShowState();
                MakeOneCompleteTurnOfGame();
                CleanEndTurn();
            }
        }
        
        private void Init(){
            sharedArmory = new Armory();
            ThePlayerOne.userFullName = "Brice";
            ThePlayerOne.spaceShip = new ViperMKII();

            BWings enemy1 = new BWings();
            //enemy1.ChangeWeapon();

            Dart enemy2 = new Dart();
            //enemy2.ChangeWeapon();

            F_18 enemy3 = new F_18();

            Rocinante enemy4 = new Rocinante();
            //enemy4.ChangeWeapon();

            //Tardis enemy5 = new Tardis();
            ListEnemy.Add(enemy1);
            ListEnemy.Add(enemy2);
            ListEnemy.Add(enemy3);
            ListEnemy.Add(enemy4);
            //ListEnemy.Add(enemy5);

            AllSpaceShip.Add(ThePlayerOne.spaceShip);
            Console.WriteLine("Conteur : " + (AllSpaceShip.Count - 1));
            AllSpaceShip.AddRange(ListEnemy);
            Console.WriteLine("Conteur : " + (AllSpaceShip.Count - 1));

        }

        private void MakeOneCompleteTurnOfGame(){
            int cnt = 0;
            int percentInitiative;
            bool playerHaveShot = false;
            Random proba = new Random();

            if (ThePlayerOne.spaceShip.Alive){
                foreach (Vaisseau v in ListEnemy){
                    cnt++;
                    percentInitiative = cnt * 100 / ListEnemy.Count;
                    if (playerHaveShot|((proba.Next(100) > percentInitiative))){
                        if (v is IAptitude){
                            IAptitude specialShip = v as IAptitude;
                            specialShip.Utilise(ListEnemy);
                            Console.WriteLine("| Special Ship no #" + v.GetHashCode());
                            //IAptitude tmp = (IAptitude)v;
                            //tmp.Utilise(ListEnemy);
                        }
                        else {
                            Console.Write("| Ship no #" + v.GetHashCode() + " -> damage this turn ");
                            v.Attaque(ThePlayerOne.spaceShip);
                        }
                    }
                    else{
                        int indexToShot = proba.Next(ListEnemy.Count);
                        Console.Write("| PLAYER have shot the ship no #" + ListEnemy.ElementAt(indexToShot).GetHashCode());
                        ThePlayerOne.spaceShip.Attaque(ListEnemy.ElementAt(indexToShot));
                        if (!ListEnemy.ElementAt(indexToShot).Alive){ //If not alive
                            //ListEnemy.ElementAt(indexToShot).
                        }
                        playerHaveShot = true;
                        }
                    }
                }
            }
        private void CleanEndTurn(){
            foreach (Vaisseau v in ListEnemy.Reverse<Vaisseau>()){
                if (!v.Alive){
                    ListEnemy.Remove(v);
                }
            }
        }
        public void ShowInit() {
            Console.WriteLine("Liste opposants:");
            foreach (Vaisseau v in ListEnemy) {
                Console.Write("#" + v.GetHashCode() + "|");
            }
            Console.WriteLine("\nVaisseau :");
            Console.WriteLine("#" + ThePlayerOne.spaceShip.GetHashCode());
        }
        public void ShowState(){
            Console.WriteLine(" :)  "+ AllSpaceShip[0].ToString());
            for (int i=1;i< AllSpaceShip.Count-1;i++){
                Console.WriteLine(" :(  " + AllSpaceShip[i].ToString()+ " #"+ AllSpaceShip[i].GetHashCode());
            }
        }
        public void ShowArmory(){
            Console.WriteLine("Armurerie :\n"+this.sharedArmory.ToString());
        }


    }
}
