public class Controlador
{
    private static float dificultad = 10;
    public static int vida = 100;
    public static int nivel = 1;
    public static int cantidad = 0;

    public static float factor()
    {
        float reducción = (10 * dificultad) / 100;
        return reducción;
    }

}
