using Helpers;
using UnityEngine;

namespace CodeBase.Logic
{
  [RequireComponent(typeof(InfoGizmo))]
  public class SafePlace : MonoBehaviour
  {
    [SerializeField] private InfoGizmo _infoGizmo;
    [SerializeField] private Transform _safeAreaMesh;

    public InfoGizmo InfoGizmo => _infoGizmo;
    public Transform SafeAreaMesh => _safeAreaMesh;
  }
}
