using System.Collections.Generic;
using CodeBase.Infrastructure.AssetManagement;
using CodeBase.Services.PersistentProgress;
using UnityEngine;

namespace CodeBase.Infrastructure.Factory
{
  public class GameFactory : IGameFactory
  {
    

    private readonly IAssetProvider _assets;
    private readonly IPersistentProgressService _persistentProgressService;

    public GameFactory(IAssetProvider assets, IPersistentProgressService persistentProgressService)
    {
      _assets = assets;
      _persistentProgressService = persistentProgressService;
    }

    public void Cleanup()
    {
    }

    

  }
}