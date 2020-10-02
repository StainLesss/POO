/* EICNAM 1A 
 * PUYGRENIER Solann
 *  le 02/10/2020
 */

using System;
using System.Linq;
using System.Threading;

namespace TD1
{
    class Program
    {
        const string ANOREXIE = "Attention à l'anorexie!";
        const string MAIGRICHON = "Vous etes un peux maigrichon";
        const string NORMAL = "Vous etes de corpulence normale!";
        const string SURPOID = "Vous etes en surpoid!";
        const string MODERE = "Obesité modérée!";
        const string SEVERE = "Obesité sévère";
        const string MORBIDE = "Obésité morbide";
        
        static void Main(string[] args)
        {
            string usrFirstName, usrLastName,usrHeight,usrWeight,usrYear;
            bool stayLoop = true;
            do{
                Console.WriteLine("Binevenue dans mon programme jeune etranger imberbe");
                usrLastName = AskUserInputUntilIsOnlyLetters("Donne moi ton nom ?");
                usrFirstName = AskUserInputUntilIsOnlyLetters("Et quel est ton prenom ?");
                Console.WriteLine("Bonjour " + FormatTheName(usrFirstName, usrLastName));

                usrHeight = AskUserUntilInputIsMoreThanZero("Quel est ta taille ?(cm)");
                usrWeight = AskUserUntilInputIsMoreThanZero("Quel est ton poids ? ");
                usrYear = AskUserUntilInputIsMoreThanZero("Quel est ton age ? ");

                if (int.Parse(usrYear) < 18) { Console.WriteLine("ah ah, tu es mineur , BOUOUUOUUO ! "); }

                float imc = CalculImc(usrWeight, usrHeight);
                Console.WriteLine("IMC = " + imc.ToString("00"));

                CommentImc(imc);

                Console.WriteLine("Nombre de cheveux :" + AskUsrHair());

                stayLoop = AskUserEndingChoices();
            } while (stayLoop);
            
        }

        /// <summary>
        /// Function for format <paramref name="FirstName"/> with first letter in upper case, others in lower case 
        /// and <paramref name="LastName"/> with each letter in upper case
        /// <br>For examples:</br>
        ///<example>James BOND;Roger RABBIT</example>
        /// </summary>
        /// <param name="FirstName"></param>
        /// <param name="LastName"></param>
        /// <returns>A string with First Name and Last name</returns>
        static string FormatTheName(string FirstName, string LastName)
        {
            return FirstName.Substring(0,1).ToUpper()+ FirstName.Substring(1) + " " + LastName.ToUpper(); ;
        }

        /// <summary>
        /// Function calculating the IMC using the formula : Weight(kg) / Height(m)² 
        ///  <br><remarks>Height must be provided in centimeters because conversion will be done inside the function</remarks></br>
        /// </summary>
        /// <param name="Weight">The weight in Kilogrammes</param>
        /// <param name="Height">The Height in Centimeters</param>
        /// <returns>IMC as float</returns>
        static float CalculImc(string weight, string height)
        {
            float heightConvert = float.Parse(height) / 100;
            float weightConvert = (float.Parse(weight));
            return (float)(weightConvert / (Math.Pow((heightConvert), 2)));
        }


        /// <summary>
        /// Print explicit informaton relative to the provided IMC into the console 
        /// <br><remarks>IMC can be calculated using <see cref="CalculImc(string, string)"/></remarks></br>
        /// </summary>
        /// <param name="imc"></param>
        static void CommentImc(float imc)
        {
            if (imc < 16.5) { Console.WriteLine(ANOREXIE);}
            else if(imc >=16.5 && imc < 18.5) { Console.WriteLine(MAIGRICHON); }
            else if(imc>=18.5 && imc < 25) { Console.WriteLine(NORMAL);}
            else if(imc >=25 && imc < 30) { Console.WriteLine(SURPOID);}
            else if(imc >= 30 && imc < 35) { Console.WriteLine(MODERE);}
            else if(imc>=35 && imc < 40) { Console.WriteLine(SEVERE);}
            else { Console.WriteLine(MORBIDE);}
        }


        /// <summary>
        /// Ask for a number between 100 000 and 150 000 to the user via console.
        /// <br>Number is check for corect input, only number can be entered</br>. 
        /// </summary>
        static int AskUsrHair(){
            bool stayLoop = true;
            string usrInput="";
            int usrNbHair=0;
            int valError = 0;
            bool correctInput;
            Console.WriteLine("Merci de saisir le nombre de cheveux sur votre tête");
            do
            {
                Console.Write("->");
                usrInput = Console.ReadLine();
                correctInput = int.TryParse(usrInput, out valError);
                if (correctInput)
                {
                    usrNbHair = int.Parse(usrInput);
                    if (usrNbHair >= 100000 && usrNbHair < 150000) { stayLoop = false; }
                    else { Console.WriteLine("Le nombre de cheveux est trop petit ou trop grand"); }
                }

                else { Console.WriteLine("ERREUR DE SAISIE"); }
            } while (stayLoop);
            return usrNbHair;
        }

        /// <summary>
        /// Provide information about the presence or abscence of number into the string input
        /// <br>False if not any number, true if at least a number</br>
        /// </summary>
        /// <returns></returns>
        static bool IsContainingNumber(string aValue)
        {
            if (aValue.Any(char.IsDigit)) { 
                return true; 
            }
            return false;
        }

        /// <summary>
        /// Ask user to enter value until it is only alphanumercis
        /// </summary>
        /// <param name="whatToAsk">a question for the user</param>
        static string AskUserInputUntilIsOnlyLetters(string whatToAsk)
        {
            bool stayLoop = true;
            string userInput;
            do
            {
                Console.WriteLine(whatToAsk);
                userInput = Console.ReadLine();
                if (IsContainingNumber(userInput))
                {
                    Console.WriteLine("ERREUR");
                }
                else { stayLoop = false; }
            } while (stayLoop);
            return userInput;
        }

        /// <summary>
        /// Control if the value is indeed superior than zero
        /// </summary>
        /// <returns></returns>
        static bool IsStricMoreThanZero(string aValue)
        {
            if (int.Parse(aValue) > 0)
            {
                return true;
            }
            else { return false; }
        }

        /// <summary>
        /// Control if the value can be converted into integer (no punctuation neither alpha)
        /// </summary>
        static bool IsOnlyInteger(string aValue)
        {
            int valError;
            bool correctInput = int.TryParse(aValue, out valError);

            if (correctInput)
            {
                return true;
            }
            else { return false; }
        }

        /// <summary>
        /// Ask user to enter value until it is only a value more than zero
        /// <remarks><br>Be carefull, it does handle if input contains letters</br></remarks>
        /// </summary>
        /// <param name="whatToAsk">a question for the user</param>
        static string AskUserUntilInputIsMoreThanZero(string whatToAsk)
        {
            bool stayloop = true;
            string userInput;
            do
            {
                Console.WriteLine(whatToAsk);
                userInput = Console.ReadLine();
                if (IsOnlyInteger(userInput) && IsStricMoreThanZero(userInput)){ 
                    stayloop = false; }
                else { Console.WriteLine("ERREUR"); }
            } while (stayloop);
            return userInput;
        }

        /// <summary>
        /// Ask for the final choice : Quit/Restart/Wait 10s/Call Aunt Jacqueline
        /// </summary>
        /// <returns>Send true if the restart is choosen</returns>
        static bool AskUserEndingChoices()
        {
            bool res = true;
            Console.WriteLine("Choix :" +
                "\n - 1 Quitter" +
                "\n - 2 Et c'est repartit" +
                "\n - 3 Comptons jusqu'a dix" +
                "\n - 4 Téléphoner a Tata Jacqueline");
            string userInpupt = Console.ReadLine();
            switch (int.Parse(userInpupt))
            {
                case 1: 
                    res = false;//quit the 
                    break;
                case 2: 
                    res = true;//stay in the
                    break;
                case 3:  countSecondeConsole(10);
                    res = false;
                    break;
                case 4: callJacqueline();
                    res = false;
                    break;
                default:
                    Console.WriteLine("Je n'ai pas compris...");
                    break;
            }
            return res;
        }

        /// <summary>
        /// Wait for the given seconde and show the count into the console
        /// </summary>
        static void countSecondeConsole(int seconde)
        {
            for(int i = 1; i <= seconde; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine(i+" seconde...");

            }
        }

        /// <summary>
        /// Call Jacqueline, making telephone completion.
        /// </summary>
        static void callJacqueline()  
        {
            string messageJacqueline = "B... B...B...Bonj...Bonj...Bonjour, " +
            "v...v...v...vous êt... êtes b... b...bien ch... " +
            "ch...chez... JACQUELINE,j...je ne suis p... p...pas là " +
            "p...po...pour l'ins... l'ins...l'instant, " +
            "et... et... v... v... vous pou... pouvez lai... l... laisser un... un... un messa... message  " +
            "après le bip sonore. Au... au... au... r... r... rev... revoir.";
            for (int i = 0; i < 5; i++)
            {
                Console.Write(".");
                Console.Beep(1000, 500);
                Thread.Sleep(250);
            }
            Console.Beep(1000, 3000);
            for (int i = 0; i < messageJacqueline.Length; i++)
            {
                Console.Write(messageJacqueline[i]);
                Thread.Sleep(25);
            }
        }

    }
}
