namespace AtomConsole.src.Reactor;

class Reactor
{
  public decimal PowerReactor;
  public int TempReactor;
  public int WaterPressure;
  public int SteamMixturePressure;
  public int WaterAmount;
  public int SteamMixtureAmount;
  public int WearTechnologicalChannel;
  public bool CooldownSystem;
  public int FuelAssemblyValue;
  public int WearFuelAssembly;
  public string ControlRods;

  public Reactor()
  {
    PowerReactor = 0.0m;
    TempReactor = 0;
    WaterPressure = 0;
    SteamMixturePressure = 0;
    WaterAmount = 0;
    SteamMixtureAmount = 0;
    WearTechnologicalChannel = 0;
    CooldownSystem = false;
    FuelAssemblyValue = 0;
    WearFuelAssembly = 0;
    ControlRods = "Down";
  }
  public void TechnologicalChannel()
  {
    // Logic power reactor.
    if (ControlRods == "Top")
    {
      while (true)
      {
        Console.CursorTop = 0;
        PowerReactor += 0.50m;
        Thread.Sleep(700);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(PowerReactor);
        Console.ResetColor();

        if (PowerReactor == 10.00m)
        {
          break;
        }
      }
    }
  }
}