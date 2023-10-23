using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FrmBasicThread
{
    internal class MyThreadClass
    {
        public static void Thread1()
        {
            for (int i = 0; i < 3; i++)
            {
                Thread Thread1 = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + Thread1.Name + " = " + i);
                Thread.Sleep(500);
            }
        }
        public static void Thread2()
        {
            for (int i = 0; i < 6; i++)
            {
                Thread Thread2 = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + Thread2.Name + " = " + i);
                Thread.Sleep(2000);
            }
        }
    }
}
