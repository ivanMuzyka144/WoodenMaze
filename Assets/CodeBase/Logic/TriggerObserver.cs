using System;
using UnityEngine;

namespace CodeBase.Logic
{
  public class TriggerObserver : MonoBehaviour
  {
    public Action TriggerEnter;
    public Action TriggerExit;

    private void OnTriggerEnter(Collider other) => 
      TriggerEnter?.Invoke();

    private void OnTriggerExit(Collider other) => 
      TriggerExit?.Invoke();
  }
}