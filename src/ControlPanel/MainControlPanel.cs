namespace AtomConsole;

class MainControlPanel
{
  ControlReactor controlReactor = new();
  public Reactor Reactor { get; set; }
  public MainControlPanel()
  {
    Reactor = new Reactor();
  }
  public void ControlPanel()
  {
    controlReactor.Reactor = this.Reactor;

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
4-  БС
5 - Дизель генераторы
6 - Индикация
 ________________________________________
7 - Назад");
      Console.ResetColor();
      Console.Write("\n > ");
      string UserInput = Console.ReadLine()!;

      switch (UserInput)
      {
        case "1":
          ControlTurboGenerators();
          break;
        case "2":
          ControlReactor();
          break;
        case "3":
          ControlMainPumps();
          break;
        case "4":
          ControlDrumSeparators();
          break;
        case "5":
          ControlDieselGenerators();
          break;
        case "6":
          break;
        case "7":
          return;
      }
    }
  }
  public void ControlTurboGenerators()
  {

  }
  public void ControlReactor()
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
  8 - Назад");

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
        case "8":
          // Выход
          return;
      }
    }
  }
  public void ControlMainPumps()
  {

  }
  public void ControlDrumSeparators()
  {

  }
  public void ControlDieselGenerators()
  {

  }
}