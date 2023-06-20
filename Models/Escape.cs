public static class Escape{
   
    private static string[] incognitasSalas = new string[] {"Incognita Sala 1","Incognita Sala 2","Incognita Sala 3","Incognita Sala 4"};
   
    private static int estadoJuego = 1;

    private static int vidasRestantes = 4;

    private static int vidasIniciales = 4;


    private static void InicializarJuego()
    {
        incognitasSalas = new string[] {"Incognita Sala 1", "Incognita Sala 2" ,"Incognita Sala 3","Incognita Sala 4"};
        vidasRestantes = vidasIniciales;
        
    }
   
    public static int GetEstadoJuego()
    {
        return estadoJuego;
    }

    public static int GetVidasRestantes()
    {
        return vidasRestantes;
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
                if (Incognita == "Incognita Sala 1")
                {
                    estadoJuego = estadoJuego + 1;
                    return true;
                }
                break;

            case 2:
                if (Incognita == "Incognita Sala 2")
                {
                    estadoJuego = estadoJuego + 1;
                    return true;
                }
                break;

            case 3:
                if (Incognita ==  "Incognita Sala 3")
                {
                    estadoJuego = estadoJuego + 1;
                    return true;
                }
                break;

            case 4:
                if (Incognita == "Incognita Sala 4")
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