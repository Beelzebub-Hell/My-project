
static void Main()
{

        Console.WriteLine("Музыкальный проигрыватель");
        Console.WriteLine("Нажмите клавишу 0-9");

    while (true)
    {
        ConsoleKeyInfo input = Console.ReadKey(true);
        switch (input.KeyChar)
        {
            case '1':
                Console.Beep(200, 85);
                break;
            case '2':
                Console.Beep(250, 85);
                break;
            case '3':
                Console.Beep(300, 85);
                break;
            case '4':
                Console.Beep(350, 85);
                break;
            case '5':
                Console.Beep(400, 85);
                break;
            case '6':
                Console.Beep(450, 85);
                break;
            case '7':
                Console.Beep(500, 85);
                break;
            case '8':
                Console.Beep(550, 85);
                break;
            case '9':
                Console.Beep(600, 85);
                break;
            case '0':
                Console.Beep(650, 85);
                break;
            default:
                Console.Beep();
                break;
        }
    }
}

Main();
