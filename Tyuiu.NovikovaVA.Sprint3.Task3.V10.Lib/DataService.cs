﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.NovikovaVA.Sprint3.Task3.V10.Lib
{
    public class DataService : ISprint3Task3V10
    {
        public string DeleteCharInString(string value, char item)
        {
            string result = "";
            item  = 'p';
            foreach(char c in value) 
            {
                if (c!=item)
                {
                    result += c;
                }

            }
            return result;
        }
    }
}
