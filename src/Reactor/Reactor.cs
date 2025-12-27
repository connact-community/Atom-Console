namespace AtomConsole;

static class Reactor
{
  static public float ElectricalPower { get; set; } // (МВт) 
  static public float ThermalPower { get; set; } // (МВт) 
  static public short TempGraphiteBlocks { get; set; } // (°C)
  static public short TempWater { get; set; } // (°C)
  static public short TempReactor { get; set; } // (°C)
  static public short WaterPressure { get; set; } // (Atm)
  static public short TempSteam { get; set; } // (°C)
  static public float SteamMixturePressure { get; set; } // (Atm)
  static public short WaterAmount { get; set; } // (T - Tons)
  static public short SteamMixtureAmount { get; set; } // (Kg)
  static public sbyte WearTechnologicalChannel { get; set; } // (%)
  static public bool CooldownSystem { get; set; } // (True \ False)
  static public short FuelAssemblyValue { get; set; } // (Value)
  static public sbyte WearFuelAssembly { get; set; } // (%)
  static public float ControlRods { get; set; } // (% & M - Meter)
  static public sbyte NeutronsSource { get; set; } // (Value)
  static public short TechnologicalChannel { get; set; } // (Value)
  static public short ProtectionControlSystem { get; set; } // (Value)
  static public short ProtectionAutomatic { get; set; } // (Value)

  static Reactor()
  {
    ElectricalPower = 0.0f;
    ThermalPower = 0.0f;
    TempGraphiteBlocks = 0;
    TempWater = 0;
    TempReactor = 0;
    WaterPressure = 0;
    TempSteam = 0;
    SteamMixturePressure = 0.0f;
    WaterAmount = 0;
    SteamMixtureAmount = 0;
    WearTechnologicalChannel = 0; // Dependence on Graphite temp blocks
    CooldownSystem = false;
    FuelAssemblyValue = 0;
    WearFuelAssembly = 0;
    ControlRods = 0.0f;
    NeutronsSource = 0;
    TechnologicalChannel = 0;
    ProtectionControlSystem = 12;
    ProtectionAutomatic = 16;
  }
}