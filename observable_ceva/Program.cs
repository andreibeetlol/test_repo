static class Program
{
    static async Task Main(string[] args)
    {        
        var cancellationTokenSource = new CancellationTokenSource();
        var cancellationToken = cancellationTokenSource.Token;

        // TODO: Creati obiectele pentru observabil si observator, apoi abonati observatorul
        
        var read = Task.Run(() =>
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                var line = Console.ReadLine();

                if (line == "exit")
                {
                    cancellationTokenSource.Cancel();
                }
                else
                {
                    // TODO: Trimiteti linia citita catre obsevabil 
                }
            }
            
        }, CancellationToken.None);
        
        await read;
        
        // TODO: Printati continutul din observator
    }
}