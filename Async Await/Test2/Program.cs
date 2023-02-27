class Program
{
    //In this example, Method1 is returning the total length as an integer value and we are passing a parameter as a length in a Method3, which is coming from Method1.
    //Here, we have to use await keyword before passing a parameter in Method3 and for it, we have to use the async keyword from the calling method.
    
    //In the code given below, Method3 requires one parameter, which is the return type of Method1
    //Here, await keyword is playing a vital role for waiting of Method1 task completion
    static async Task Main(string[] args)
    {
        await CallMethod();
        Console.ReadKey();
    }

    public static async Task CallMethod()
    {
        Method2();
        var count = await Method1();
        Method2();
        Method3(count);

    }
    public static async Task<int> Method1()
    {
        int count = 0;
        await Task.Run(() =>
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Method1");
                count++;
            }
        });
        return count;
    }
    public static void Method2()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Method 2");
        }
    }
    public static void Method3(int count)
    {
        Console.WriteLine("Total count is " +  count);
    }
}