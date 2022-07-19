using Class_Construct_Exercise.Src;
using System;

namespace Class_Construct_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Pokemon pokemon1 = new Pokemon("Kyurem", "Pressure", "Substitute", "Ice Beam", "Earth Power", "Roost");
            Pokemon pokemon2 = new Pokemon("Landorus-Therian", "Intimidate", "Earthquake", "U-turn", "Stone Edge", "Defog");
            Pokemon pokemon3 = new Pokemon("Kartana", "Beast Boost", "Swords Dance", "Leaf Blade", "Knock Off", "Sacred Sword");
            Pokemon pokemon4 = new Pokemon("Kommo-o", "Bulletproof", "Clanging Scales", "Close Combat", "Clangorous Soul", "Flamethrower");


            Console.WriteLine("----------------------------");
            Console.WriteLine("Catarina's Pokemon Simulator");
            //Console.WriteLine("Type 1 to see the available Pokémons or 2 to end the program");
            Console.WriteLine("----------------------------");
            //int ligar = int.Parse(Console.ReadLine());

            
                    Console.WriteLine(pokemon1.ToString());
                    Console.WriteLine("----------------------");
                    Console.WriteLine(pokemon2.ToString());
                    Console.WriteLine("----------------------");
                    Console.WriteLine(pokemon3.ToString());
                    Console.WriteLine("----------------------");
                    Console.WriteLine(pokemon4.ToString());
                    Console.WriteLine("----------------------");

                    pokemon1.move2();
                    pokemon2.move1();
                    pokemon3.move2();
                    pokemon4.move1();
                    Console.WriteLine("----------------------");
                    
               

            
        }

    }
}
