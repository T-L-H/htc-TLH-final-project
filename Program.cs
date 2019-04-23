using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello! What is your name?");
		string name = Console.ReadLine();
		string PersonChoice = "";
		string RoomChoice = "";
		string WeaponChoice = "";
		int i = 0;
		while (true)
		{
			bool ReadyorNot = greeting(name);
			if (ReadyorNot)
			{
				Console.WriteLine("Choose 1 through 4.");
				string PersonNumber = Console.ReadLine();
				if (PersonNumber == "1")
				{
					PersonChoice = "Mustard";
				}
				else if (PersonNumber == "2")
				{
					PersonChoice = "Scarlet";
				}
				else if (PersonNumber == "3")
				{
					PersonChoice = "White";
				}
				else if (PersonNumber == "4")
				{
					PersonChoice = "Green";
				}
				else
				{
					break;
				}

				Console.WriteLine("Great! Now choose another 1 through 4");
				string RoomNumber = Console.ReadLine();
				if (RoomNumber == "1")
				{
					RoomChoice = "Break Place";
				}
				else if (RoomNumber == "2")
				{
					RoomChoice = "Coding Room";
				}
				else if (RoomNumber == "3")
				{
					RoomChoice = "Slide";
				}
				else if (RoomNumber == "4")
				{
					RoomChoice = "Cafiteria";
				}
				else
				{
					break;
				}

				Console.WriteLine("Great! Now choose ANOTHER 1 through 4. believe me, this is the last time.");
				string WeaponNumber = Console.ReadLine();
				if (WeaponNumber == "1")
				{
					WeaponChoice = "Gun";
				}
				else if (WeaponNumber == "2")
				{
					WeaponChoice = "Ice Cream Cone";
				}
				else if (WeaponNumber == "3")
				{
					WeaponChoice = "Rock";
				}
				else if (WeaponNumber == "4")
				{
					WeaponChoice = "Knife";
				}
				else
				{
					break;
				}

				if (PersonChoice == "Mustard" && RoomChoice == "Break Place" && WeaponChoice == "Gun")
				{
					Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
					Console.WriteLine("Here are your clues:");
					Console.WriteLine("Scarlet");
					Console.WriteLine("Rock");
					Console.WriteLine("Slide");
					Console.WriteLine("Green");
					Console.WriteLine("Knife");
					Console.WriteLine("");
					Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
					while (i < 4)
					{
						Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
						Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
						Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
						Console.WriteLine("What clue do you want?");
						string Game1 = Console.ReadLine();
						if (Game1 == "Ice Cream" || Game1 == "Coding" || Game1 == "Cafiteria" || Game1 == "White")
						{
							Console.WriteLine("YES");
							i++;
						}
						else if (Game1 == "Final")
						{
							Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
							string Game1Answer = Console.ReadLine();
							if (Game1Answer == "MustardBreakGun")
							{
								Console.WriteLine("You did it! You Won!");
								break;
							}
							else
							{
								Console.WriteLine("You Lose...");
								break;
							}
						}
						else
						{
							Console.WriteLine("NO");
							i++;
						}

						if (i == 4)
						{
							Console.WriteLine("YOU LOSE...");
							break;
						}
					}
				}

				if (PersonChoice == "Mustard" && RoomChoice == "Coding Room" && WeaponChoice == "Gun")
				{
					Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
					Console.WriteLine("Here are your clues:");
					Console.WriteLine("White");
					Console.WriteLine("Rock");
					Console.WriteLine("Cafiteria");
					Console.WriteLine("Break");
					Console.WriteLine("Ice Cream");
					Console.WriteLine("");
					Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
					while (i < 4)
					{
						Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
						Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
						Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
						Console.WriteLine("What clue do you want?");
						string Game2 = Console.ReadLine();
						if (Game2 == "Scarlet" || Game2 == "Green" || Game2 == "Knife" || Game2 == "Slide")
						{
							Console.WriteLine("YES");
							i++;
						}
						else if (Game2 == "Final")
						{
							Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
							string Game2Answer = Console.ReadLine();
							if (Game2Answer == "MustardCodingGun")
							{
								Console.WriteLine("You did it! You Won!");
								break;
							}
							else
							{
								Console.WriteLine("You Lose...");
								break;
							}
						}
						else
						{
							Console.WriteLine("NO");
							i++;
						}

						if (i == 4)
						{
							Console.WriteLine("YOU LOSE...");
							break;
						}
					}
				}

				if (PersonChoice == "Mustard" && RoomChoice == "Slide" && WeaponChoice == "Gun")
				{
					Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
					Console.WriteLine("Here are your clues:");
					Console.WriteLine("Green");
					Console.WriteLine("Scarlet");
					Console.WriteLine("White");
					Console.WriteLine("Knife");
					Console.WriteLine("Ice Cream");
					Console.WriteLine("");
					Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
					while (i < 4)
					{
						Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
						Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
						Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
						Console.WriteLine("What clue do you want?");
						string Game3 = Console.ReadLine();
						if (Game3 == "Rock" || Game3 == "Coding" || Game3 == "Cafiteria" || Game3 == "Break")
						{
							Console.WriteLine("YES");
							i++;
						}
						else if (Game3 == "Final")
						{
							Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
							string Game3Answer = Console.ReadLine();
							if (Game3Answer == "MustardSlideGun")
							{
								Console.WriteLine("You did it! You Won!");
								break;
							}
							else
							{
								Console.WriteLine("You Lose...");
								break;
							}
						}
						else
						{
							Console.WriteLine("NO");
							i++;
						}

						if (i == 4)
						{
							Console.WriteLine("YOU LOSE...");
							break;
						}
					}
				}

				if (PersonChoice == "Mustard" && RoomChoice == "Cafiteria" && WeaponChoice == "Gun")
				{
					Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
					Console.WriteLine("Here are your clues:");
					Console.WriteLine("White");
					Console.WriteLine("Scarlet");
					Console.WriteLine("Knife");
					Console.WriteLine("Break");
					Console.WriteLine("Coding");
					Console.WriteLine("");
					Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
					while (i < 4)
					{
						Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
						Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
						Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
						Console.WriteLine("What clue do you want?");
						string Game4 = Console.ReadLine();
						if (Game4 == "Rock" || Game4 == "Green" || Game4 == "Slide" || Game4 == "Ice Cream")
						{
							Console.WriteLine("YES");
							i++;
						}
						else if (Game4 == "Final")
						{
							Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
							string Game4Answer = Console.ReadLine();
							if (Game4Answer == "MustardCafiteriaGun")
							{
								Console.WriteLine("You did it! You Won!");
								break;
							}
							else
							{
								Console.WriteLine("You Lose...");
								break;
							}
						}
						else
						{
							Console.WriteLine("NO");
							i++;
						}

						if (i == 4)
						{
							Console.WriteLine("YOU LOSE...");
							break;
						}
					}
				}

				if (PersonChoice == "Mustard" && RoomChoice == "Break Place" && WeaponChoice == "Ice Cream Cone")
				{
					Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
					Console.WriteLine("Here are your clues:");
					Console.WriteLine("Rock");
					Console.WriteLine("Green");
					Console.WriteLine("Slide");
					Console.WriteLine("Gun");
					Console.WriteLine("Coding");
					Console.WriteLine("");
					Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
					while (i < 4)
					{
						Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
						Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
						Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
						Console.WriteLine("What clue do you want?");
						string Game5 = Console.ReadLine();
						if (Game5 == "White" || Game5 == "Scarlet" || Game5 == "Knife" || Game5 == "Cafiteria")
						{
							Console.WriteLine("YES");
							i++;
						}
						else if (Game5 == "Final")
						{
							Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
							string Game5Answer = Console.ReadLine();
							if (Game5Answer == "MustardBreakIceCream")
							{
								Console.WriteLine("You did it! You Won!");
								break;
							}
							else
							{
								Console.WriteLine("You Lose...");
								break;
							}
						}
						else
						{
							Console.WriteLine("NO");
							i++;
						}

						if (i == 4)
						{
							Console.WriteLine("YOU LOSE...");
							break;
						}
					}
				}
			}

			if (PersonChoice == "Mustard" && RoomChoice == "Coding Room" && WeaponChoice == "Ice Cream Cone")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Rock");
				Console.WriteLine("Gun");
				Console.WriteLine("Knife");
				Console.WriteLine("Break");
				Console.WriteLine("Cafiteria");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game6 = Console.ReadLine();
					if (Game6 == "White" || Game6 == "Scarlet" || Game6 == "Green" || Game6 == "Slide")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game6 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game6Answer = Console.ReadLine();
						if (Game6Answer == "MustardCodingIceCream")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}

			if (PersonChoice == "Mustard" && RoomChoice == "Slide" && WeaponChoice == "Ice Cream Cone")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Break");
				Console.WriteLine("Coding");
				Console.WriteLine("Green");
				Console.WriteLine("Knife");
				Console.WriteLine("Cafiteria");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game7 = Console.ReadLine();
					if (Game7 == "White" || Game7 == "Scarlet" || Game7 == "Gun" || Game7 == "Rock")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game7 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game7Answer = Console.ReadLine();
						if (Game7Answer == "MustardSlideIceCream")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}

			if (PersonChoice == "Mustard" && RoomChoice == "Cafiteria" && WeaponChoice == "Ice Cream Cone")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Break");
				Console.WriteLine("Scarlet");
				Console.WriteLine("Green");
				Console.WriteLine("Slide");
				Console.WriteLine("Rock");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game8 = Console.ReadLine();
					if (Game8 == "White" || Game8 == "Knife" || Game8 == "Gun" || Game8 == "Coding")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game8 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game8Answer = Console.ReadLine();
						if (Game8Answer == "MustardCafiteriaIceCream")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}

			if (PersonChoice == "Mustard" && RoomChoice == "Break Place" && WeaponChoice == "Rock")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Ice Cream");
				Console.WriteLine("White");
				Console.WriteLine("Knife");
				Console.WriteLine("Slide");
				Console.WriteLine("Cafiteria");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game9 = Console.ReadLine();
					if (Game9 == "Green" || Game9 == "Scarlet" || Game9 == "Gun" || Game9 == "Coding")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game9 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game9Answer = Console.ReadLine();
						if (Game9Answer == "MustardBreakRock")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}

			if (PersonChoice == "Mustard" && RoomChoice == "Coding Room" && WeaponChoice == "Rock")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Ice Cream");
				Console.WriteLine("Green");
				Console.WriteLine("Gun");
				Console.WriteLine("Knife");
				Console.WriteLine("Cafiteria");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game10 = Console.ReadLine();
					if (Game10 == "White" || Game10 == "Scarlet" || Game10 == "Break" || Game10 == "Slide")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game10 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game10Answer = Console.ReadLine();
						if (Game10Answer == "MustardCodingRock")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}

			if (PersonChoice == "Mustard" && RoomChoice == "Slide" && WeaponChoice == "Rock")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Scarlet");
				Console.WriteLine("Green");
				Console.WriteLine("Break");
				Console.WriteLine("Knife");
				Console.WriteLine("Gun");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game11 = Console.ReadLine();
					if (Game11 == "White" || Game11 == "Ice Cream" || Game11 == "Coding" || Game11 == "Cafiteria")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game11 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game11Answer = Console.ReadLine();
						if (Game11Answer == "MustardSlideRock")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}

			if (PersonChoice == "Mustard" && RoomChoice == "Cafiteria" && WeaponChoice == "Rock")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Ice Cream");
				Console.WriteLine("Knife");
				Console.WriteLine("Gun");
				Console.WriteLine("Coding");
				Console.WriteLine("Break");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game12 = Console.ReadLine();
					if (Game12 == "White" || Game12 == "Scarlet" || Game12 == "Green" || Game12 == "Slide")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game12 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game12Answer = Console.ReadLine();
						if (Game12Answer == "MustardCafiteriaRock")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}

			if (PersonChoice == "Mustard" && RoomChoice == "Break Place" && WeaponChoice == "Knife")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Rock");
				Console.WriteLine("White");
				Console.WriteLine("Gun");
				Console.WriteLine("Scarlet");
				Console.WriteLine("Cafiteria");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game13 = Console.ReadLine();
					if (Game13 == "Ice Cream" || Game13 == "Coding" || Game13 == "Green" || Game13 == "Slide")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game13 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game13Answer = Console.ReadLine();
						if (Game13Answer == "MustardBreakKnife")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}

			if (PersonChoice == "Mustard" && RoomChoice == "Coding Room" && WeaponChoice == "Knife")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Rock");
				Console.WriteLine("Green");
				Console.WriteLine("Slide");
				Console.WriteLine("Scarlet");
				Console.WriteLine("Ice Cream");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game14 = Console.ReadLine();
					if (Game14 == "Gun" || Game14 == "White" || Game14 == "Cafiteria" || Game14 == "Break")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game14 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game14Answer = Console.ReadLine();
						if (Game14Answer == "MustardCodingKnife")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}

			if (PersonChoice == "Mustard" && RoomChoice == "Slide" && WeaponChoice == "Knife")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Rock");
				Console.WriteLine("Green");
				Console.WriteLine("Coding");
				Console.WriteLine("Scarlet");
				Console.WriteLine("Ice Cream");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game15 = Console.ReadLine();
					if (Game15 == "Gun" || Game15 == "White" || Game15 == "Cafiteria" || Game15 == "Break")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game15 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game15Answer = Console.ReadLine();
						if (Game15Answer == "MustardSlideKnife")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}

			if (PersonChoice == "Mustard" && RoomChoice == "Cafiteria" && WeaponChoice == "Knife")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Gun");
				Console.WriteLine("White");
				Console.WriteLine("Coding");
				Console.WriteLine("Rock");
				Console.WriteLine("Break");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game16 = Console.ReadLine();
					if (Game16 == "Green" || Game16 == "Scarlet" || Game16 == "Ice Cream" || Game16 == "Slide")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game16 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game16Answer = Console.ReadLine();
						if (Game16Answer == "MustardCafiteriaKnife")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}

			if (PersonChoice == "Scarlet" && RoomChoice == "Break Place" && WeaponChoice == "Gun")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Mustard");
				Console.WriteLine("White");
				Console.WriteLine("Coding");
				Console.WriteLine("Rock");
				Console.WriteLine("Knife");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game17 = Console.ReadLine();
					if (Game17 == "Green" || Game17 == "Cafiteria" || Game17 == "Ice Cream" || Game17 == "Slide")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game17 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game17Answer = Console.ReadLine();
						if (Game17Answer == "ScarletBreakGun")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}

			if (PersonChoice == "Scarlet" && RoomChoice == "Coding Room" && WeaponChoice == "Gun")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Green");
				Console.WriteLine("White");
				Console.WriteLine("Break");
				Console.WriteLine("Ice Cream");
				Console.WriteLine("Knife");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game18 = Console.ReadLine();
					if (Game18 == "Mustard" || Game18 == "Cafiteria" || Game18 == "Rock" || Game18 == "Slide")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game18 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game18Answer = Console.ReadLine();
						if (Game18Answer == "ScarletCodingGun")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}

			if (PersonChoice == "Scarlet" && RoomChoice == "Slide" && WeaponChoice == "Gun")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Green");
				Console.WriteLine("White");
				Console.WriteLine("Mustard");
				Console.WriteLine("Ice Cream");
				Console.WriteLine("Cafiteria");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game19 = Console.ReadLine();
					if (Game19 == "Knife" || Game19 == "Break" || Game19 == "Rock" || Game19 == "Coding")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game19 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game19Answer = Console.ReadLine();
						if (Game19Answer == "ScarletSlideGun")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}

			if (PersonChoice == "Scarlet" && RoomChoice == "Cafiteria" && WeaponChoice == "Gun")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Green");
				Console.WriteLine("Knife");
				Console.WriteLine("Rock");
				Console.WriteLine("Coding");
				Console.WriteLine("Break");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game20 = Console.ReadLine();
					if (Game20 == "Mustard" || Game20 == "White" || Game20 == "Ice Cream" || Game20 == "Slide")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game20 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game20Answer = Console.ReadLine();
						if (Game20Answer == "ScarletCafiteriaGun")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}

			if (PersonChoice == "Scarlet" && RoomChoice == "Slide" && WeaponChoice == "Gun")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Green");
				Console.WriteLine("White");
				Console.WriteLine("Mustard");
				Console.WriteLine("Ice Cream");
				Console.WriteLine("Cafiteria");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game19 = Console.ReadLine();
					if (Game19 == "Knife" || Game19 == "Break" || Game19 == "Rock" || Game19 == "Coding")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game19 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game19Answer = Console.ReadLine();
						if (Game19Answer == "ScarletSlideGun")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}

			if (PersonChoice == "Scarlet" && RoomChoice == "Break Place" && WeaponChoice == "Ice Cream Cone")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Mustard");
				Console.WriteLine("Knife");
				Console.WriteLine("Gun");
				Console.WriteLine("Slide");
				Console.WriteLine("Break");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game21 = Console.ReadLine();
					if (Game21 == "Green" || Game21 == "White" || Game21 == "Rock" || Game21 == "Cafiteria")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game21 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game21Answer = Console.ReadLine();
						if (Game21Answer == "ScarletBreakIceCream")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}

			if (PersonChoice == "Scarlet" && RoomChoice == "Break Place" && WeaponChoice == "Ice Cream Cone")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Mustard");
				Console.WriteLine("Knife");
				Console.WriteLine("Gun");
				Console.WriteLine("Slide");
				Console.WriteLine("Coding");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game21 = Console.ReadLine();
					if (Game21 == "Green" || Game21 == "White" || Game21 == "Rock" || Game21 == "Cafiteria")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game21 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game21Answer = Console.ReadLine();
						if (Game21Answer == "ScarletBreakIceCream")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}

			if (PersonChoice == "Scarlet" && RoomChoice == "Coding Room" && WeaponChoice == "Ice Cream Cone")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Mustard");
				Console.WriteLine("Knife");
				Console.WriteLine("Gun");
				Console.WriteLine("Slide");
				Console.WriteLine("Break");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game22 = Console.ReadLine();
					if (Game22 == "Green" || Game22 == "White" || Game22 == "Rock" || Game22 == "Cafiteria")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game22 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game22Answer = Console.ReadLine();
						if (Game22Answer == "ScarletCodingIceCream")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}

			if (PersonChoice == "Scarlet" && RoomChoice == "Slide" && WeaponChoice == "Ice Cream Cone")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Green");
				Console.WriteLine("Knife");
				Console.WriteLine("Rock");
				Console.WriteLine("Coding");
				Console.WriteLine("Break");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game23 = Console.ReadLine();
					if (Game23 == "Green" || Game23 == "Mustard" || Game23 == "Gun" || Game23 == "Cafiteria")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game23 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game23Answer = Console.ReadLine();
						if (Game23Answer == "ScarletSlideIceCream")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}

			if (PersonChoice == "Scarlet" && RoomChoice == "Cafiteria" && WeaponChoice == "Ice Cream Cone")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Gun");
				Console.WriteLine("Knife");
				Console.WriteLine("Rock");
				Console.WriteLine("Coding");
				Console.WriteLine("Break");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game24 = Console.ReadLine();
					if (Game24 == "Green" || Game24 == "Mustard" || Game24 == "Slide" || Game24 == "White")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game24 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game24Answer = Console.ReadLine();
						if (Game24Answer == "ScarletCafiteriaIceCream")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}

			if (PersonChoice == "Scarlet" && RoomChoice == "Break Place" && WeaponChoice == "Rock")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Gun");
				Console.WriteLine("Knife");
				Console.WriteLine("Ice Cream");
				Console.WriteLine("Coding");
				Console.WriteLine("Cafiteria");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game25 = Console.ReadLine();
					if (Game25 == "Green" || Game25 == "Mustard" || Game25 == "Slide" || Game25 == "White")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game25 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game25Answer = Console.ReadLine();
						if (Game25Answer == "ScarletBreakRock")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}

			if (PersonChoice == "Scarlet" && RoomChoice == "Coding Room" && WeaponChoice == "Rock")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Gun");
				Console.WriteLine("Knife");
				Console.WriteLine("White");
				Console.WriteLine("Green");
				Console.WriteLine("Break");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game26 = Console.ReadLine();
					if (Game26 == "Ice Cream" || Game26 == "Mustard" || Game26 == "Slide" || Game26 == "Cafiteria")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game26 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game26Answer = Console.ReadLine();
						if (Game26Answer == "ScarletCodingRock")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}

			if (PersonChoice == "Scarlet" && RoomChoice == "Slide" && WeaponChoice == "Rock")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Mustard");
				Console.WriteLine("Ice Cream");
				Console.WriteLine("White");
				Console.WriteLine("Green");
				Console.WriteLine("Break");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game27 = Console.ReadLine();
					if (Game27 == "Coding" || Game27 == "Knife" || Game27 == "Gun" || Game27 == "Cafiteria")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game27 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game27Answer = Console.ReadLine();
						if (Game27Answer == "ScarletSlideRock")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}

			if (PersonChoice == "Scarlet" && RoomChoice == "Cafiteria" && WeaponChoice == "Rock")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Mustard");
				Console.WriteLine("Ice Cream");
				Console.WriteLine("Knife");
				Console.WriteLine("Green");
				Console.WriteLine("Break");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game28 = Console.ReadLine();
					if (Game28 == "Coding" || Game28 == "White" || Game28 == "Gun" || Game28 == "Slide")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game28 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game28Answer = Console.ReadLine();
						if (Game28Answer == "ScarletCafiteriaRock")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}

			if (PersonChoice == "Scarlet" && RoomChoice == "Break Place" && WeaponChoice == "Knife")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("White");
				Console.WriteLine("Ice Cream");
				Console.WriteLine("Rock");
				Console.WriteLine("Slide");
				Console.WriteLine("Coding");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game29 = Console.ReadLine();
					if (Game29 == "Cafiteria" || Game29 == "Green" || Game29 == "Gun" || Game29 == "Mustard")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game29 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game29Answer = Console.ReadLine();
						if (Game29Answer == "ScarletBreakKnife")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}

			if (PersonChoice == "Scarlet" && RoomChoice == "Coding Room" && WeaponChoice == "Knife")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("White");
				Console.WriteLine("Ice Cream");
				Console.WriteLine("Mustard");
				Console.WriteLine("Slide");
				Console.WriteLine("Gun");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game30 = Console.ReadLine();
					if (Game30 == "Cafiteria" || Game30 == "Green" || Game30 == "Rock" || Game30 == "Break")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game30 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game30Answer = Console.ReadLine();
						if (Game30Answer == "ScarletCodingKnife")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}

			if (PersonChoice == "Scarlet" && RoomChoice == "Slide" && WeaponChoice == "Knife")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Green");
				Console.WriteLine("Coding");
				Console.WriteLine("Mustard");
				Console.WriteLine("Break");
				Console.WriteLine("Gun");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game31 = Console.ReadLine();
					if (Game31 == "Cafiteria" || Game31 == "White" || Game31 == "Rock" || Game31 == "Ice Cream")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game31 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game31Answer = Console.ReadLine();
						if (Game31Answer == "ScarletSlideKnife")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}

			if (PersonChoice == "Scarlet" && RoomChoice == "Cafiteria" && WeaponChoice == "Knife")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Rock");
				Console.WriteLine("Ice Cream");
				Console.WriteLine("Mustard");
				Console.WriteLine("White");
				Console.WriteLine("Gun");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game32 = Console.ReadLine();
					if (Game32 == "Green" || Game32 == "Slide" || Game32 == "Coding" || Game32 == "Break")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game32 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game32Answer = Console.ReadLine();
						if (Game32Answer == "ScarletCafiteriaKnife")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}

			if (PersonChoice == "White" && RoomChoice == "Break Place" && WeaponChoice == "Gun")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Scarlet");
				Console.WriteLine("Ice Cream");
				Console.WriteLine("Mustard");
				Console.WriteLine("Coding");
				Console.WriteLine("Rock");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game33 = Console.ReadLine();
					if (Game33 == "Green" || Game33 == "Slide" || Game33 == "Knife" || Game33 == "Cafiteria")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game33 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game33Answer = Console.ReadLine();
						if (Game33Answer == "WhiteBreakGun")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}

			if (PersonChoice == "White" && RoomChoice == "Coding Room" && WeaponChoice == "Gun")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Green");
				Console.WriteLine("Cafiteria");
				Console.WriteLine("Mustard");
				Console.WriteLine("Break");
				Console.WriteLine("Knife");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game34 = Console.ReadLine();
					if (Game34 == "Scarlet" || Game34 == "Rock" || Game34 == "Ice Cream" || Game34 == "Slide")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game34 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game34Answer = Console.ReadLine();
						if (Game34Answer == "WhiteCodingGun")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}

			if (PersonChoice == "White" && RoomChoice == "Slide" && WeaponChoice == "Gun")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Green");
				Console.WriteLine("Cafiteria");
				Console.WriteLine("Coding");
				Console.WriteLine("Break");
				Console.WriteLine("Knife");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game35 = Console.ReadLine();
					if (Game35 == "Scarlet" || Game35 == "Rock" || Game35 == "Ice Cream" || Game35 == "Mustard")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game35 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game35Answer = Console.ReadLine();
						if (Game35Answer == "WhiteSlideGun")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}

			if (PersonChoice == "White" && RoomChoice == "Cafiteria" && WeaponChoice == "Gun")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Scarlet");
				Console.WriteLine("Rock");
				Console.WriteLine("Ice Cream");
				Console.WriteLine("Mustard");
				Console.WriteLine("Slide");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game36 = Console.ReadLine();
					if (Game36 == "Green" || Game36 == "Knife" || Game36 == "Coding" || Game36 == "Break")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game36 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game36Answer = Console.ReadLine();
						if (Game36Answer == "WhiteCafiteriaGun")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}

			if (PersonChoice == "White" && RoomChoice == "Break Place" && WeaponChoice == "Ice Cream Cone")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Coding");
				Console.WriteLine("Rock");
				Console.WriteLine("Knife");
				Console.WriteLine("Gun");
				Console.WriteLine("Slide");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game37 = Console.ReadLine();
					if (Game37 == "Green" || Game37 == "Mustard" || Game37 == "Scarlet" || Game37 == "Cafiteria")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game37 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game37Answer = Console.ReadLine();
						if (Game37Answer == "WhiteBreakIceCream")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}

			if (PersonChoice == "White" && RoomChoice == "Coding Room" && WeaponChoice == "Ice Cream Cone")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Break");
				Console.WriteLine("Slide");
				Console.WriteLine("Cafiteria");
				Console.WriteLine("Gun");
				Console.WriteLine("Mustard");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game38 = Console.ReadLine();
					if (Game38 == "Green" || Game38 == "Rock" || Game38 == "Knife" || Game38 == "Scarlet")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game38 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game38Answer = Console.ReadLine();
						if (Game38Answer == "WhiteCodingIceCream")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}

            	if (PersonChoice == "White" && RoomChoice == "Slide" && WeaponChoice == "Ice Cream Cone")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Scarlet");
				Console.WriteLine("Green");
				Console.WriteLine("Cafiteria");
				Console.WriteLine("Gun");
				Console.WriteLine("Knife");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game39 = Console.ReadLine();
					if (Game39 == "Mustard" || Game39 == "Rock" || Game39 == "Break" || Game39 == "Coding")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game39 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game39Answer = Console.ReadLine();
						if (Game39Answer == "WhiteCafiteriaIceCream")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}
            
                  if (PersonChoice == "White" && RoomChoice == "Cafiteria" && WeaponChoice == "Ice Cream Cone")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Mustard");
				Console.WriteLine("Rock");
				Console.WriteLine("Slide");
				Console.WriteLine("Break");
				Console.WriteLine("Coding");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game40 = Console.ReadLine();
					if (Game40 == "Green" || Game40 == "Scarlet" || Game40 == "Knife" || Game40 == "Gun")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game40 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game40Answer = Console.ReadLine();
						if (Game40Answer == "WhiteCafiteriaIceCream")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}
            if (PersonChoice == "White" && RoomChoice == "Break Place" && WeaponChoice == "Rock")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Mustard");
				Console.WriteLine("Ice Cream");
				Console.WriteLine("Slide");
				Console.WriteLine("Cafiteria");
				Console.WriteLine("Coding");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game41 = Console.ReadLine();
					if (Game41 == "Green" || Game41 == "Scarlet" || Game41 == "Knife" || Game41 == "Gun")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game41 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game41Answer = Console.ReadLine();
						if (Game41Answer == "WhiteBreakRock")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}
if (PersonChoice == "White" && RoomChoice == "Coding Room" && WeaponChoice == "Rock")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Scarlet");
				Console.WriteLine("Ice Cream");
				Console.WriteLine("Gun");
				Console.WriteLine("Green");
				Console.WriteLine("Cafiteria");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game42 = Console.ReadLine();
					if (Game42 == "Mustard" || Game42 == "Knife" || Game42 == "Break" || Game42 == "Slide")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game42 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game42Answer = Console.ReadLine();
						if (Game42Answer == "WhiteCodingRock")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}
            if (PersonChoice == "White" && RoomChoice == "Slide" && WeaponChoice == "Rock")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Scarlet");
				Console.WriteLine("Green");
				Console.WriteLine("Mustard");
				Console.WriteLine("Cafiteria");
				Console.WriteLine("Coding");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game43 = Console.ReadLine();
					if (Game43 == "Knife" || Game43 == "Ice Cream" || Game43 == "Gun" || Game43 == "Break")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game43 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game43Answer = Console.ReadLine();
						if (Game43Answer == "WhiteSlideRock")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}
               if (PersonChoice == "White" && RoomChoice == "Cafiteria" && WeaponChoice == "Rock")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Scarlet");
				Console.WriteLine("Green");
				Console.WriteLine("Mustard");
				Console.WriteLine("Slide");
				Console.WriteLine("Coding");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game44 = Console.ReadLine();
					if (Game44 == "Knife" || Game44 == "Ice Cream" || Game44 == "Gun" || Game44 == "Break")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game44 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game44Answer = Console.ReadLine();
						if (Game44Answer == "WhiteSlideRock")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}
             if (PersonChoice == "White" && RoomChoice == "Break Place" && WeaponChoice == "Knife")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Scarlet");
				Console.WriteLine("Green");
				Console.WriteLine("Mustard");
				Console.WriteLine("Slide");
				Console.WriteLine("Coding");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game45 = Console.ReadLine();
					if (Game45 == "Rock" || Game45 == "Ice Cream" || Game45 == "Gun" || Game45 == "Cafiteria")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game45 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game45Answer = Console.ReadLine();
						if (Game45Answer == "WhiteBreakKnife")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}
             if (PersonChoice == "White" && RoomChoice == "Coding Room" && WeaponChoice == "Knife")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Rock");
				Console.WriteLine("Green");
				Console.WriteLine("Ice Cream");
				Console.WriteLine("Slide");
				Console.WriteLine("Break");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game46 = Console.ReadLine();
					if (Game46 == "Mustard" || Game46 == "Scarlet" || Game46 == "Gun" || Game46 == "Cafiteria")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game46 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game46Answer = Console.ReadLine();
						if (Game46Answer == "WhiteCodingKnife")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}
              if (PersonChoice == "White" && RoomChoice == "Slide" && WeaponChoice == "Knife")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Rock");
				Console.WriteLine("Green");
				Console.WriteLine("Scarlet");
				Console.WriteLine("Coding");
				Console.WriteLine("Cafiteria");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game47 = Console.ReadLine();
					if (Game47 == "Mustard" || Game47 == "Ice Cream" || Game47 == "Gun" || Game47 == "Break")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game47 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game47Answer = Console.ReadLine();
						if (Game47Answer == "WhiteSlideKnife")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}
            if (PersonChoice == "White" && RoomChoice == "Cafiteria" && WeaponChoice == "Knife")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Ice Cream");
				Console.WriteLine("Green");
				Console.WriteLine("Gun");
				Console.WriteLine("Coding");
				Console.WriteLine("Mustard");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game48 = Console.ReadLine();
					if (Game48 == "Scarlet" || Game48 == "Slide" || Game48 == "Rock" || Game48 == "Break")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game48 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game48Answer = Console.ReadLine();
						if (Game48Answer == "WhiteCafiteriaKnife")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}
             if (PersonChoice == "Green" && RoomChoice == "Break Place" && WeaponChoice == "Gun")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Ice Cream");
				Console.WriteLine("White");
				Console.WriteLine("Knife");
				Console.WriteLine("Coding");
				Console.WriteLine("Mustard");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game49 = Console.ReadLine();
					if (Game49 == "Scarlet" || Game49 == "Slide" || Game49 == "Rock" || Game49 == "Cafiteria")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game49 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game49Answer = Console.ReadLine();
						if (Game49Answer == "GreenBreakGun")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}
            if (PersonChoice == "Green" && RoomChoice == "Coding Room" && WeaponChoice == "Gun")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Ice Cream");
				Console.WriteLine("White");
				Console.WriteLine("Knife");
				Console.WriteLine("Rock");
				Console.WriteLine("Mustard");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game50 = Console.ReadLine();
					if (Game50 == "Scarlet" || Game50 == "Slide" || Game50 == "Break" || Game50 == "Cafiteria")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game50 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game50Answer = Console.ReadLine();
						if (Game50Answer == "GreenCodingGun")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}
             if (PersonChoice == "Green" && RoomChoice == "Slide" && WeaponChoice == "Gun")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Break");
				Console.WriteLine("White");
				Console.WriteLine("Cafiteria");
				Console.WriteLine("Coding");
				Console.WriteLine("Mustard");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game51 = Console.ReadLine();
					if (Game51 == "Scarlet" || Game51 == "Rock" || Game51 == "Knife" || Game51 == "Ice Cream")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game51 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game51Answer = Console.ReadLine();
						if (Game51Answer == "GreenSlideGun")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}
             if (PersonChoice == "Green" && RoomChoice == "Cafiteria" && WeaponChoice == "Gun")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Break");
				Console.WriteLine("White");
				Console.WriteLine("Slide");
				Console.WriteLine("Coding");
				Console.WriteLine("Mustard");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game52 = Console.ReadLine();
					if (Game52 == "Scarlet" || Game52 == "Rock" || Game52 == "Knife" || Game52 == "Ice Cream")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game52 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game52Answer = Console.ReadLine();
						if (Game52Answer == "GreenCafiteriaGun")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}
            if (PersonChoice == "Green" && RoomChoice == "Break Place" && WeaponChoice == "Ice Cream Cone")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Cafiteria");
				Console.WriteLine("White");
				Console.WriteLine("Slide");
				Console.WriteLine("Coding");
				Console.WriteLine("Mustard");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game53 = Console.ReadLine();
					if (Game53 == "Scarlet" || Game53 == "Rock" || Game53 == "Knife" || Game53 == "Gun")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game53 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game53Answer = Console.ReadLine();
						if (Game53Answer == "GreenBreakIceCream")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}
            if (PersonChoice == "Green" && RoomChoice == "Coding Room" && WeaponChoice == "Ice Cream Cone")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Rock");
				Console.WriteLine("Scarlet");
				Console.WriteLine("Knife");
				Console.WriteLine("Gun");
				Console.WriteLine("Mustard");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game54 = Console.ReadLine();
					if (Game54 == "White" || Game54 == "Break" || Game54 == "Cafiteria" || Game54 == "Slide")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game54 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game54Answer = Console.ReadLine();
						if (Game54Answer == "GreenCodingIceCream")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}
             if (PersonChoice == "Green" && RoomChoice == "Slide" && WeaponChoice == "Ice Cream Cone")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Rock");
				Console.WriteLine("Scarlet");
				Console.WriteLine("Knife");
				Console.WriteLine("Gun");
				Console.WriteLine("Mustard");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game55 = Console.ReadLine();
					if (Game55 == "White" || Game55 == "Break" || Game55 == "Cafiteria" || Game55 == "Coding")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game55 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game55Answer = Console.ReadLine();
						if (Game55Answer == "GreenSlideIceCream")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}
                        if (PersonChoice == "Green" && RoomChoice == "Cafiteria" && WeaponChoice == "Ice Cream Cone")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Rock");
				Console.WriteLine("Break");
				Console.WriteLine("White");
				Console.WriteLine("Coding");
				Console.WriteLine("Mustard");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game56 = Console.ReadLine();
					if (Game56 == "Scarlet" || Game56 == "Knife" || Game56 == "Slide" || Game56 == "Gun")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game56 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game56Answer = Console.ReadLine();
						if (Game56Answer == "GreenSlideIceCream")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}
                 if (PersonChoice == "Green" && RoomChoice == "Break Place" && WeaponChoice == "Rock")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Ice Cream");
				Console.WriteLine("Cafiteria");
				Console.WriteLine("White");
				Console.WriteLine("Coding");
				Console.WriteLine("Mustard");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game57 = Console.ReadLine();
					if (Game57 == "Scarlet" || Game57 == "Knife" || Game57 == "Slide" || Game57 == "Gun")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game57 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game57Answer = Console.ReadLine();
						if (Game57Answer == "GreenBreakRock")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}
            if (PersonChoice == "Green" && RoomChoice == "Coding Room" && WeaponChoice == "Rock")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Ice Cream");
				Console.WriteLine("Cafiteria");
				Console.WriteLine("White");
				Console.WriteLine("Break");
				Console.WriteLine("Scarlet");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game58 = Console.ReadLine();
					if (Game58 == "Mustard" || Game58 == "Knife" || Game58 == "Slide" || Game58 == "Gun")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game58 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game58Answer = Console.ReadLine();
						if (Game58Answer == "GreenCodingRock")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}
                  if (PersonChoice == "Green" && RoomChoice == "Slide" && WeaponChoice == "Rock")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Ice Cream");
				Console.WriteLine("Knife");
				Console.WriteLine("White");
				Console.WriteLine("Mustard");
				Console.WriteLine("Scarlet");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game59 = Console.ReadLine();
					if (Game59 == "Cafiteria" || Game59 == "Break" || Game59 == "Coding" || Game59 == "Gun")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game59 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game59Answer = Console.ReadLine();
						if (Game59Answer == "GreenSlideRock")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}
               if (PersonChoice == "Green" && RoomChoice == "Cafiteria" && WeaponChoice == "Rock")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Ice Cream");
				Console.WriteLine("Knife");
				Console.WriteLine("White");
				Console.WriteLine("Mustard");
				Console.WriteLine("Scarlet");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game60 = Console.ReadLine();
					if (Game60 == "Slide" || Game60 == "Break" || Game60 == "Coding" || Game60 == "Gun")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game60 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game60Answer = Console.ReadLine();
						if (Game60Answer == "GreenCafiteriaRock")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}
             if (PersonChoice == "Green" && RoomChoice == "Break Place" && WeaponChoice == "Knife")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Ice Cream");
				Console.WriteLine("Rock");
				Console.WriteLine("White");
				Console.WriteLine("Mustard");
				Console.WriteLine("Scarlet");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game61 = Console.ReadLine();
					if (Game61 == "Slide" || Game61 == "Cafiteria" || Game61 == "Coding" || Game61 == "Gun")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game61 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game61Answer = Console.ReadLine();
						if (Game61Answer == "GreenBreakKnife")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}
             if (PersonChoice == "Green" && RoomChoice == "Coding Room" && WeaponChoice == "Knife")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Slide");
				Console.WriteLine("Cafiteria");
				Console.WriteLine("Coding");
				Console.WriteLine("Gun");
				Console.WriteLine("Scarlet");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game62 = Console.ReadLine();
					if (Game62 == "White" || Game62 == "Mustard" || Game62 == "Rock" || Game62 == "Ice Cream")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game62 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game62Answer = Console.ReadLine();
						if (Game62Answer == "GreenCodingKnife")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}
                if (PersonChoice == "Green" && RoomChoice == "Slide" && WeaponChoice == "Knife")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("Slide");
				Console.WriteLine("Cafiteria");
				Console.WriteLine("Slide");
				Console.WriteLine("Gun");
				Console.WriteLine("Scarlet");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game63 = Console.ReadLine();
					if (Game63 == "White" || Game63 == "Mustard" || Game63 == "Rock" || Game63 == "Ice Cream")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game63 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game63Answer = Console.ReadLine();
						if (Game63Answer == "GreenSlideKnife")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}
             if (PersonChoice == "Green" && RoomChoice == "Cafiteria" && WeaponChoice == "Knife")
			{
				Console.WriteLine("The goal of the game is to guess who, what, and how the bug happened. You have certain clues saying what was NOT involved in the bug case. I also have clues on what was not involved. Your job is to ask me questions to see if i have any clues on the mystery. If I do, then i will say, YES, and that means that clue wasn't involved in the case. If I say, NO, and you don't have that clue either, that means it was part of the mystery and you have figured out who, what, or where the clue took place. If you find all three, it means you know all the clues and you can guess to win. But you need to solve this before I do.");
				Console.WriteLine("Here are your clues:");
				Console.WriteLine("White");
				Console.WriteLine("Mustard");
				Console.WriteLine("Slide");
				Console.WriteLine("Ice Cream");
				Console.WriteLine("Scarlet");
				Console.WriteLine("");
				Console.WriteLine("Now it is time for you to ask me questions. If you type in nonsense I will say, NO, and you will have less chances of beating me. When you think you have found the answer type: Final, and type in your guess. Here is your guide for what you can type to ask me questions.");
				while (i < 4)
				{
					Console.WriteLine("for the people: Green, Scarlet, Mustard, White.");
					Console.WriteLine("for the weapon: Gun, Rock, Knife, Ice Cream.");
					Console.WriteLine("for the room: Coding, Cafiteria, Break, Slide.");
					Console.WriteLine("What clue do you want?");
					string Game64 = Console.ReadLine();
					if (Game64 == "Rock" || Game64 == "Gun" || Game64 == "Coding" || Game64 == "Break")
					{
						Console.WriteLine("YES");
						i++;
					}
					else if (Game64 == "Final")
					{
						Console.WriteLine("Type in your guess like this: ScarletSlideRock. First the person, then place, then weapon. ALL WORDS MUST BE ATTACHED ICLUDING IceCream!!");
						string Game64Answer = Console.ReadLine();
						if (Game64Answer == "GreenSlideKnife")
						{
							Console.WriteLine("You did it! You Won!");
							break;
						}
						else
						{
							Console.WriteLine("You Lose...");
							break;
						}
					}
					else
					{
						Console.WriteLine("NO");
						i++;
					}

					if (i == 4)
					{
						Console.WriteLine("YOU LOSE...");
						break;
					}
				}
			}
		}
	}

public static bool greeting(string name){
    Console.WriteLine("Hello " + name + ". Welcome to CLUE! There is a bug in Hyland. It was planted by either Green, Scarlet, Mustard, or White. It is your job to guess who it was. in what room it was planted in and what weapon they used to protect themselves. The weapon could have been a gun, a rock, a knife, or an ice cream cone. The room could of been the coding room, the cafiteria, the breakplace, or in the slide. Are you Ready?");
	string PlayedBefore = Console.ReadLine();
    return PlayedBefore == "yes" || PlayedBefore == "Yes";
    
}



}

