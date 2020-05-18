using System;

namespace RFSolucoes.SGE.Dominio.Interfaces.DAOs
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}
