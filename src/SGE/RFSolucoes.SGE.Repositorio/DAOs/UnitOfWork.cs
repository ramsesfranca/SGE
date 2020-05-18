using RFSolucoes.SGE.Dominio.Interfaces.DAOs;
using System;

namespace RFSolucoes.SGE.Repositorio.DAOs
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SGEContext _contexto;

        public UnitOfWork(SGEContext contexto)
        {
            this._contexto = contexto ?? throw new ArgumentNullException(nameof(contexto));
        }

        public void Commit()
        {
            this._contexto.SaveChanges();
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    this._contexto.Dispose();
                }

                this._disposed = true;
            }
        }

        ~UnitOfWork()
        {
            this.Dispose(false);
        }

        private bool _disposed;
    }
}
