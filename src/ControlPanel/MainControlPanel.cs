namespace AtomConsole;

class MainControlPanel
{
  public void Reactor()
  {
    while (true)
    {
      Console.CursorVisible = false;
      Console.Clear();
      Console.WriteLine("Нажми!");
      Console.ReadKey();
      break;
    }
  }
}