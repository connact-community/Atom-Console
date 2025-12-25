namespace AtomConsole;

class ControlReactor
{
  public Reactor Reactor { get; set; }
  public ControlReactor()
  {
    Reactor = new Reactor();
  }
  public void LoadFuel()
  {
    if (Reactor.TechnologicalChannel < 6 && Reactor.ControlRods == 0.0f && Reactor.WearTechnologicalChannel <= 60 && Reactor.CooldownSystem == false)
    {
      DoneMessage("Загрузка ТВС...");
      Reactor.TechnologicalChannel++;
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
      ErrorMessage("Каналы заполнены, загрузка невозможна!");
    }
  }
  public void UnloadFuel()
  {
    if (Reactor.TechnologicalChannel > 0 && Reactor.ControlRods == 0.0f && Reactor.WearTechnologicalChannel <= 60 && Reactor.CooldownSystem == false)
    {
      Reactor.TechnologicalChannel--;
      DoneMessage("Разгрузка ТВС...");
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
      ErrorMessage("Каналы пустые, разгрузка невозможна!");
    }
  }
  public void LoadNeutronSource()
  {
    if (Reactor.NeutronsSource < 2 && Reactor.TechnologicalChannel == 0 && Reactor.ControlRods == 0.0f && Reactor.WearTechnologicalChannel <= 60 && Reactor.CooldownSystem == false)
    {
      Reactor.NeutronsSource++;
      DoneMessage("Загрузка нейтронных источников...");
    }
    else if (Reactor.TechnologicalChannel > 0)
    {
      ErrorMessage("Технологические каналы заполнены ТВС, загрузка нейтронных источников невозможна!");
    }
    else if (Reactor.ControlRods > 0.0f)
    {
      ErrorMessage("Стержни СУЗ подняты, разгрузка нейтронных источников невозможна!");
    }
    else if (Reactor.WearTechnologicalChannel > 60)
    {
      ErrorMessage("Износ технологических каналов, загрузка нейтронных источников невозможна!");
    }
    else if (Reactor.CooldownSystem == true)
    {
      ErrorMessage("Система расхолаживания включена, загрузка нейтронных источников невозможна!");
    }
    else
    {
      ErrorMessage("Каналы заполнены, загрузка невозможна!");
    }
  }
  public void UnloadNeutronSource()
  {
    if (Reactor.NeutronsSource > 0 && Reactor.TechnologicalChannel == 0 && Reactor.ControlRods == 0.0f && Reactor.WearTechnologicalChannel <= 60 && Reactor.CooldownSystem == false)
    {
      Reactor.NeutronsSource--;
      DoneMessage("Разгрузка нейтронных источников...");
    }
    else if (Reactor.TechnologicalChannel > 0)
    {
      ErrorMessage("Технологические каналы заполнены ТВС, разгрузка нейтронных источников невозможна!");
    }
    else if (Reactor.ControlRods > 0.0f)
    {
      ErrorMessage("Стержни СУЗ подняты, разгрузка нейтронных источников невозможна!");
    }
    else if (Reactor.WearTechnologicalChannel > 60)
    {
      ErrorMessage("Износ технологических каналов, разгрузка нейтронных источников невозможна!");
    }
    else if (Reactor.CooldownSystem == true)
    {
      ErrorMessage("Система расхолаживания включена, разгрузка нейтронных источников невозможна!");
    }
    else
    {
      ErrorMessage("Каналы пустые, разгрузка невозможна!");
    }
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
    Console.ReadKey();
    Console.Clear();
  }
}