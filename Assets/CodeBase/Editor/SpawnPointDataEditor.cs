using System.Linq;
using CodeBase.Data;
using CodeBase.StaticData;
using CodeBase.StaticData.Markers;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CodeBase.Editor
{
  [CustomEditor(typeof(SpawnPointData))]
  public class SpawnPointDataEditor: UnityEditor.Editor
  {
    public override void OnInspectorGUI()
    {
      base.OnInspectorGUI();

      SpawnPointData spawnPointData = (SpawnPointData)target;

      if (GUILayout.Button("Collect"))
      {
        spawnPointData.TeleportInPoints = GetSpawnPoints<TeleportInMarker>();
        spawnPointData.TeleportOutPoints = GetSpawnPoints<TeleportOutMarker>();
        spawnPointData.PlayerDoorsPoints = GetSpawnPoints<PlayerDoorMarker>();
        spawnPointData.RegularDoorsPoints = GetSpawnPoints<RegularDoorMarker>();
        spawnPointData.EnemyPoints = GetSpawnPoints<EnemyMarker>();
        spawnPointData.SeedPoints = GetSpawnPoints<SeedMarker>();
      }
      
      EditorUtility.SetDirty(target);
    }
    
    private SpawnPoint[] GetSpawnPoints<TMarker>() where TMarker : Marker
    {
      TMarker[] spawnTransform = FindObjectsOfType<TMarker>();
      return spawnTransform.Select(x => new SpawnPoint(x.transform.position, x.transform.rotation)).ToArray();;
    }
  }
}
