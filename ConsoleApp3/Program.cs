using ConsoleApp3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //class Worker
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    static Worker()
    //    {           
    //        Console.WriteLine("Static Constructor");
    //    }
    //    public Worker()
    //    {
    //        Console.WriteLine("Default Constructor");
    //    }
    //    public Worker(int ıd, string name)
    //    {
    //        Id = ıd;
    //        Name = name;
    //        Console.WriteLine("Parametric Constructor");
    //    }

    //}
    //class Program
    //{

    //    static void Main(string[] args)
    //    {
    //        Worker worker = new Worker();
    //        Worker worker2 = new Worker();
    //        Worker worker3 = new Worker(1,"Mike");
    //    }
    //}


//    class Car
//    {
//        public int Id { get; set; }
//        public static DateTime globalStartTime;
//        static Car()
//        {
//            globalStartTime = DateTime.Now;
//            Console.WriteLine($@"Static constructor called 
//            Global start time : {globalStartTime.ToLongTimeString()}");
//        }

//        public Car(int id)
//        {
//            Id = id;
//        }
//        public void Drive()
//        {
//            TimeSpan elapsedTime = DateTime.Now - globalStartTime;
//            Console.WriteLine($@"
//        Car {Id}  is starting its works
//        {elapsedTime.Seconds} seconds
//        after global start time
//        {globalStartTime.ToLongTimeString()}.{globalStartTime.Millisecond}
//");
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Car car1 = new Car(1);
//            car1.Drive();
//            Thread.Sleep(3000);
//            Car car2 = new Car(2);
//            car2.Drive();
//        }
//    }


    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount();

        }
    }



}

