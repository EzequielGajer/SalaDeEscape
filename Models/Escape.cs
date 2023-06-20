public static class Escape
{

    private static string[] incognitasSalas = new string[] { "ESPACIO", "LUNA", "AZUL", "EUROPA" };

    private static int estadoJuego = 1;

    private static int vidasRestantes = 5;

    private static void InicializarJuego()
    {
        incognitasSalas = new string[] { "ESPACIO", "LUNA", "AZUL", "EUROPA" };

    }

    public static int GetEstadoJuego()
    {
        return estadoJuego;
    }

    public static int GetVidasRestantes()
    {
        return vidasRestantes;
    }

    public static void DecrementarVida()
    {
        vidasRestantes--;
    }

    public static void ResetearVidas()
    {
        vidasRestantes = 4;
    }

    public static bool ResolverSala(int Sala, string Incognita)
    {
        if (Sala > estadoJuego || vidasRestantes <= 0)
        {
            return false;
        }

        if (incognitasSalas == null || incognitasSalas.Length == 0)
        {
            InicializarJuego();
        }

        switch (Sala)
        {
            case 1:
                if (Incognita == "ESPACIO")
                {
                    estadoJuego = estadoJuego + 1;
                    return true;
                }
                break;

            case 2:
                if (Incognita == "LUNA")
                {
                    estadoJuego = estadoJuego + 1;
                    return true;
                }
                break;

            case 3:
                if (Incognita == "AZUL")
                {
                    estadoJuego = estadoJuego + 1;
                    return true;
                }
                break;

            case 4:
                if (Incognita == "EUROPA")
                {
                    estadoJuego = estadoJuego + 1;
                    return true;
                }
                break;
        }

        vidasRestantes = vidasRestantes - 1;

        if (vidasRestantes <= 0)
        {
            Console.WriteLine("Se te agotaron las vidas");
            return false;
        }

        return false;
    }
}