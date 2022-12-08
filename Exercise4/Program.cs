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

        public int pop()//mengambil dan menghapus elemen dari stack
        {
            if (top == -1)
            {
                Console.WriteLine("Stack Underflow");
                return -1;
            }
            else
            {
                Console.WriteLine("Poped element is: " + wilbert[top]);
                top--;
                return top;
            }
        }
        public void display()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine("Item[" + (i + 1) + "]: " + wilbert[i]);
                }
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
