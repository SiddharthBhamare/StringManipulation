using System;

namespace StringManipulation
{
    public static class StringManipulation
    {
        public static string SecondOccurenceChars(this string astrInputString)
        {
            astrInputString = astrInputString.ToLower();
            int[] arrAscii = new int[256];
            string lstrFinalOutput = string.Empty;
            for(int i=0;i<astrInputString.Length;i++)
            {
                if(arrAscii[Convert.ToInt32(astrInputString[i])] > 0)
                {
                    lstrFinalOutput = lstrFinalOutput + astrInputString[i];
                }
                arrAscii[Convert.ToInt32(astrInputString[i])]++;
            }
            return lstrFinalOutput;
        }
        public static string UniqueChars(this string astrInputString)
        {
            astrInputString = astrInputString.ToLower();
            int[] arrAscii = new int[256];
            string lstrFinalOutput = string.Empty;
            for (int i = 0; i < astrInputString.Length; i++)
            {
                arrAscii[Convert.ToInt32(astrInputString[i])]++;
            }

            for (int i = 0; i < astrInputString.Length; i++)
            {
                if(arrAscii[Convert.ToInt32(astrInputString[i])] == 1)
                    lstrFinalOutput = lstrFinalOutput + astrInputString[i];
            }
            return lstrFinalOutput;
        }

        public static string DupChars(this string astrInputString)
        {
            astrInputString = astrInputString.ToLower();
            int[] arrAscii = new int[256];
            string lstrFinalOutput = string.Empty;
            for (int i = 0; i < astrInputString.Length; i++)
            {
                if (arrAscii[Convert.ToInt32(astrInputString[i])] > 0 && arrAscii[Convert.ToInt32(astrInputString[i])] != 9999)
                {
                    lstrFinalOutput = lstrFinalOutput + astrInputString[i];
                    arrAscii[Convert.ToInt32(astrInputString[i])] = 9999;
                }
                else if (arrAscii[Convert.ToInt32(astrInputString[i])] != 9999)
                {
                    arrAscii[Convert.ToInt32(astrInputString[i])]++;
                }                
            }
            return lstrFinalOutput;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string input = "AAssjjkkLLlx";
            Console.WriteLine("Second Occurence of Char " + input.SecondOccurenceChars());
            Console.WriteLine("Unique Charcters in string " + input.UniqueChars());
            Console.WriteLine("Duplicate Charcters once occurance " + input.DupChars());
            Console.WriteLine("Hello World!");
        }
    }
}
