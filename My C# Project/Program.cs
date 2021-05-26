using System;

namespace My_C__Project{

    class Knight{
        public string name;
        public string weapon;
        public int DMG;
        public int health;
        public int stamina;
        public int PermStamina;

        public Knight(string _name, string _weapon){
            name = _name;
            weapon = _weapon;
            DMG = rand();
            health = rand();
            stamina = rand();
            PermStamina = stamina;
        }

        public int rand(){
            Random num = new Random();
            int ran = num.Next(1,10);
            return ran;
        }

        public void attack(){
            if(stamina > 0){
                Console.WriteLine(name + " attacked, he dealt " + DMG + "attack damage");
                stamina--;
            }
            else{
                Console.WriteLine("You are too tired to attack");
            }
        }

        public void rest(){
            stamina = PermStamina;
            Console.WriteLine("You Rested and regained all of your stamina, your stamina is now " + stamina);
        }

        public void heal(){
            health = health + stamina;
            stamina = 0;
            Console.WriteLine("You Used all your Stamina to Heal, Your Health is now " + health + " and your Stamina is now 0");
        }
    }

    class Enemy{
        public int Ehealth;
        public int EDMG;
        public int Estamina;
        public int EPermStamina;

        public Enemy(){
            Ehealth = 10;
            EDMG = 1;
            Estamina = 5;
            EPermStamina = Estamina;
        }

        public void Eattack(){
            if(Estamina > 0){
                Console.WriteLine("The Enemy Attacked dealing " + EDMG + " damage");
                Estamina--;
            }
            else{
                Console.WriteLine("The enemy tried to attack but was too tired");
            }

        }
        public void Erest(){
            Estamina = EPermStamina;
            Console.WriteLine("The enemy Rested and regained all of their stamina, their stamina is now " + Estamina);
        }

        public void Eheal(){
            Ehealth = Ehealth + Estamina;
            Estamina = 0;
            Console.WriteLine("The Enemy used all their Stamina to Heal, their Health is now " + Ehealth + " and their Stamina is now 0");
        }
    }
    
    class Program{
        static void Main(string[] args){
            string yn;
            while(true){
                Game();
                Console.WriteLine("Do you want to play again? y/n");
                yn = Console.ReadLine();

                if(yn == "n")
                    break;
                else if(yn == "y")
                    Console.WriteLine("Ok I will Restart the game for you!");
                else{
                    Console.WriteLine("I don't really understand Do you want to play again y/n (make sure it is lowercase)");
                    yn = Console.ReadLine();
                    if(yn == "n")
                        break;
                    else if(yn == "y")
                        Console.WriteLine("Ok I will Restart the game for you!");
                    else
                        Console.WriteLine("I don't really understand I will asume you put y");
                }
            }

            Console.ReadKey();
        }

        static void Game(){
            Knight knight1 = new Knight("Joe", "Excalibur");
            Enemy ah = new Enemy();

            string[] options = {"Attack", "Rest", "Heal"};
            int userInput;
            int x;

            while(true){
                for(int i = 0; i < options.Length; i++){
                    int rank = i+1;
                    Console.WriteLine("Choose an Option:" + rank + ". " + options[i]);
                }
                userInput = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Green;


                //User
                if (userInput == 1){
                    knight1.attack();
                    ah.Ehealth--;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Enemy Health is " + ah.Ehealth);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if(userInput == 2)
                    knight1.rest();
                else if(userInput == 3)
                    Console.WriteLine("You Rested");
                else if(userInput == 4){
                    Console.WriteLine("If You So Desire...");
                    break;
                }
                else
                    Console.WriteLine("That is Not a valid Option");


                //Enemy Health Checker
                if (eHealth <= 0){
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("You Won!");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }

                x = ranNum();
                Console.ForegroundColor = ConsoleColor.Red;

                //Computer
                if(x == 0){
                    Console.WriteLine("The Enemy Attacks");
                    knight1.health--;
                    Console.WriteLine(knight1.name + "'s Health is now " + wizard1.health);
                }
                else if(x == 1)
                    Console.WriteLine("The Enemy Meditates");
                else if(x == 2)
                    Console.WriteLine("The Enemy Waits");
                else
                    Console.WriteLine("There was a Problem");

                Console.ForegroundColor = ConsoleColor.White;

                //Player Health Checker
                if(wizard1.health <= 0){
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("You Died Sorry D:");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                
            }

        static int ranNum(){
            Random num = new Random();
            int ran = num.Next(0,2);
            return ran;
        }
    }
}
}
}
