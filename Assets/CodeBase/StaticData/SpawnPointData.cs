using CodeBase.Data;
using UnityEngine;

namespace CodeBase.StaticData
{
  [CreateAssetMenu(menuName = "Static Data/Create Spawn Point Data", fileName = "SpawnPointData")]
  public class SpawnPointData : ScriptableObject
  {
    public SpawnPoint[] TeleportInPoints;
    public SpawnPoint[] TeleportOutPoints;
    public SpawnPoint[] PlayerDoorsPoints;
    public SpawnPoint[] RegularDoorsPoints;
    public SpawnPoint[] EnemyPoints;
    public SpawnPoint[] SeedPoints;
  }
}