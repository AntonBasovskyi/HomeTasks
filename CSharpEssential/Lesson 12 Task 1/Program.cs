using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Используя конструктор диаграмм классов DSL, создайте общую диаграмму классов для паттерна MVP
(Model-View-Presenter). 
 */
namespace Events
{
    public delegate void PressKeyEventHandler();
    public class Keyboard
    {
        public event PressKeyEventHandler PressKeyA = null;
        public event PressKeyEventHandler PressKeyB = null;


        public void PressKeyAEvent()
        {
            if (PressKeyA != null)
            {
                PressKeyA.Invoke();
            }
        }
        public void PressKeyBEvent()
        {
            if (PressKeyB != null)
            {
                PressKeyB.Invoke();
            }
        }
        public void Start()
        {
            while (true)
            {
                string s = Console.ReadLine().ToLower();

                switch(s)
                {
                    case "a":
                        PressKeyAEvent();
                        break;
                    case "b":
                        PressKeyBEvent();
                        break;
                    case "exit":
                        return;
                    default:
                        Console.WriteLine($"Нет обработчика нажатия на клавишу {s}");
                        break;
                }
            }

        }
        class Program
        {
            static private void PressKeyA_Handler()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("   x   ");
                Console.WriteLine("  x x  ");
                Console.WriteLine(" xxxxx ");
                Console.WriteLine("x     x");
                Console.WriteLine(" xxxx");
                Console.WriteLine(" x   x");
                Console.WriteLine(" xxxx");
                Console.WriteLine(" x   x");
                Console.WriteLine(" xxxxx");
                Console.WriteLine("  xxx");
                Console.WriteLine(" x   x");
                Console.WriteLine(" x   x");
                Console.WriteLine("  xxx");
                Console.WriteLine(" xxxx");
                Console.WriteLine(" x   x");
                Console.WriteLine(" xxxx");
                Console.WriteLine(" x   x");
                Console.WriteLine(" xxxxx");
                Console.WriteLine("   x   ");
                Console.WriteLine("  x x  ");
                Console.WriteLine(" xxxxx ");
                Console.WriteLine("x     x");
            }
            static private void PressKeyB_Handler()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Console.WriteLine(" xxxx");
                Console.WriteLine(" x   x");
                Console.WriteLine(" xxxx");
                Console.WriteLine(" x   x");
                Console.WriteLine(" xxxxx");
                Console.WriteLine("  xxx");
                Console.WriteLine(" x   x");
                Console.WriteLine(" x   x");
                Console.WriteLine("  xxx");
                Console.WriteLine(" xxxx");
                Console.WriteLine(" x   x");
                Console.WriteLine(" xxxx");
                Console.WriteLine(" x   x");
                Console.WriteLine(" xxxxx");
                Console.WriteLine("   x   ");
                Console.WriteLine("  x x  ");
                Console.WriteLine(" xxxxx ");
                Console.WriteLine("x     x");
            }
            static void Main(string[] args)
            {
                Keyboard keyboard = new Keyboard();

                keyboard.PressKeyA += PressKeyA_Handler;

                keyboard.PressKeyB += PressKeyB_Handler;

                keyboard.Start();
            }
    
        }
    }
}
