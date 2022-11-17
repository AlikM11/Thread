using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread_Class
{
    class Program
    {

        //private static readonly object balanceLock = new object();
        
        static void DownloadFile()
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine(Thread.CurrentThread.Name);
            Console.WriteLine("Thread Started");
            //some code
            Console.WriteLine("Downloading...");
            Thread.Sleep(5000);
            Console.WriteLine("Downloaded...");
        }
        //static void Example1()
        //{
        //    Console.WriteLine("Example 1 ");
        //    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        //}   
        //static void Example2()
        //{
        //    Console.WriteLine("Example 2 ");
        //    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        //}
        #region Part1
        //static void Main()
        //{
        //    //for (int i = 0; i < 10; i++)
        //    //{
        //    //    var temp = i;
        //    //    //Criticial Section bir nece threadin 1 datanin ustunde isleyen zaman bir birinin sirasina girib datani duzgun goturmemeyi
        //    //    lock(balanceLock)
        //    //    {
        //    //        Thread.Sleep(1);
        //    //        new Thread(() => { Console.WriteLine(temp); }).Start();
        //    //    }
        //    //}
        //    //string text = "My Text";

        //    //Thread thread = new Thread(() =>
        //    //{
        //    //    Console.WriteLine(text);
        //    //});
        //    //text = "New My Text";
        //    //Thread thread1 = new(() =>
        //    //{
        //    //    Console.WriteLine(text);
        //    //});
        //    //text = "older my text";
        //    //thread.Start();
        //    //thread1.Start();

        //    //Thread thread = new Thread(Example1);
        //    //Thread thread2= new Thread(Example2);
        //    //thread.Start();
        //    //thread2.Start();
        //    //thread2.Join();
        //    //thread.Join();
        //}
        #endregion

        #region Part2
        //static void Main()
        //{

        //    Thread thread = new Thread(() =>
        //    {
        //        for (int i = 0; i < 1000; i++)
        //        {
        //            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}:  {i}");
        //        }
        //    });

        //    thread.Priority = ThreadPriority.Lowest;
        //    Thread.CurrentThread.Priority = ThreadPriority.Highest;
        //    thread.Start();
        //    thread.Join();
        //    for (int i = 0; i < 100; i++)
        //    {
        //        Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} : {i}");
        //    }
        //}
        #endregion

        #region Part3
        static void Main()
        {
            Thread t1 = new(DownloadFile);
            //t1.IsBackground = true;
            t1.Name = "MyThread";
            t1.Start();
            //t1.Suspend();

            //var selected = Console.ReadLine();

            //if (selected == "1")
            //{
            //    t1.Resume();
            //}
            //else if(selected == "2")
            //{
            //    t1.Abort();
            //}

            Console.Write("Please Enter Name");
            string name = Console.ReadLine();
            Console.Write("Please Enter Surname");
            string surname = Console.ReadLine();
            Console.Write("Please Enter Age");
            int age = Int32.Parse(Console.ReadLine());

            Console.WriteLine(name);
            Console.WriteLine(surname);
            Console.WriteLine(age);
            //t1.Join();
            //Thread.CurrentThread.Join();
            Console.ReadLine();

        }

        #endregion
    }
}