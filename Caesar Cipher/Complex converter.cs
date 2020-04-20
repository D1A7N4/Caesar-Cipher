using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_Cipher
{
    class Complex_converter
    {
        char[] key = new char[26];
        int shift;
        public Complex_converter(string key, int shift)
        {
            this.key = key.ToUpper().ToCharArray();
            this.shift = shift;
        }
        public string encrypt(string plaintext)
        {
            char[] plainchars = plaintext.ToUpper().ToCharArray();
            char[] cypherchars = new char[plainchars.Length];
            string output = "";
            int i = 0;
            foreach(char c in plainchars)
            {
                if (Array.IndexOf(key, c) + shift <= 25)
                {
                    cypherchars[i] = key[Array.IndexOf(key, c) + shift];
                }
                else
                {
                    cypherchars[i] = key[Array.IndexOf(key, c) + shift - 26];
                }
                output = output + cypherchars[i];
                i = i + 1;
            }
            return output;
        }
        public string decrypt(string plaintext)
        {
            char[] plainchars = plaintext.ToUpper().ToCharArray();
            char[] cypherchars = new char[plainchars.Length];
            string output = "";
            int i = 0;
            foreach (char c in plainchars)
            {
                if (Array.IndexOf(key, c) - shift >= 0)
                {
                    cypherchars[i] = key[Array.IndexOf(key, c) - shift];
                }
                else
                {
                    cypherchars[i] = key[Array.IndexOf(key, c) - shift + 26];
                }
                output = output + cypherchars[i];
                i = i + 1;
            }
            return output;
        }
    }
}