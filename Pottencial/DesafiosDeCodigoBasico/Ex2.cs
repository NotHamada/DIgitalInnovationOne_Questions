using System.IO;
using System.Linq;
using System;

class DIO
{
    static void Main(string[] args)
    {
        int qt = int.Parse(Console.ReadLine());
        for (int i = 1; i <= qt; i++)
        {
            string[] v = new string[2];
            v = Console.ReadLine().Split(' ').ToArray();
            string a = v[0];
            string b = v[1];

            if (a.EndsWith(b))
                Console.WriteLine("encaixa");
            else
                Console.WriteLine("nao encaixa");
        }
    }
}