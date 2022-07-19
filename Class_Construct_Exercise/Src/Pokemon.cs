using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Construct_Exercise.Src
{
    internal class Pokemon
    {
        public string name { get; set; }
        public string ability  { get; set; }
        public string skill1 { get; set; }
        public string skill2 { get; set; }
        public string skill3 { get; set; }
        public string skill4 { get; set; }

        public Pokemon()
        {

        }

        public Pokemon(string aName, string aAbility, string aSkill1, string aSkill2, string aSkill3, string aSkill4)
        {
            name = aName;
            ability = aAbility;
            skill1 = aSkill1;
            skill2 = aSkill2;
            skill3 = aSkill3;
            skill4 = aSkill4;
        }
        public void move1()
        {
            Console.WriteLine($"{name} used {skill1}!");
        }
        public void move2()
        {
            Console.WriteLine($"{name} used {skill2}!");
        }
        public void move3()
        {
            Console.WriteLine($"{name} used {skill3}!");
        }
        public void move4()
        {
            Console.WriteLine($"{name} used {skill4}!");
        }
        public void spacing()
        {
            Console.WriteLine("----------------------");
        }
        //Utilizei ToString ao invés disto
        //public string moveset()
        //{
        //    return $" - Nome: {name}\n - Ability: {ability}\n - Skill 1: {skill1}\n - Skill 2: {skill2}\n - Skill 3: {skill3}\n - Skill 4: {skill4}\n";
        //}
        public override string ToString()
        {
            return $" - Nome: {name}\n - Ability: {ability}\n - Skill 1: {skill1}\n - Skill 2: {skill2}\n - Skill 3: {skill3}\n - Skill 4: {skill4}\n";
        }
    }
}
