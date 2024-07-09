using System;
using System.Collections.Generic;
using System.Text;

namespace ListOfLists
{
    class bài41
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Tạo danh sách các danh sách
            List<List<string>> myList = new List<List<string>>();
            myList.Add(new List<string> { "a", "b" });
            myList.Add(new List<string> { "c", "d", "e" });
            myList.Add(new List<string> { "qwerty", "asdf", "zxcv" });
            myList.Add(new List<string> { "a", "b" });

            // Duyệt qua danh sách sử dụng vòng lặp for
            for (int i = 0; i < myList.Count; i++)
            {
                List<string> subList = myList[i];
                for (int j = 0; j < subList.Count; j++)
                {
                    Console.WriteLine(subList[j]);
                }
            }
        }
    }
}
