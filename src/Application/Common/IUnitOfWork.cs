using GameLibrary.Application.Repositories;
using GameLibrary.Domain.Entities;

namespace GameLibrary.Application.Common;

public interface IUnitOfWork : IDisposable
{
    IGameRepository Games { get; }
    void Save();
}