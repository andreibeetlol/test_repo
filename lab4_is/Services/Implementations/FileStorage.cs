// Daca folosim cuvantul cheie "sealed", aceasta clasa nu mai poate fi derivata mai departe.
public sealed class FileStorage : AbstractStorage
{
    private const string FilePath = "./Storage.txt";

    public FileStorage()
    {
        if (!File.Exists(FilePath))
        {
            using var _ = File.Create(FilePath);
        }
    }

    // Trebuie folosit "override" pe metodele abstracte din clasa abstracta
    public override void SaveValue(string key, string value)
    {
        var lines = File.ReadAllLines(FilePath);
        using var file = new StreamWriter(FilePath, new FileStreamOptions
        {
            Mode = FileMode.Truncate,
            Access = FileAccess.Write
        });

        file.WriteLine($"{key} {value}");

        foreach (var line in lines)
        {
            var lineKey = line[..line.IndexOf(" ", StringComparison.InvariantCulture)];

            if (lineKey != key)
            {
                file.WriteLine(line);
            }
        }
    }

    public override string? GetValue(string key)
    {
        using var reader = new StreamReader(FilePath, new FileStreamOptions
        {
            Mode = FileMode.OpenOrCreate
        });

        while (!reader.EndOfStream)
        {
            var line = reader.ReadLine();

            var lineKey = line?[..line.IndexOf(" ", StringComparison.InvariantCulture)];

            if (lineKey == key)
            {
                return line?[(line.IndexOf(" ", StringComparison.InvariantCulture) + 1)..];
            }
        }

        return default;
    }
}