using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        List<int> abilityScores = new List<int>();

        //Första 
        List<int> rolls = new List<int>();

        int rollOne = random.Next(1, 7);
        int rollTwo = random.Next(1, 7);
        int rollThree = random.Next(1, 7);
        int rollFour = random.Next(1, 7);

        rolls.Add(rollOne);
        rolls.Add(rollTwo);
        rolls.Add(rollThree);
        rolls.Add(rollFour);

        rolls.Sort();
        
        int totalRolls = rolls[1] + rolls[2] + rolls[3];
        Console.WriteLine("You roll: " + String.Join(", ", rolls) + ". Ability Score: " + totalRolls);
        abilityScores.Add(totalRolls);

        //Andra
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

        //Tredje
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

        //Fjärde
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

        //Femte
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

        //Sjätte
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


        Console.WriteLine("Ability Scores: " + String.Join(", ", abilityScores));
    }
}