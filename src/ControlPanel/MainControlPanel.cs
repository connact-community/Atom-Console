namespace AtomConsole;

class MainControlPanel
{
  public Reactor Reactor { get; set; }
  public MainControlPanel()
  {
    Reactor = new Reactor();
  }
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
4-  БС
5 - Дизель генераторы
 ________________________________________
6 - Назад");
      Console.ResetColor();
      Console.Write("\n > ");
      string UserInput = Console.ReadLine()!;

      switch (UserInput)
      {
        case "1":
          TurboGenerators();
          break;
        case "2":
          Reactor1();
          break;
        case "3":
          MainPumps();
          break;
        case "4":
          DrumSeparators();
          break;
        case "5":
          DieselGenerators();
          break;
        case "6":
          return;
      }
    }
  }
  public void TurboGenerators()
  {

  }
  public void Reactor1() // ПРИДУМАТЬ ЧТО НИБУДЬ ????????????????????????????????????????????????????????
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
ТВС Загружено: {Reactor.TechnologicalChannel}");
      Console.ResetColor();
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
          if (Reactor.TechnologicalChannel < 6 && Reactor.ControlRods == 0.0f && Reactor.WearTechnologicalChannel <= 60 && Reactor.CooldownSystem == false)
          {
            Reactor.TechnologicalChannel++;
            DoneMessage("Загрузка");
          }
          else if (Reactor.ControlRods > 0.0f)
          {
            ErrorMessage("Стержни СУЗ подняты, загрузка невозможна!");
          }
          else if (Reactor.WearTechnologicalChannel > 60)
          {
            ErrorMessage("Износ технологических каналов, загрузка невозможна!");
          }
          else if (Reactor.CooldownSystem == true)
          {
            ErrorMessage("Система расхолаживания включена, загрузка невозможна!");
          }
          else
          {
            ErrorMessage("Каналы не пусты, загрузка невозможна!");
          }
          break;
        case "5":
          if (Reactor.TechnologicalChannel > 0 && Reactor.ControlRods == 0.0f && Reactor.WearTechnologicalChannel < 60 && Reactor.CooldownSystem == false)
          {
            Reactor.TechnologicalChannel--;
            DoneMessage("Разгрузка");
          }
          else if (Reactor.ControlRods > 0.0f)
          {
            ErrorMessage("Стержни СУЗ подняты, разгрузка невозможна!");
          }
          else if (Reactor.WearTechnologicalChannel > 60)
          {
            ErrorMessage("Износ технологических каналов, разгрузка невозможна!");
          }
          else if (Reactor.CooldownSystem == true)
          {
            ErrorMessage("Система расхолаживания включена, разгрузка невозможна!");
          }
          else
          {
            ErrorMessage("Каналы пустые, разгрузка невозможна");
          }
          break;
        case "6":
          break;
        case "7":
          break;
        case "8":
          // Выход
          return;
      }
    }
  }
  public void MainPumps()
  {

  }
  public void DrumSeparators()
  {

  }
  public void DieselGenerators()
  {

  }
  public void DoneMessage(string DoneMessage)
  {
    Console.Clear();
    Console.CursorVisible = false;
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(DoneMessage);
    Console.ResetColor();
    Thread.Sleep(1000);
    Console.Clear();
  }
  public void ErrorMessage(string ErrorMessage)
  {
    Console.Clear();
    Console.CursorVisible = false;
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(ErrorMessage);
    Console.ResetColor();
    Thread.Sleep(1000);
    Console.Clear();
  }
}