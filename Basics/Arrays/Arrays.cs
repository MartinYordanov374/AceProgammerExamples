using System;

namespace Arrays {
    class Program
    {
        public static void Main()
        {
            // тук създаваме масив от целочислен тип данни с име IntArray и размер 7. ю
            // Това означава, че той ще има точно 7 елемента, които ще са празни. 
            // Представете си кутия бонбони със само 7 (ПРАЗНИ) слота за бонбони. Така ще изглежда нашият масив
            
            // Масивите може да са от всеки тип данни.

            int[] IntArray = new int[7]; 

            // Можем да задаваме стойност на масива, като му подадем индекс и стойност за съответния индекс.
            // Индексите в масивите се броят от 0, т.е. първият елемент е нулев елемент, вторият е първи, третият е втори и т.н.
            // достъпването на елементите в масивите става така:

            IntArray[0] = 4;
            //Първо пишем името на масива, след това слагаме съответния индекс ( в примера индексът е 0 ), върху който искаме да работим и му присвояваме стойност (в нашият случай това е 4)
            // Така елементът на нулев индекс има стойност 4.
            // Типът данни, който присвояваме трябва да съвпада с типа данни на масива, върху който работим.

            // Тук създаваме масив от тип данни стринг с име NamesArray, но не му задаваме дължина.
            // Вместо да задаваме дължина на масива, ние му задаваме брой елементи, които ще държи в себе си.

            string[] NamesArray = new string[]{"Peter", "George", "John"};         
        }
    }
}
