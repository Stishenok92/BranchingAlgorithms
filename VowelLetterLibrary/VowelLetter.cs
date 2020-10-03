using System;

namespace VowelLetterLibrary
{
    public class VowelLetter
    {
        public const string MSG_LETTER_IS_VOWEL = "Is a vowel letter";
        public const string MSG_LETTER_IS_CONSONANT = "Is a consonant letter";
        public const string MSG_SYMBOL_IS_NOT_LETTER = "Is not a letter";
        public const string MSG_IS_STRING = "Is string";

        public static bool IsSymbol(string str)
        {
            return (char.TryParse(str, out char symbol));
        }

        public static bool IsLetter(char symbol)
        {
            return (char.IsLetter(symbol));
        }
        
        public static char ToLowerLetter(char letter)
        {
            return char.ToLower(letter);
        }

        public static string IsVowelLetter(char letter)
        {
            string msg;

            switch (ToLowerLetter(letter))
            {
                case 'a': case 'e': case 'i': case 'o': case 'u': case 'y': msg = MSG_LETTER_IS_VOWEL; break;
                default: msg = MSG_LETTER_IS_CONSONANT; break;
            }

            return msg;
        }

        public static string DefinitionSymbol(string str)
        {
            string msg;

            if (IsSymbol(str))
            {
                char letter = char.Parse(str);
                
                if (IsLetter(letter))
                {
                    msg = IsVowelLetter(letter);
                }
                else
                {
                    msg = MSG_SYMBOL_IS_NOT_LETTER;
                }
            }
            else
            {
                msg = MSG_IS_STRING;
            }

            return msg;
        }
    }
}