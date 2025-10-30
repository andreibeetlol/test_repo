/* Clasa abstracta poate sau nu sa implementeze o interfata.
 * Aici folosim clasa astracta pentru ca o metoda poate fi implementata din alte metode
 * si pentru a reduce codul implementam acea metoda.
 */
public abstract class AbstractStorage : IStorage
{
    // Metodele care nu se implementeaza sunt declarate cu "abstract".
    public abstract void SaveValue(string key, string value);
    public abstract string? GetValue(string key);

    /* Clasa abstracta poate avea metode implementate, daca se implementeaza
     * o interfata trebuie fie ca medele sa fie declarate ca fiind abstracte fie
     * se fie implementate.
     */
    public void AddValue(string key, string value)
    {
        var oldValue = GetValue(key);

        SaveValue(key, oldValue != null ? $"{oldValue} {value}" : value);
    }
}