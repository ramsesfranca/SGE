using RFSolucoes.SGE.Dominio.Entidades;
using RFSolucoes.SGE.Dominio.Interfaces.DAOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace RFSolucoes.SGE.Dominio.Interfaces.Servicos
{
    public interface IServicoBase<in TId, TEntidade, TRepositorioBase>
        where TId : IEquatable<TId>
        where TEntidade : EntidadeBase<TId>
        where TRepositorioBase : IRepositorioBase<TId, TEntidade>
    {
        void Inserir(TEntidade entidade);
        void Inserir(List<TEntidade> entidades);
        void Alterar(TEntidade entidade);
        void Alterar(List<TEntidade> entidades);
        void Deletar(TEntidade entidade);
        void Deletar(List<TEntidade> entidades);
        TEntidade SelecionarPorId(TId id, params Expression<Func<TEntidade, object>>[] incluir);
        List<TEntidade> SelecionarTodos(params Expression<Func<TEntidade, object>>[] incluir);
        bool Existe(Expression<Func<TEntidade, bool>> predicado);
    }
}
