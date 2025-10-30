public class InputLogObservable : Observable<string>
{
    public void Log(string value)
    {
        // Putem aici sa facem si alte computatii daca e nevoie
        OnAction(value);
    }
}