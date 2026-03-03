using System;

class Program
{
    static void Main(string[] args)
    {
        Time t1 = new Time();
        Time t2 = new Time(10);
        Time t3 = new Time(10, 30);
        Time t4 = new Time(10, 30, 45);
        Time t5 = new Time(10, 30, 45, 500);

        Console.WriteLine(t1);
        Console.WriteLine(t2);
        Console.WriteLine(t3);
        Console.WriteLine(t4);
        Console.WriteLine(t5);
    }
}
