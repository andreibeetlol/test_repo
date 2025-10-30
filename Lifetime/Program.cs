static class Program
{
    static async Task Main(string[] args)
    {
        var serviceCollection = new ServiceCollection();
        var type = Console.ReadLine();

        switch (type)
        {
            case "singleton":
                serviceCollection.AddSingleton<ILifetimeTest, LifetimeTest>();
                break;
            case "scoped":
                serviceCollection.AddScoped<ILifetimeTest, LifetimeTest>();
                break;
            default:
                serviceCollection.AddTransient<ILifetimeTest, LifetimeTest>();
                break;
        }
        
        var serviceProvider = serviceCollection.BuildServiceProvider();
        
        Console.WriteLine("Testing with default scope:");
        
        for (var i = 0; i < 3; ++i)
        {
            var lifeTimeTest = serviceProvider.GetRequiredService<ILifetimeTest>();
            
            Console.WriteLine("\tThe returned ID is: {0}", lifeTimeTest.InstanceId);
        }
        
        Console.WriteLine("Testing with multiple scopes:");
        
        for (var i = 0; i < 3; ++i)
        {
            using var scope = serviceProvider.CreateScope();
            
            var lifeTimeTest = scope.ServiceProvider.GetRequiredService<ILifetimeTest>();
            
            Console.WriteLine("\tThe returned ID is: {0}", lifeTimeTest.InstanceId);
        }
    }
}