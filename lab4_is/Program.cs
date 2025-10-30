class Program
{
    static void Main(string[] args)
    {
        IStorage? storage;

        do
        {
            Console.WriteLine("Input storage type: ");
            var line = Console.ReadLine();

            storage = StorageFactory.CreateStorage(line);
            if (storage != null)
            {
                break;
            }
        } while (true);
        
        storage.AddValue("test1", "1");
        storage.AddValue("test1", "2");
        storage.AddValue("test1", "3");
        storage.AddValue("test2", "4");
        storage.AddValue("test2", "5");
        Console.WriteLine("test1: {0}", storage.GetValue("test1"));
        Console.WriteLine("test2: {0}", storage.GetValue("test2"));
    }
}