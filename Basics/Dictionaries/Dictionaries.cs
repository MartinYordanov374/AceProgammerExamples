using System;
using System.Collections.Generic; // Този ред е задължителен, когато искаме да работим с речници
namespace Dictionaries
{
    class Program
    {
      static void Main(string[] args)
      {
        // така се създава речник 
        // Dictionary< тип на ключовете, тип на стойностите > ИмеНаРечника = new Dictionary < тип на ключовете, тип на стойностите > ();

        Dictionary< string, int > TestDictionary = new Dictionary < string, int > ();

        // Добавяме двойка ключ-стойност, по този начин:

        TestDictionary.Add("John", 088888888); // Отляво винаги пишем ключа и отдясно винаги пишем неговата стойност

        // Изчистваме речник от всичките му елементи по този начин:
        TestDictionary.Clear();

        // Проверяваме дали един речник съдържа даден ключ, ползвайки ContainsKey(), като в скобите слагаме ключът който търсим
        TestDictionary.ContainsKey("John");

        // Проверяваме дали един речник съдържа дадена стойност, ползвайки ContainsValue(), като в скобите слагаме стойността която търсим

        TestDictionary.ContainsValue(234);

        // Дължината на речника взимаме с Count:
        int DictionaryLength = TestDictionary.Count;

        // Махаме елемент по ключ от речника така:
        TestDictionary.Remove("John");
         
      }
    }
}
