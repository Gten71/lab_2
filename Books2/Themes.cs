using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books2
{
    public class Themes
    {
        public int n;
        public string[] Name_Students;
        public string[] Student = { "Nikita", "Alex", "Maxim", "Artem", "Andrey","Vlad","Petya","Kizaru","Lera","Dima" };
        public string[] Theme_str;
        public Theme facultet;
        public Random random;
        public Themes()
        {
            n = 15;
            Name_Students = new string[n];
            Theme_str = new string[n];
            random = new Random();
            int k = 0;
            for (int i = 0; i < Student.Length; i++)
            {
                for (int j = k; j < k+1; j++)
                {
                    Name_Students[j] = Student[i];
                }
                k += 1;
            }
            int themename;
            for (int i = 0; i < Theme_str.Length; i++)
            {
                themename = random.Next(4);
                Theme theme = (Theme)themename;
                Theme_str[i] = Convert.ToString(theme);
            }
        }
    }
}
