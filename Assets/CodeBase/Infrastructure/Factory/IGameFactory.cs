using System.Collections.Generic;
using CodeBase.Services;
using CodeBase.Services.PersistentProgress;

namespace CodeBase.Infrastructure.Factory
{
  public interface IGameFactory : IService
  {
    void Cleanup();
    
  }
}