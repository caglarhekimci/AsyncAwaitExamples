class Program
{
    //In this example, Method1 is returning the total length as an integer value and we are passing a parameter as a length in a Method3, which is coming from Method1.
    //Here, we have to use await keyword before passing a parameter in Method3 and for it, we have to use the async keyword from the calling method.

    //In the code given below, Method3 requires one parameter, which is the return type of Method1
    //Here, await keyword is playing a vital role for waiting of Method1 task completion
    static void Main(string[] args)
    {
        Task task = new Task(CallMethod);
        task.Start();
        task.Wait();
        Console.ReadKey();
    }

    static async void CallMethod()
    {
       

        Console.WriteLine(" Other Work 1");
        Console.WriteLine(" Other Work 2");
        Console.WriteLine(" Other Work 3");


        Console.WriteLine(" After work 1");
        Console.WriteLine(" After work 2");
    }

    static async Task<int> ReadFile(string file)
    {
        int length = 0;

        Console.WriteLine(" File reading is stating");
        using (StreamReader reader = new StreamReader(file))
        {
            // Reads all characters from the current position to the end of the stream asynchronously
            // and returns them as one string.
            string s = await reader.ReadToEndAsync();

            length = s.Length;
        }
        Console.WriteLine(" File reading is completed");
        return length;
    }


}