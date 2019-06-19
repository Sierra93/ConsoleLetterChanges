using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLetterChanges {
    //На входе вводим строку.Изменить каждую букву в строке на следующую букву по алфавиту и вывести новую строку
    class Program {
        public static string LetterChanges(string str) {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Length; i++) {
                if (str[i] >= 'a' && str[i] <= 'z') {
                    switch (str[i]) {
                        case 'z': sb.Append('A'); break;
                        case 'd': sb.Append('E'); break;
                        case 'h': sb.Append('I'); break;
                        case 'n': sb.Append('O'); break;
                        case 't': sb.Append('U'); break;
                        default: sb.Append((char)(str[i] + 1)); break;
                    }
                }
                else {
                    sb.Append(str[i]);
                }
            }
            return sb.ToString();
        }
        static void Main() {
            Console.WriteLine(LetterChanges(Console.ReadLine()));
            Console.ReadKey();
        }
    }
}
