namespace AtomConsole;

class MainParameters
{
  public void All()
  {
    if (Reactor.ControlRods > 0.0f)
    { ErrorMessage("Стержни СУЗ подняты, загрузка невозможна!"); return; }
    if (Reactor.WearTechnologicalChannel > 60)
    { ErrorMessage("Износ технологических каналов, загрузка невозможна!"); return; }
    if (Reactor.CooldownSystem == true)
    { ErrorMessage("Система расхолаживания включена, загрузка невозможна!"); return; }
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
class ControlReactor : MainParameters
{
  public void LoadFuel()
  {
    if (Reactor.TechnologicalChannel == 6)
    { ErrorMessage("Каналы заполнены, загрузка невозможна!"); return; }
    DoneMessage("Загрузка ТВС...");
    Reactor.TechnologicalChannel++;
  }
  public void UnloadFuel()
  {
    if (Reactor.TechnologicalChannel == 0)
    { ErrorMessage("Каналы пустые, разгрузка невозможна!"); return; }
    Reactor.TechnologicalChannel--;
    DoneMessage("Разгрузка ТВС...");
  }
  public void LoadNeutronSource()
  {
    if (Reactor.TechnologicalChannel >= 1)
    { ErrorMessage("ТК заполнены ТВС, загрузка нейтронных источников невозможна!"); return; }
    if (Reactor.NeutronsSource == 2)
    { ErrorMessage("Каналы заполнены, загрузка невозможна!"); return; }
    Reactor.NeutronsSource++;
    DoneMessage("Загрузка нейтронных источников...");
  }
  public void UnloadNeutronSource()
  {
    if (Reactor.TechnologicalChannel >= 1)
    { ErrorMessage("ТК заполнены ТВС, разгрузка нейтронных источников невозможна!"); return; }
    if (Reactor.NeutronsSource == 0)
    { ErrorMessage("Каналы пустые, разгрузка невозможна!"); return; }
    Reactor.NeutronsSource--;
    DoneMessage("Разгрузка нейтронных источников...");
  }
}