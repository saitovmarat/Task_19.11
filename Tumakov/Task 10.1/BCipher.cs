using System;

namespace Tumakov
{
    class BCipher : ICipher
    {
        public static string Array = "AbCD";
        public BCipher() { }
        public void encode()
        {
            int A_index = (int)'A';
            int a_index = (int)'a';
            int Z_index = (int)'Z';
            int z_index = (int)'z';
            for(int i = 0; i < Array.Length; i++)
            {
                if (Array.ToLower()[i] == Array[i])
                {
                    Console.Write((char)((int)(z_index - ((int)Array[i] - a_index))));
                }
                else
                {
                    Console.Write((char)((int)(Z_index - ((int)Array[i] - A_index))));
                }
                
            }
        }

        public void decode()
        {
            int A_index = (int)'A';
            int a_index = (int)'a';
            int Z_index = (int)'Z';
            int z_index = (int)'z';
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array.ToLower()[i] == Array[i])
                {
                    Console.Write((char)((int)(z_index - ((int)Array[i] - a_index))));
                }
                else
                {
                    Console.Write((char)((int)(Z_index - ((int)Array[i] - A_index))));
                }

            }
        }

        
    }
}
