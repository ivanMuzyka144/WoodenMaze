using CodeBase.Logic;
using UnityEditor;
using UnityEngine;

namespace CodeBase.Editor
{
  [CustomEditor(typeof(SafePlace))]
  public class SafePlaceEditor : UnityEditor.Editor
  {
    public override void OnInspectorGUI()
    {
      base.OnInspectorGUI();

      SafePlace safePlace = (SafePlace)target;
      float prevRadius = safePlace.InfoGizmo.Radius;
      float currRadius = safePlace.SafeAreaMesh.localScale.x;

      if (IsRadiusChanged(prevRadius, currRadius)) 
        ChangeAreaRadius(safePlace, prevRadius);

    }

    private void ChangeAreaRadius(SafePlace safePlace, float prevRadius)
    {
      safePlace.SafeAreaMesh.localScale = Vector3.one * prevRadius;
      EditorUtility.SetDirty(target);
    }

    private bool IsRadiusChanged(float prevRadius, float currRadius) => 
      !Mathf.Approximately(prevRadius, currRadius);
  }
}