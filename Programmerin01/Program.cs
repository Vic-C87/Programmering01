using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<String> heroes = new List<String>() { "Jazlyn", "Theron", "Dayana", "Rolando" };

        SimulateCombat(heroes, "Orc", DiceRoll(2,8,6), 10);
        SimulateCombat(heroes, "Azer", DiceRoll(6,8,12), 18);
        SimulateCombat(heroes, "Troll", DiceRoll(8,10,40), 16);

        if (heroes.Count() > 1) 
        {
            Console.WriteLine("After three grueling battles, the heroes " + String.Join(", ", heroes) + " return from the dungeons to live another day.");
        }
        else if (heroes.Count() == 1) 
        {
            Console.WriteLine("After three grueling battles, the hero " + heroes[0] + " return from the dungeons to live another day.");

        }
    }

    static int DiceRoll(int numberOfRolls, int diceSides, int fixedBonus = 0)
    {
        Random random = new Random();
        int roll = 0;
        for (int i = 0; i < numberOfRolls; i++) 
        {
            roll += random.Next(1, ++diceSides);
        }

        roll += fixedBonus;

        return roll;
    }

    static void SimulateCombat(List<string> someHeroes, string aMonsterName, int someMonsterHP, int aSavingThrowDC)
    {
        Random random = new Random();
        
        Console.WriteLine("Fighters " + String.Join(", ", someHeroes) + " descend into the dungeon.");

        Console.WriteLine(aMonsterName + " with " + someMonsterHP + " HP appears!");
        while (someMonsterHP > 0 && someHeroes.Count > 0)
        {
            for (int i = 0; i < someHeroes.Count; i++)
            {
                int damage = DiceRoll(2, 6);

                someMonsterHP -= damage;

                if (someMonsterHP < 0)
                {
                    someMonsterHP = 0;
                }

                Console.WriteLine(someHeroes[i] + " hits the " + aMonsterName + " for " + damage + " damage. " + aMonsterName + " has " + someMonsterHP + " HP left.");

                if (someMonsterHP <= 0)
                {
                    break;
                }
            }

            if (someMonsterHP > 0)
            {
                int basiliskAttackIndex = random.Next(0, someHeroes.Count);

                int savingRoll = DiceRoll(1, 20);

                savingRoll += 3;

                bool isSaved = savingRoll >= aSavingThrowDC;

                Console.WriteLine("The " + aMonsterName + " attacks " + someHeroes[basiliskAttackIndex] + "!");


                if (isSaved)
                {
                    Console.WriteLine(someHeroes[basiliskAttackIndex] + " rolls a " + savingRoll + " and is saved from the attack.");
                }
                else
                {
                    Console.WriteLine(someHeroes[basiliskAttackIndex] + " rolls a " + savingRoll + " and fails to be saved. " + someHeroes[basiliskAttackIndex] + " is turned into stone.");
                    someHeroes.RemoveAt(basiliskAttackIndex);
                }
            }
        }
        if (!someHeroes.Any())
        {
            Console.WriteLine("The party has failed and the " + aMonsterName + " continues to attack unsuspecting adventurers.");
        }
        else
        {
            Console.WriteLine("The " + aMonsterName + " collapses and the heroes celebrate their victory!");
        }
    }

    static void MissionFour()
    {
        Random random = new Random();
        int basiliskHP = 0;

        for (int i = 0; i < 8; i++)
        {
            basiliskHP += random.Next(1, 9);
        }

        basiliskHP += 16;
        int difficultyClass = 12;

        List<String> heroes = new List<String>() { "Jazlyn", "Theron", "Dayana", "Rolando" };
        Console.WriteLine("Fighters " + String.Join(", ", heroes) + " descend into the dungeon.");

        Console.WriteLine("A basilisk with " + basiliskHP + " HP appears!");
        while (basiliskHP > 0 && heroes.Count > 0)
        {
            for (int i = 0; i < heroes.Count; i++)
            {
                int damage = random.Next(1, 5);

                basiliskHP -= damage;

                if (basiliskHP < 0)
                {
                    basiliskHP = 0;
                }

                Console.WriteLine(heroes[i] + " hits the basilisk for " + damage + " damage. Basilisk has " + basiliskHP + " HP left.");

                if (basiliskHP <= 0)
                {
                    break;
                }
            }

            if (basiliskHP > 0)
            {
                int basiliskAttackIndex = random.Next(0, heroes.Count);

                int savingRoll = random.Next(1, 21);

                savingRoll += 3;

                bool isSaved = savingRoll >= difficultyClass;

                Console.WriteLine("The basilisk uses petrifying gaze on " + heroes[basiliskAttackIndex] + "!");


                if (isSaved)
                {
                    Console.WriteLine(heroes[basiliskAttackIndex] + " rolls a " + savingRoll + " and is saved from the attack.");
                }
                else
                {
                    Console.WriteLine(heroes[basiliskAttackIndex] + " rolls a " + savingRoll + " and fails to be saved. " + heroes[basiliskAttackIndex] + " is turned into stone.");
                    heroes.RemoveAt(basiliskAttackIndex);
                }
            }
        }
        if (!heroes.Any())
        {
            Console.WriteLine("The party has failed and the basilisk continues to turn unsuspecting adventurers to stone.");
        }
        else
        {
            Console.WriteLine("The basilisk collapses and the heroes celebrate their victory!");
        }
    }

    static void MissionThree()
    {
        List<String> heroes = new List<String>() { "Jazlyn", "Theron", "Dayana", "Rolando" };
        Console.WriteLine("Fighters " + String.Join(", ", heroes) + " descend into the dungeon.");

        Random random = new Random();

        int basiliskHP = 0;

        for (int i = 0; i < 8; i++)
        {
            basiliskHP += random.Next(1, 9);
        }

        basiliskHP += 16;

        Console.WriteLine("A basilisk with " + basiliskHP + " HP appears!");
        while (basiliskHP > 0)
        {
            for (int i = 0; i < heroes.Count; i++)
            {
                int damage = 0;
                damage += random.Next(1, 7);
                damage += random.Next(1, 7);

                basiliskHP -= damage;

                if (basiliskHP < 0)
                {
                    basiliskHP = 0;
                }

                Console.WriteLine(heroes[i] + " hits the basilisk for " + damage + " damage. Basilisk has " + basiliskHP + " HP left.");

                if (basiliskHP <= 0)
                {
                    break;
                }
            }
        }
    }

    static void MissionTwo()
    {
        List<String> heroes = new List<String>() { "Jazlyn", "Theron", "Dayana", "Rolando" };
        Console.WriteLine("Fighters " + String.Join(", ", heroes) + " descend into the dungeon.");

        Random random = new Random();

        int basiliskHP = 0;

        for (int i = 0; i < 8; i++)
        {
            basiliskHP += random.Next(1, 9);
        }

        basiliskHP += 16;

        Console.WriteLine("A basilisk with " + basiliskHP + " HP appears!");

        for (int i = 0; i < heroes.Count; i++)
        {
            int damage = 0;
            damage += random.Next(1, 7);
            damage += random.Next(1, 7);

            basiliskHP -= damage;

            Console.WriteLine(heroes[i] + " hits the basilisk for " + damage + " damage. Basilisk has " + basiliskHP + " HP left.");
        }
    }

    static void MissionOne()
    {
        //Deklarationer
        Random random = new Random();
        List<int> abilityScores = new List<int>();

        List<int> rolls;
        int rollOne;
        int rollTwo;
        int rollThree;
        int rollFour;

        int totalRolls;
        //Loop
        for (int i = 0; i < 6; i++)
        {
            rolls = new List<int>();

            rollOne = random.Next(1, 7);
            rollTwo = random.Next(1, 7);
            rollThree = random.Next(1, 7);
            rollFour = random.Next(1, 7);

            rolls.Add(rollOne);
            rolls.Add(rollTwo);
            rolls.Add(rollThree);
            rolls.Add(rollFour);

            rolls.Sort();

            totalRolls = rolls[1] + rolls[2] + rolls[3];

            Console.WriteLine("You roll: " + String.Join(", ", rolls) + ". Ability Score: " + totalRolls);
            abilityScores.Add(totalRolls);
        }
        Console.WriteLine("Ability scores: " + String.Join(", ", abilityScores));
    }
}