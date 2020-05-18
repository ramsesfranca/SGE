using RFSolucoes.SGE.Dominio.Entidades;
using RFSolucoes.SGE.Dominio.Interfaces.DAOs;
using RFSolucoes.SGE.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace RFSolucoes.SGE.Negocio.Servicos
{
    public abstract class ServicoBase<TId, TEntidade, TRepositorioBase> : IServicoBase<TId, TEntidade, TRepositorioBase>
        where TId : IEquatable<TId>
        where TEntidade : EntidadeBase<TId>
        where TRepositorioBase : IRepositorioBase<TId, TEntidade>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly TRepositorioBase _repositorio;

        protected ServicoBase(IUnitOfWork unitOfWork, TRepositorioBase repositorio)
        {
            this._unitOfWork = unitOfWork;
            this._repositorio = repositorio;
        }

        public virtual void Inserir(TEntidade entidade)
        {
            if (entidade == null)
            {
                throw new ArgumentNullException(nameof(entidade));
            }

            this._repositorio.Inserir(entidade);
            this._unitOfWork.Commit();
        }

        public virtual void Inserir(List<TEntidade> entidades)
        {
            throw new NotImplementedException();
        }

        public virtual void Alterar(TEntidade entidade)
        {
            throw new NotImplementedException();
        }

        public virtual void Alterar(List<TEntidade> entidades)
        {
            throw new NotImplementedException();
        }

        public virtual void Deletar(TEntidade entidade)
        {
            throw new NotImplementedException();
        }

        public virtual void Deletar(List<TEntidade> entidades)
        {
            throw new NotImplementedException();
        }

        public virtual TEntidade SelecionarPorId(TId id, params Expression<Func<TEntidade, object>>[] incluir)
        {
            throw new NotImplementedException();
        }

        public virtual List<TEntidade> SelecionarTodos(params Expression<Func<TEntidade, object>>[] incluir)
        {
            throw new NotImplementedException();
        }

        public virtual bool Existe(Expression<Func<TEntidade, bool>> predicado)
        {
            throw new NotImplementedException();
        }
    }
}
