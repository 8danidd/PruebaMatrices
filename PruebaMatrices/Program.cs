using System.Data;
using System.Reflection;

public class Matriz
{
    static int pagina = -1;
    static int modelo = 0;
    static string[,] modelos =
{
    { "KTM Super Duke 1390, 19500 EUR", "KTM 890 Duke R, 11500 EUR", "KTM RC 390, 6900 EUR", "KTM 1290 Super Adventure R, 18900 EUR", "KTM 690 SMC R, 10500 EUR" },
    { "DUCATI Panigale V4, 23000 EUR", "DUCATI Multistrada V4, 21500 EUR", "DUCATI Monster 821, 12000 EUR", "DUCATI Streetfighter V4, 22000 EUR", "DUCATI Scrambler 1100, 14000 EUR" },
    { "YAMAHA R1, 20500 EUR", "YAMAHA MT-09, 9400 EUR", "YAMAHA XSR900, 10500 EUR", "YAMAHA Ténéré 700, 11200 EUR", "YAMAHA Tracer 9 GT, 13000 EUR" },
    { "KAWASAKI Ninja H2R, 55000 EUR", "KAWASAKI Z900, 9500 EUR", "KAWASAKI Versys 1000, 12800 EUR", "KAWASAKI Vulcan S, 8300 EUR", "KAWASAKI Z H2, 16000 EUR" },
    { "BMW S1000RR, 21000 EUR", "BMW R1250GS, 18500 EUR", "BMW F900R, 10000 EUR", "BMW K1600GT, 24500 EUR", "BMW G310R, 5500 EUR" }
};
    public static void Main(string[] args)
    {
        while (true)
        {
            Catalogo();
            Console.Clear();
            Console.WriteLine("Has comprado: " + modelos[pagina, modelo - 1]);
            Thread.Sleep(3000);
            Console.Clear();
        }
    }
    static void Catalogo()
    {

        Console.WriteLine("\r\n                                                                                           \r\n  ,ad8888ba,                                    88                                         \r\n d8\"'    `\"8b                ,d                 88                                         \r\nd8'                          88                 88                                         \r\n88             ,adPPYYba,  MM88MMM  ,adPPYYba,  88   ,adPPYba,    ,adPPYb,d8   ,adPPYba,   \r\n88             \"\"     `Y8    88     \"\"     `Y8  88  a8\"     \"8a  a8\"    `Y88  a8\"     \"8a  \r\nY8,            ,adPPPPP88    88     ,adPPPPP88  88  8b       d8  8b       88  8b       d8  \r\n Y8a.    .a8P  88,    ,88    88,    88,    ,88  88  \"8a,   ,a8\"  \"8a,   ,d88  \"8a,   ,a8\"  \r\n  `\"Y8888Y\"'   `\"8bbdP\"Y8    \"Y888  `\"8bbdP\"Y8  88   `\"YbbdP\"'    `\"YbbdP\"Y8   `\"YbbdP\"'   \r\n                                                                  aa,    ,88               \r\n                                                                   \"Y8bbdP\"                \r\n");
        Console.Write("1 - KTM\n\n2 - DUCATI\n\n3 - YAMAHA\n\n4 - KAWASAKI\n\n5 - BMW\n\n\n6 - (SALIR)");
        ConsoleKeyInfo KeyInfo = Console.ReadKey(true);
        switch (KeyInfo.Key)
        {
            case ConsoleKey.D1:
                Console.Clear();
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine((i + 1) + " - " + modelos[0, i] + "\n");

                }
                pagina = 0;
                Console.WriteLine("\nElige el modelo a comprar: ");
                modelo = Convert.ToInt32(Console.ReadLine());
                if (modelo < 0 || modelo > 4)
                {
                    Console.Clear();
                    Console.WriteLine("Posicion invalida");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Catalogo();
                }
                break;
            case ConsoleKey.D2:
                Console.Clear();
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine((i + 1) + " - " + modelos[1, i] + "\n");
                }
                pagina = 1;
                Console.WriteLine("\nElige el modelo a comprar: ");
                modelo = Convert.ToInt32(Console.ReadLine());
                if (modelo < 0 || modelo > 4)
                {
                    Console.Clear();
                    Console.WriteLine("Posicion invalida");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Catalogo();
                }
                break;
            case ConsoleKey.D3:
                Console.Clear();
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine((i + 1) + " - " + modelos[2, i] + "\n");
                }
                pagina = 2;
                Console.WriteLine("\nElige el modelo a comprar: ");
                modelo = Convert.ToInt32(Console.ReadLine());
                if (modelo < 0 || modelo > 4)
                {
                    Console.Clear();
                    Console.WriteLine("Posicion invalida");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Catalogo();
                }
                break;
            case ConsoleKey.D4:
                Console.Clear();
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine((i + 1) + " - " + modelos[3, i] + "\n");
                }
                pagina = 3;
                Console.WriteLine("\nElige el modelo a comprar: ");
                modelo = Convert.ToInt32(Console.ReadLine());
                if (modelo < 0 || modelo > 4)
                {
                    Console.Clear();
                    Console.WriteLine("Posicion invalida");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Catalogo();
                }
                break;
            case ConsoleKey.D5:
                Console.Clear();
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine((i + 1) + " - " + modelos[4, i] + "\n");
                }
                pagina = 4;
                Console.WriteLine("\nElige el modelo a comprar: ");
                modelo = Convert.ToInt32(Console.ReadLine());
                if (modelo < 0 || modelo > 4)
                {
                    Console.Clear();
                    Console.WriteLine("Posicion invalida");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Catalogo();
                }
                break;
            case ConsoleKey.D6:
                Environment.Exit(0);
                break;
        }
    }
}