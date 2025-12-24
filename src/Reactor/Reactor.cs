namespace AtomConsole;

class Reactor
{
  public float ElectricalPower { get; set; } // (МВт) 
  public float ThermalPower { get; set; } // (МВт) 
  public short TempGraphiteBlocks { get; set; } // (°C)
  public short TempWater { get; set; } // (°C)
  public short TempReactor { get; set; } // (°C)
  public short WaterPressure { get; set; } // (Atm)
  public short TempSteam { get; set; } // (°C)
  public float SteamMixturePressure { get; set; } // (Atm)
  public short WaterAmount { get; set; } // (T - Tons)
  public short SteamMixtureAmount { get; set; } // (Kg)
  public sbyte WearTechnologicalChannel { get; set; } // (%)
  public bool CooldownSystem { get; set; } // (True \ False)
  public short FuelAssemblyValue { get; set; } // (Value)
  public sbyte WearFuelAssembly { get; set; } // (%)
  public float ControlRods { get; set; } // (% & M - Meter)
  public sbyte NeutronsSource { get; set; } // (Value)
  public short TechnologicalChannel { get; set; } // (Value)
  public short ProtectionControlSystem { get; set; } // (Value)
  public short ProtectionAutomatic { get; set; } // (Value)

  public Reactor()
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