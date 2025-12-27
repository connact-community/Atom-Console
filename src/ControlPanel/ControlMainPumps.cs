namespace AtomConsole.src.ControlPanel;

static class ControlMainPumps
{
  static public string StatusMainPumps;
  static public short TempWaterPump; // (°C)
  static public short WaterPressurePump; // (Atm)
  static public short WaterAmountPump; // (T - Tons)
  static ControlMainPumps()
  {
    StatusMainPumps = "Остановлено";
    TempWaterPump = 0;
    WaterPressurePump = 0;
    WaterAmountPump = 0;
  }
  public static void LaucnhMainPumps()
  {

  }
  public static void StopMainPumps()
  {

  }
  public static void BreakDownSystemMainPumps()
  {

  }
}