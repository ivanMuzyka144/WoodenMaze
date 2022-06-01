using CodeBase.Data;
using CodeBase.StaticData;
using UnityEngine;

namespace CodeBase.Services.StaticData
{
  public class StaticDataService : IStaticDataService
  {
    private const string SpawnPointDataPath = "StaticData/SpawnPointData";

    public SpawnPoint[] TeleportInPoints => _teleportInPoints;
    public SpawnPoint[] TeleportOutPoints => _teleportOutPoints;
    public SpawnPoint[] PlayerDoorsPoints => _playerDoorsPoints;
    public SpawnPoint[] RegularDoorsPoints => _regularDoorsPoints;
    public SpawnPoint[] EnemyPoints => _enemyPoints;
    public SpawnPoint[] SeedPoints => _seedPoints;
    
    private SpawnPoint[] _teleportInPoints;
    private SpawnPoint[] _teleportOutPoints;
    private SpawnPoint[] _playerDoorsPoints;
    private SpawnPoint[] _regularDoorsPoints;
    private SpawnPoint[] _enemyPoints;
    private SpawnPoint[] _seedPoints;
    public void Load()
    {
      LoadSpawnPoints();
    }

    private void LoadSpawnPoints()
    {
      SpawnPointData spawnPointData = Resources.Load<SpawnPointData>(SpawnPointDataPath);
      _teleportInPoints = spawnPointData.TeleportInPoints;
      _teleportOutPoints = spawnPointData.TeleportOutPoints;
      _playerDoorsPoints = spawnPointData.PlayerDoorsPoints;
      _regularDoorsPoints = spawnPointData.RegularDoorsPoints;
      _enemyPoints = spawnPointData.EnemyPoints;
      _seedPoints = spawnPointData.SeedPoints;
    }
  }
}