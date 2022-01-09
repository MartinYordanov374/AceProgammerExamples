using System;
using System.Linq;
using System.Collections.Generic;
namespace SeaChess
{ 
    class Program
    {
        public static void Main()
        {
               
            var FirstExampleVar = "string"; 
            // тук променливата ще приеме тип string, защото след равното ( оператор за присвояване ) имаме string (текст);

            var SecondExampleVar = 1; // тук променливата ще приеме тип int,  защото след равното ( оператор за присвояване ) имаме int.

            var ThirdExampleVar = 2.5; // тук променливата ще приеме тип double,  защото след равното ( оператор за присвояване ) имаме double.

            var FourthExampleVar = 1.0; // тук променливата ще приеме тип double,  защото след равното ( оператор за присвояване ) имаме double.

            var FifthExampleVar = 2.0d; // тук променливата ще приеме тип double,  защото след равното ( оператор за присвояване ) имаме double.

            var SixthExampleVar = 2.7f; // тук променливата ще приеме тип float,  защото след равното ( оператор за присвояване ) имаме float.

            var SeventhExampleVar = false; // тук променливата ще приеме тип bool,  защото след равното ( оператор за присвояване ) имаме bool.
            
            var EightExampleVar = '0'; // тук променливата ще приеме тип char,  защото след равното ( оператор за присвояване ) имаме bool.

            // тук променливите ще приемат тип int, защото сме ги дефинирали като такива.
            int FirstExampleInt = 1;
            int SecondExampleInt = -230;
            
            // тук променливите ще приемат тип double, защото сме ги дефинирали като такива.
            double FirstExampleDouble = 2.0d; // слагането на буквата накрая, не е задължително.
            double SecondExampleDouble = 2; // това всъшност е 2.00 или 2.00d

            // тук променливите ще приемат тип string, защото сме ги дефинирали като такива.

            string FirstExampleString = "Example text"; // Стринговете задължително са между две двойни кавички

            string SecondExampleString = "1"; // цифрите и числата в стринг, си остават текст. Не се зачитат за числа, за целта те трябва да бъдат преобразувани към желания тип данни. Пример има по-надолу във файла.
            
            string ThirdExampleString = string.Empty; // Не е забранено стринговете да са празни.

            
            // тук променливите ще приемат тип char, защото сме ги дефинирали като такива.

            char FirstExampleChar = 'a'; 
            // char винаги са между две единични кавички.
            
            // Не може да имаме празен char.

            // тук променливите ще приемат тип bool, защото сме ги дефинирали като такива.

            bool FirstExampleBool = true; 
            // bool винаги e или true или falseue или false
            

        }
    }
}
