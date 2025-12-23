namespace AtomConsole.src.Reactor;

class Particle
{
  public string Neutron { get; set; }
  public short NeutronsValue { get; set; } // (Value)
  public short ParticleSpeed { get; set; } // (м/с)
  public short ParticalValue { get; set; } // (Value)
  public Particle()
  {
    Neutron = "Нейтрон";
    NeutronsValue = 0;
    ParticleSpeed = 0;
    ParticalValue = 0;
  }
}
class Elements : Particle
{
  public string U235 = "Уран 235";
  public string Te135 = "Теллур 135";
  public string I135 = "Иод 135";
  public string Xe135 = "Ксенон 135";
  public string Xe136 = "Ксенон 136";
  public string Zr99 = "Цирконий 99";
  public string Cf252 = "Калифорний 252";
  public string Cs136 = "Цезий136";
  public string Ba136 = "Барий 136";
}