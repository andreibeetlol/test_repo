// Declaram o interfata care sa fie folosita de factory.
public interface IStorage
{
    public void SaveValue(string key, string value);
    public string? GetValue(string key);
    public void AddValue(string key, string value);
}