using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KupriyanovAA.Sprint1.Task6.V9.Lib
{
    public class DataService : ISprint1Task6V9
    {
        // Метод принимает строку, переносит последнюю букву каждого слова в начало и возвращает результат
        public string MoveLetterToStart(string value)
        {
            // Разбиваем строку на слова, используя пробел как разделитель
            string[] words = value.Split(' ');

            // Обрабатываем каждое слово
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];

                // Если слово не пустое, переносим последнюю букву в начало
                if (word.Length > 0)
                {
                    char lastLetter = word[word.Length - 1];               // Последняя буква
                    string restOfWord = word.Substring(0, word.Length - 1); // Всё слово без последней буквы
                    words[i] = lastLetter + restOfWord;                     // Собираем новое слово
                }
            }

            // Объединяем слова обратно в строку через пробел
            return string.Join(" ", words);
        }
    }
}