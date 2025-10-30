public class MySingleton
{
    //... Ne adaugam ce avem noi nevoie sa implementam in clasa

    private static MySingleton? _instance; // Avem instanta pe care vrem sa o folosim peste tot

    // Nu vrem sa apelam constructorul din alta parte a codului si e privat, altfel am avea mai multe instante create
    private MySingleton()
    {
        //... Facem initializarea daca e nevoie
    }
    
    // Nu mai apelam constructorul ci metoda aceasta ca sa obtinem o instanta
    public static MySingleton GetInstance()
    {
        // Daca nu avem instanta creata cream una si o salvam
        if (_instance == null) {
            _instance = new MySingleton();
        }
        
        // Returnam instanta creata o data
        return _instance;
    }
}