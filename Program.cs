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
      Console.WriteLine("Добро пожаловать в симулятор АЭС - ATOM.");
      Console.ResetColor();

      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine(@"
 Меню

 1 - Блочный щит управления
 2 - Логи
 3 - Выход");
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
        case "3":
          Console.Clear();
          return;
        default:
          Console.Clear();
          Console.CursorVisible = false;
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("Выберите пункт меню!");
          Console.ResetColor();
          Thread.Sleep(1000);
          Console.Clear();
          break;
      }
    }
  }
}