using AtomConsole.src.ControlPanel;
namespace AtomConsole;

class MainControlPanel
{
  ControlReactor controlReactor = new();
  Indication indication = new();
  public void ControlPanel()
  {
    while (true)
    {
      Console.Clear();
      Console.CursorVisible = true;
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine(@"
Блочный щит управленмия

1 - Турбогенераторы
2 - Реактор
3 - ГЦН
4 - БС
5 - Дизель генераторы
6 - Индикация
 ________________________________________
0 - Назад");
      Console.ResetColor();
      Console.Write("\n > ");
      string UserInput = Console.ReadLine()!;

      switch (UserInput)
      {
        case "1":
          TurboGeneratorsMenu();
          break;
        case "2":
          ReactorMenu();
          break;
        case "3":
          MainPumpsMenu();
          break;
        case "4":
          DrumSeparatorsMenu();
          break;
        case "5":
          DieselGeneratorsMenu();
          break;
        case "6":
          indication.IndicationReactor();
          break;
        case "0":
          //Exit
          return;
      }
    }
  }
  public void TurboGeneratorsMenu()
  {

  }
  public void ReactorMenu()
  {
    while (true)
    {
      Console.Clear();
      Console.CursorVisible = true;
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine(@"
  Реактор 
  
  1 - Поднять стержни СУЗ
  2 - Отпустить стержни СУЗ
  3 - Регулировка сервоприводов СУЗ
  ________________________________________
  4 - Загрузить ТВС в ТК
  5 - Разгрузить ТВС из ТК
  6 - Загрузить нейтронные источники в ТК
  7 - Разгрузить нейтронные источники из ТК
  ________________________________________
  0 - Назад");
      Console.ResetColor();
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.WriteLine(@$"
ТВС Загружено: {Reactor.TechnologicalChannel}
Нейтронные источники загружено: {Reactor.NeutronsSource}");
      Console.ResetColor();
      Console.Write("\n > ");
      string UserInput = Console.ReadLine()!;

      switch (UserInput)
      {
        case "1":
          break;
        case "2":
          break;
        case "3":
          break;
        case "4":
          controlReactor.LoadFuel();
          break;
        case "5":
          controlReactor.UnloadFuel();
          break;
        case "6":
          controlReactor.LoadNeutronSource();
          break;
        case "7":
          controlReactor.UnloadNeutronSource();
          break;
        case "0":
          // Exit
          return;
      }
    }
  }
  public void MainPumpsMenu()
  {
    while (true)
    {
      Console.Clear();
      Console.CursorVisible = true;
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine(@"
1 - Запустить ГЦН
2 - Остановить ГЦН
0 - Назад
");
      Console.ResetColor();

      if (ControlMainPumps.StatusMainPumps == "Работает")
      { Console.ForegroundColor = ConsoleColor.Green; }
      else
      { Console.ForegroundColor = ConsoleColor.Red; }

      Console.WriteLine($"Статус ГЦН: " + ControlMainPumps.StatusMainPumps);
      Console.ResetColor();
      Console.Write("\n> ");
      string UserInput = Console.ReadLine()!;

      switch (UserInput)
      {
        case "1":
          ControlMainPumps.LaucnhMainPumps();
          break;
        case "2":
          ControlMainPumps.StopMainPumps();
          break;
        case "0":
          //Exit
          return;
      }
    }
  }
  public void DrumSeparatorsMenu()
  {

  }
  public void DieselGeneratorsMenu()
  {

  }
}