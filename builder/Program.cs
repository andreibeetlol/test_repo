static class Program
{
    static async Task Main(string[] args)
    {
        var builder = new MyStringBuilder();

        builder.Add("Ana")
            .AddWords(new List<string>()
            {
                "are",
                "mere"
            })
            .AddLine("Barnabas are banane")
            .AddLines(new List<string>()
            {
                "Cecilia are cirese",
                "Dan are dude"
            });
        
        Console.Write(builder.Build());
    }
}