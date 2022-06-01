using StarterAssets;
using UnityEngine;

namespace CodeBase.Logic.PlayerLogic
{
  public class Player : MonoBehaviour
  {
    [SerializeField] private CharacterController _characterController;
    [SerializeField] private ThirdPersonController _thirdPersonController;


    public void SetNewPosition(Vector3 newPosition)
    {
      DisablePlayer();
      transform.position = newPosition;
      EnablePlayer();
    }
    private void EnablePlayer()
    {
      _characterController.enabled = true;
      _thirdPersonController.enabled = true;
    }

    private void DisablePlayer()
    {
      _thirdPersonController.enabled = false;
      _characterController.enabled = false;
    }
  }
}