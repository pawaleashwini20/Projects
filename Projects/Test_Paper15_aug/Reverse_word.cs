using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Test_Paper15_aug
{
    class Reverse_word
    {
        static void printReverse(String str)
        {
            // Print first word
            int i = 0;
            for (i = 0; i < str.Length && str[i] != ' '; i++)
                Console.Write(str[i]);

            // Print middle words
            String word = "";


            for (; i < str.Length; i++)
            {

                if (str[i] != ' ')
                    word += str[i];

                else
                {
                    word = reverse(word);
                    Console.Write(new StringBuilder(word).ToString() + " ");
                    word = "";
                }
            }

            // Print last word
            Console.Write(word + " ");
        }
        static String reverse(String input)
        {
            char[] temparray = input.ToCharArray();
            int left, right = 0;
            right = temparray.Length - 1;

            for (left = 0; left < right; left++, right--)
            {
                // Swap values of left and right
                char temp = temparray[left];
                temparray[left] = temparray[right];
                temparray[right] = temp;
            }
            return String.Join("", temparray);
        }

        // Driver code
        public static void Main(String[] args)
        {
            String str = "Hi how are you geeks";
            printReverse(str);
        }

    }
}
    