using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace шифр_файла
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = File.ReadAllText(@"C:\Users\Вахид\Desktop\Новая папка");
            var crypt = CaesarCipher.Encryption(text);
            Console.WriteLine("шифр {0}",crypt);
            Console.ReadLine();
        }
    }
    class CaesarCipher
    {
        static string alph = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

        public static string Encryption (string text)
        {
            var res = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
                for (int j = 0; j < alph.Length; j++)
                    if (text[i] == alph[j]) res.Append(alph[(j + 3) % alph.Length]);
            return res.ToString();
        }
        public static string Decryption (string crypt)
        {    
            var res = new StringBuilder();
            for (int i = 0; i < crypt.Length; i++)
                for (int j = 0; j < alph.Length; j++)
                    if (crypt[i] == alph[j]) res.Append(alph[(j - 3 + alph.Length) % alph.Length]);
            return res.ToString();
        }
    }
}
