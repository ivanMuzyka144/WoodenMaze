﻿using CodeBase.Infrastructure.Factory;
using CodeBase.Services.PersistentProgress;

namespace CodeBase.Infrastructure.States
{
  public class LoadLevelState : IPayloadedState<string>
  {
    private const string InitialPointTag = "InitialPoint";
    private const string EnemySpawnerTag = "EnemySpawner";

    private readonly GameStateMachine _stateMachine;
    private readonly SceneLoader _sceneLoader;
    private readonly IGameFactory _gameFactory;
    private readonly IPersistentProgressService _progressService;

    public LoadLevelState(GameStateMachine gameStateMachine, SceneLoader sceneLoader, 
      IGameFactory gameFactory, IPersistentProgressService progressService)
    {
      _stateMachine = gameStateMachine;
      _sceneLoader = sceneLoader;
      _gameFactory = gameFactory;
      _progressService = progressService;
    }

    public void Enter(string sceneName)
    {
      _gameFactory.Cleanup();
      _sceneLoader.Load(sceneName, OnLoaded);
    }

    public void Exit() {}

    private void OnLoaded()
    {
      InitGameWorld();

      _stateMachine.Enter<GameLoopState>();
    }

    private void InitGameWorld()
    {
      
    }
  }
}