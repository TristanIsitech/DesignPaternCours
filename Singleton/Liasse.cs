public class Liasse
{
    private static Liasse? _instance = null;


    public static Liasse Instance()
    {
        if (_instance != null) return _instance;
        return new Liasse();
    }
}