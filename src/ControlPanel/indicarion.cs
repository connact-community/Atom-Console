using AtomConsole.src.Reactor;
namespace AtomConsole;

class Indication
{
  public Reactor Reactor { get; set; }
  public Indication(Reactor reactor)
  {
    Reactor = reactor;
  }
  public void IndicationReactor()
  {
    if (Reactor.ControlRods == "Down")
    {
      Console.CursorVisible = false;
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("ВНИМАНИЕ: Стержни СУЗ опущены");
      Console.ResetColor();
      Thread.Sleep(3000);
      Console.Clear();
    }
    Console.Clear();
    Reactor.ControlRods = "Top";
    Reactor.TechnologicalChannel();
  }
}