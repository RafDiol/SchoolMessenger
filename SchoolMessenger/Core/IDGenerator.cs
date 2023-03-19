using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMessenger.Core
{
    public static class IDGenerator
    {
        public static readonly int DEFAULT_ID_LENGHT = 32;
        public static readonly string ALLOWED_ID_CHARACTERS = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";


        public static string generateID(int lenght)
        {
            StringBuilder sb= new StringBuilder();
            Random rnd = new Random();

            for(int i = 0; i < lenght; i++)
            {
                int index = rnd.Next(ALLOWED_ID_CHARACTERS.Length);
                sb.Append(ALLOWED_ID_CHARACTERS[index]);
            }

            return sb.ToString();
        }

        public static string generateID()
        {
            return generateID(DEFAULT_ID_LENGHT);
        }
    }
}
