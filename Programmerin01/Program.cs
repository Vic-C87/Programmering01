using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
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
        for (int i = 0; i <6; i++)
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

        
    }
}