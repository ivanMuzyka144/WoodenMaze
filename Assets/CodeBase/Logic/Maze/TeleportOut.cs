using UnityEngine;

namespace CodeBase.Logic.Maze
{
  public class TeleportOut : MonoBehaviour
  {
    [SerializeField] private float _yOffset;
    
    public Vector3 GetPositionForPlayer() => 
      transform.position + new Vector3(0, _yOffset, 0);
  }
}