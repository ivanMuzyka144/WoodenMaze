using CodeBase.Data;

namespace CodeBase.Services.StaticData
{
  public interface IStaticDataService : IService
  {
    public SpawnPoint[] TeleportInPoints { get; }
    public SpawnPoint[] TeleportOutPoints { get; }
    public SpawnPoint[] PlayerDoorsPoints{ get; }
    public SpawnPoint[] RegularDoorsPoints{ get; }
    public SpawnPoint[] EnemyPoints{ get; }
    public SpawnPoint[] SeedPoints{ get; }
    void Load();
  }
}