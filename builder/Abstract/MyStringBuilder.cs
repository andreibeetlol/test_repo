public class MyStringBuilder
{
    // Avem continutul pe care vrem sa-l modificam
    private string _content = "";

    // In acest caz avem nevoie doar de o singura primitiva de modificat continutul si
    // observati ca returnam instanta proprie
    public MyStringBuilder Add(string value)
    {
        _content += value;
        
        return this;
    }

    // Actiunea de constructie trebuie sa ne returneze rezultatul dorit
    public string Build()
    {
        return _content;
    }
}