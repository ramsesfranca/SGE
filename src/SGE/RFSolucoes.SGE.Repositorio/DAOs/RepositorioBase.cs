using Microsoft.EntityFrameworkCore;
using RFSolucoes.SGE.Dominio.Entidades;
using RFSolucoes.SGE.Dominio.Interfaces.DAOs;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace RFSolucoes.SGE.Repositorio.DAOs
{
    public abstract class RepositorioBase<TId, TEntidade> : IRepositorioBase<TId, TEntidade>
        where TId : IEquatable<TId>
        where TEntidade : EntidadeBase<TId>
    {
        protected readonly SGEContext Contexto;
        protected DbSet<TEntidade> Entidade { get; }

        protected RepositorioBase(SGEContext contexto)
        {
            this.Contexto = contexto ?? throw new ArgumentNullException(nameof(contexto));
            this.Entidade = contexto.Set<TEntidade>();
        }

        public virtual void Inserir(TEntidade entidade)
        {
            this.Entidade.Add(entidade);
        }

        public virtual void Alterar(TEntidade entidade)
        {
            throw new NotImplementedException();
        }

        public virtual void Deletar(TEntidade entidade)
        {
            throw new NotImplementedException();
        }

        public virtual IQueryable<TEntidade> SelecionarPorId(TId id, params Expression<Func<TEntidade, object>>[] incluir)
        {
            throw new NotImplementedException();
        }

        public virtual IQueryable<TEntidade> SelecionarTodos(params Expression<Func<TEntidade, object>>[] incluir)
        {
            throw new NotImplementedException();
        }

        public virtual IQueryable<TEntidade> SelecionarPor(Expression<Func<TEntidade, bool>> predicado, params Expression<Func<TEntidade, object>>[] incluir)
        {
            throw new NotImplementedException();
        }

        public virtual Expression<Func<TEntidade, bool>> Filtro(TEntidade entidade)
        {
            throw new NotImplementedException();
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
                    this.Contexto.Dispose();
                }

                this._disposed = true;
            }
        }

        ~RepositorioBase()
        {
            this.Dispose(false);
        }

        private bool _disposed;
    }
}
