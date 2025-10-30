public class InMemoryStorage : AbstractStorage
{
    private readonly Dictionary<string, string> _cache = new();

    public override void SaveValue(string key, string value) => _cache[key] = value;

    public override string? GetValue(string key) => _cache.TryGetValue(key, out var value) ? value : default;
}