using System;

namespace htc_TLH_final_project
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("Hello! What is your name?");
            string name = Console.ReadLine();
             string PersonChoice = "";
             string RoomChoice;
             string WeaponChoice;
          while (true)
          {
              
          
            Console.WriteLine("Hello " + name + ". Welcome to CLUE! There is a bug in Hyland. It was planted by either Green, Scarlet, Mustard, or White. It is your job to guess who it was. in what room it was planted in and what weapon they used to protect themselves. The weapon could have been a gun, a rock, a knife, or an ice cream cone. The room could of been the coding room, the cafiteria, the breakplace, or in the slide. Good Luck.");?");
            string PlayedBefore = Console.ReadLine();
            
            if(PlayedBefore == "yes" || PlayedBefore == "Yes"){
           
                
            Console.WriteLine("Choose a number between 1 to 4.");
                string PersonNumber = Console.ReadLine();
               
                 if (PersonNumber == "1"){
                     PersonChoice = "Mustard";
                    
                }
                else if (PersonNumber == "2"){
                     PersonChoice = "Scarlet";
                     
                }
                 else if (PersonNumber == "3"){
                     PersonChoice = "White";
                     
                }
                 else if (PersonNumber == "4"){
                     PersonChoice = "Green";
                     
                }

                else {PersonChoice = "null";}
               
            }

            

            Console.WriteLine("Great! Now choose another 1 through 4");
             string RoomNumber = Console.ReadLine();
              
             if (RoomNumber == "1"){
                    RoomChoice = "Break Place";
            
             }
             else if (RoomNumber == "2"){
                     RoomChoice = "Coding Room";
                     
                }
                else if (RoomNumber == "3"){
                     RoomChoice = "Slide";
                     
                }
                else if (RoomNumber == "4"){
                     RoomChoice = "Cafiteria";
                     
                }

            Console.WriteLine("Great! Now choose ANOTHER 1 through 4. believe me, this is the last time.");
             string WeaponNumber = Console.ReadLine();
            
             if (WeaponNumber == "1"){
                    WeaponChoice = "gun";
            
             }
            
             else if (WeaponNumber == "2"){
                    WeaponChoice = "Ice Cream Cone";
            
             }

               else if (WeaponNumber == "3"){
                   WeaponChoice = "Rock";
            
             }
             
             else if (WeaponNumber == "4")
             {
                   WeaponChoice = "Knife";
            
             }
             
           Console.WriteLine(PersonChoice);
           }

          


        }
    }
}
