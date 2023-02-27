class Program
{
    //In the code given below, Method1 and Method2 are not dependent on each other and
    //we are calling from the Main method.
    static void Main(string[] args)
    {
        Method1();
        Method2();
        Method3();
        Method4();
        Console.ReadKey();
    }
    
    public static void Method1()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Method 1");
            Task.Delay(100).Wait();
        }
    }
    public static void Method2()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Method 2");
            Task.Delay(100).Wait();
        }
    }
    public static void Method3()
    {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Method 3");
                Task.Delay(100).Wait();
            }
    }
    public static void Method4()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Method 4");
            Task.Delay(100).Wait();
        }
    }
}