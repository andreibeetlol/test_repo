
public static class StorageFactory
{
    public static IStorage? CreateStorage(string storageType)
    {
        switch (storageType)
        {
            case "inmemory":
                return new InMemoryStorage();
            case "file":
                return new FileStorage();
            default:
                return null;
        }
    }
}
