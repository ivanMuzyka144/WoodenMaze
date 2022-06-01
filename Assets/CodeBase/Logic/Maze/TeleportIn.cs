using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using CodeBase.Data;
using CodeBase.Logic.PlayerLogic;
using UnityEngine;

namespace CodeBase.Logic.Maze
{
  public class TeleportIn : MonoBehaviour
  {
    [SerializeField] private TriggerObserver _triggerObserver;

    [Space(10)] [SerializeField] private Player player;
    [SerializeField] private TeleportOut TeleportOut;
    private List<TeleportOut> _outTeleports;
    private float _rebotTime = 0.1f;
    private bool _canHandle;

    private void Start()
    {
      _triggerObserver.TriggerEnter += HandlePlayerIn;
      _canHandle = true;
    }

    public void Construct(TeleportOut[] outTeleports)
    {
      _outTeleports = outTeleports.ToList();
      _triggerObserver.TriggerEnter += HandlePlayerIn;
      _canHandle = true;
    }

    private void HandlePlayerIn()
    {
      if (_canHandle)
      {
        TeleportatePlayer();
        StartCoroutine(CO_RebootTeleport());
      }
    }

    private void TeleportatePlayer()
    {
      //TeleportOut randomTeleport = _outTeleports.RandomItem();
      Vector3 spawnPosition = TeleportOut.GetPositionForPlayer();
      player.SetNewPosition(spawnPosition);
    }

    private IEnumerator CO_RebootTeleport()
    {
      _canHandle = false;
      yield return new WaitForSeconds(_rebotTime);
      _canHandle = true;
    }
  }
}