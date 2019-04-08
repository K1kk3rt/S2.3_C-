using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave2
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintHeader("Popolon");
            GameCharacter popolon = new CharacterA("Popolon");
            popolon.Attack();
            popolon.Defend();

            PrintHeader("Aphrodite");
            GameCharacter aphrodite = new CharacterB("Aphrodite");
            aphrodite.Attack();
            aphrodite.Defend();

            PrintHeader("changed behaviour of Aphrodite");
            aphrodite.AttackBehaviour = new StrongAttack();
            aphrodite.DefendBehaviour = new GoldenShield();
            aphrodite.Attack();
            aphrodite.Defend();

            Console.ReadKey();
        }
        static void PrintHeader(string header) {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(header);
            Console.ResetColor();
        }
    }
}
