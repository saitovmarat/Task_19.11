using System;

namespace Tumakov
{
    class ACipher : ICipher
    {
        static public string Array = "AbCD";
        public ACipher() { }
        public void encode()
        {
            for(int i = 0; i < Array.Length; i++)
            {
                if (Array[i] == 'z')
                {
                    Console.WriteLine('a');
                }
                else if (Array[i] == 'Z')
                {
                    Console.Write('A');
                }
                else
                {
                    Console.Write((char)((int)Array[i] + 1)); 
                }
                
            }
        }
        public void decode()
        {
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] == 'a')
                {
                    Console.Write('z');
                }
                else if (Array[i] == 'A')
                {
                    Console.Write('Z');
                }
                else
                {
                    Console.Write((char)((int)Array[i] - 1));
                }
            }
        }

    }
}
