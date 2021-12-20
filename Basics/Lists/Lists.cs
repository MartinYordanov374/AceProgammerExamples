using System;

// Този ред е задължителен, когато работим с List
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        public static void Main()
        {

            //  Така се създава лист.
            //  List < тип данни > ИмеНаЛист = new List < тип данни >();

            List < string > NamesList = new List < int > ();

            // Можем да добавяме в List, по следния начин:
            NamesList.Add("George");
            NamesList.Add("John");
            NamesList.Add("Edgar");

            // Можем да махаме от лист, по следния начин:
            NamesList.Remove("George");
            // Така премахваме само първият срещнат елемент със стойност George. Ако имаме George два пъти, само първият ще бъде премахнат. 


            // Ако искаме да премахваме елементи по индекс от лист, става така:
            NamesList.RemoveAt(1); // Този ред ще премахне елемента на първи индекс, т.е. вторият елемент.

            // Ако искаме да премахнем елементите от 1 до 3 индекс се прави така:

            NamesList.RemoveRange(1,3);

            // Дължината на List се взема така -> ИмеНаЛист.Count : 
            int ListLength = NamesList.Count

        }
    }
}