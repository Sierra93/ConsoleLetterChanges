using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLetterChanges {
    // Пусть функция LetterChanges(str) примет передаваемый параметр str и изменит его, используя следующий алгоритм.
    //Замените каждую букву в строке буквой, следующей за ней в алфавите(т.е.c становится d, z становится a). 
    //Затем используйте каждый гласный в этой новой строке(a, e, i, o, u) и, наконец, верните эту измененную строку.
    class Program {
        public static string LetterChanges(string str) {
            //string alfavitArr = "a", "b", "c", "d", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        string alfavitArr = "a b c d f g h i j k l m n o p q r s t u v w x y z";
            string[] words = alfavitArr.Split(' '); //разделяем строку по пробелам для записи в промежуточный массив
            string[] strWords = str.Split(' ');
            var findCollection = new List<string>();
            for (var i = 0; i < words.Length; i++) {
                for (var j = 0; j < strWords.Length; j++) {
                    if (strWords[j].Contains(words[i])) {
                        findCollection.Add(words[i]);
                    }
                }
            }
            return str;
        }
        static void Main() {
            Console.WriteLine(LetterChanges(Console.ReadLine()));
            Console.ReadKey();
        }
    }
}
