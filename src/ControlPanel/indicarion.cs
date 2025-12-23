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
  }
}