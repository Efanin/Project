using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    static class Work
    {
        public static void main()
        {
            string word = "wello word".Print();
            word.Contains("word").Print();// определяет, содержится ли подстрока в строке
            (word + " !!!").Print();
            word.IndexOf("wo").Print();
            word.Insert(5, "     ").Print();
            word.Replace("word", "world").Print();
            string text = "И поэтому все так произошло";
            text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray().Print();
            word.Remove(6).Print();
            word[6..^0].Print();
            text.Replace("И поэтому все так ", "").Print();
        }
    }
}
