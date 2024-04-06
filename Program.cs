internal class Program
{ 
    private static async void Main(string[] args)
    {
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

        CancellationToken token = cancellationToken.Token;

        var task = Task.Run(WelcomeAsync, token);

        cancellationToken.Cansel();

        //task.Wait();
        
        Console.ReadLine();     // pause
    }

    private static async Task<int> FindMaxInArrayAsync(int[] array)
    {
        int res = await Task.Run(() => FindMaxInArray(array));

        return res;
    }

    private static int FindMaxInArray(int[] array)
    {
        int max = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
            Thread.Sleep(1000);
        }

        return max;
    }

    private static async Task WelcomeAsync()
    {
        Console.WriteLine("Async Started...");

        await Task.Delay(1000);

        Console.WriteLine("Async Stopped");
    }
}
