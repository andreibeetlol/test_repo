// Clasa este abstracta si trebuie mostenita, de asemena putem pune si 
// un la parametru de genericitate pentru a sti ce fel de date proceseaza observabilul
public abstract class Observable<TInput>
{
    // Tinem o lista cu actiunile ce trebuie sa se execute la o computatie, 
    // tipul Action<TInput> este o functie care ia un parametru de tip TInput si nu returneaza nimic
    private readonly List<Action<TInput>> _actions = [];
    
    // Observatori pot sa-si inregistreze apeluri (callbacks) la metode proprii pentru a lua actiuni in cazul unei actualizari
    public void Subscribe(Action<TInput> onAction)
    {
        _actions.Add(onAction);
    }

    // Aceasta e metoda ce trebuie apelata atunci cand actualizam date in clasa care mosteneste
    // astfel incat sa fie apelate a
    public void OnAction(TInput input)
    {
        foreach (var action in _actions)
        {
            action(input);
        }
    }
}