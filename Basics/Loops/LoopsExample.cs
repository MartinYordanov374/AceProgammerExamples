using System;
using System.Linq;
using System.Collections.Generic;
namespace SeaChess
{ 
    class Program
    {
        public static void Main()
        {
            // това е цикъл for. Първо му задаваме итератор със стойност 0, на име iterator ( int iterator = 0 )
            // след това задаваме условие. Докато това условие е валидно, цикълът ще се изпълнява (в този случай условието е докато променливата iterator е по-малка от 10. 
            // След като това бъде изпълнено, т.е. след като iterator е по-голямо или равно на 10 цикълът приключва. )
            // накрая описваме и как искаме да се увеличава стойността на итератора (ако сложим ++ ще имаме увеличение с 1 след всяко заъвртане на цикъла)
            for(int iterator = 0; iterator < 10; iterator++)
            {
                Console.WriteLine(iterator);
            }

            string[] names = {"John", "Kay", "Joe"}; //това е масив( последователност ) от стрингове или "колекция от данни"

            // В този foreach цикъл създаваме променлива name, която на всяко завъртане на цикъла примема стойностите от масива names и ги изписва на екрана. 
            // Първият път ще се изпише John, след това Kay и накрая Joe
            foreach(string name in names) 
            {
                Console.WriteLine(name);
            }
            
            string text = "Test";

            // Цикълът по-долу никога няма да се изпълни понеже условието не е изпълнено и веднъж 
            // (това може да се избегне ако ползваме цикъл do-while, той първо се иузпълнява и после се проверява условието.)
            // АКо искаме този цикъл да се изпълни трябва да порменим нещо, така че условието да е изпълнено. Може да променим == на != и така ще навлезем в безкраен цикъл, т.е. условието винаги ще е изплънено и цикъла няма да приключи.
            while(text == "Test text")
            {
                System.Console.WriteLine("This is the while loop working");
            }


        }
    }
}