using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Stack
    {
        private String[] wilbert = new string[65];
        private int top;
        private int max;
        
        public Stack()
        {
            top = -1;
            max = wilbert.Length;
        }

        public void push() //memasukkan elemen ke dalam stack
        {
            if (top == max - 1)
            {
                Console.WriteLine("Stack Overflow");
                return;
            }
            else
            {
                top++;
                Console.WriteLine("Masukan Element: ");
                wilbert[top] = Console.ReadLine();
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
