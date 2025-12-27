namespace AtomConsole;

class Program
{
  public static void Main()
  {
    while (true)
    {
      Console.Clear();
      Console.CursorVisible = true;
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.WriteLine("Добро пожаловать в симулятор АЭС (РБМК-1000) - ATOM.");
      Console.ResetColor();

      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine(@"
 Меню

 1 - Блочный щит управления
 2 - Логи
 0 - Выход");
      Console.ResetColor();
      Console.Write("\n > ");
      string userInput = Console.ReadLine()!;
      switch (userInput)
      {
        case "1":
          MainControlPanel mainControlPanel = new();
          mainControlPanel.ControlPanel();
          break;
        case "2":
          break;
        case "0":
          //Exit
          Console.Clear();
          return;
      }
    }
  }
}