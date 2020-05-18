using RFSolucoes.SGE.Dominio.Entidades;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace RFSolucoes.SGE.Dominio.Interfaces.DAOs
{
    public interface IRepositorioBase<in TId, TEntidade> : IDisposable
        where TId : IEquatable<TId>
        where TEntidade : EntidadeBase<TId>
    {
        void Inserir(TEntidade entidade);
        void Alterar(TEntidade entidade);
        void Deletar(TEntidade entidade);
        IQueryable<TEntidade> SelecionarPorId(TId id, params Expression<Func<TEntidade, object>>[] incluir);
        IQueryable<TEntidade> SelecionarTodos(params Expression<Func<TEntidade, object>>[] incluir);
        IQueryable<TEntidade> SelecionarPor(Expression<Func<TEntidade, bool>> predicado, params Expression<Func<TEntidade, object>>[] incluir);
        Expression<Func<TEntidade, bool>> Filtro(TEntidade entidade);
    }
}
