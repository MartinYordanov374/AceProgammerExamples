using System;
using System.Linq;
using System.Collections.Generic;
namespace SeaChess
{ 
    class Program
    {
        public static void Main()
        {
            // между кръглите скоби имаме условие. Може да прочетем конструкцията така - Ако 1 е равно на 1, изпиши "Условието е изпълнено, иначе изпиши "Условието не е изпълнено"

            if( 1 == 1)
            {
                Console.WriteLine("Условието е изпълнено"); // всичко между къдравите скоби {} се нарича тяло на конструкцията
            }
            else
            {
                Console.WriteLine("Условието не е изпълнено");
            }


            // Тук ползваме логически оператор И (&&). Имаме две условие и понеже сме ползвали &&, трябва и двете условия да бъдат изпълнени ако искаме да се изпише текста в тялото на конструкцията.
            
            if( 1 == 1 && 2 == 2) 
            {
                Console.WriteLine("Условието е изпълнено"); 
            }

            // Тук ползваме логически оператор Или (||) Имаме две условие и понеже сме ползвали ||, трябва поне едно от двете условия да бъде изпълненп ако искаме да се изпише текста в тялото на конструкцията.
            if( 1 == 1 || 2 != 2)  // когато имаме != това означава "не е равно"
            {
                Console.WriteLine("Условието е изпълнено"); 
            }

            // така четем стрингове от конзолата
            string color = Console.ReadLine();
            // това е Switch конструкцията. Тя работи като if-else конструкцията. В кръглите скоби на Switch слагаме променливата, с която искаме да правим проверките.
            switch (color)
            {
                // тук проверяваме дали цветът ни е червен, ако е ще се изпише съобщението по-долу и работата по конструкцията ще приключи. Ако не е програмата ще премине на следващия "кейс"
                case "Red":{
                    Console.WriteLine("Your color is red");
                    break;
                }
                // тук проверяваме дали цветът ни е зелен, ако е ще се изпише съобщението по-долу и работата по конструкцията ще приключи. Ако не е програмата ще премине на следващия "кейс"

                case "Green":{
                    Console.WriteLine("Your color is green");
                    break;
                }
                // тук проверяваме дали цветът ни е син, ако е ще се изпише съобщението по-долу и работата по конструкцията ще приключи. Ако не е програмата ще премине на следващия "кейс"

                case "Blue":{
                    Console.WriteLine("Your color is blue");
                    break;
                }

                // Ако нито един от "кейсовете" или случаите, които сме задали не се е изпълнил, то програмата ще стигне до частта по-долу. Тя е еквивалент на else в if-else конструкциите.
                // Изпълянва се когато нито един от кейсовете, които сме задали не е изпълнен.

                default:
                    Console.WriteLine("Your color is not present");
                    break;
            }
            
        }
    }
}