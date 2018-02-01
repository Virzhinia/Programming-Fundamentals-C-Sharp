using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<string> endComand = Console.ReadLine().Split(' ').ToList();

            while (endComand[0] != "Odd" && endComand[0] !="Even")
            {

            if(endComand[0]=="Delete")
                {
                    int removeNum = int.Parse(endComand[1]);
                    numbers.RemoveAll(i => i == removeNum);
                }
            else
                {
                    int element = int.Parse(endComand[1]);
                    int position = int.Parse(endComand[2]);
                    numbers.Insert(position, element);
                }
                endComand = Console.ReadLine().Split(' ').ToList();
            }

            if(endComand[0]=="Odd")
            {
               numbers.RemoveAll(x => x % 2 == 0);
                Console.WriteLine(string.Join(" ",numbers));
            }
            else
            {
                numbers.RemoveAll(x => x % 2 != 0);
                Console.WriteLine(string.Join(" ",numbers));
            }
        }
    }
}
