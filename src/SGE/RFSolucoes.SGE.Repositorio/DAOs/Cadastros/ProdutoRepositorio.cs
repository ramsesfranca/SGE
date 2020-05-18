using RFSolucoes.SGE.Dominio.Entidades.Cadastros;
using RFSolucoes.SGE.Dominio.Interfaces.DAOs.Cadastros;

namespace RFSolucoes.SGE.Repositorio.DAOs.Cadastros
{
    public class ProdutoRepositorio : RepositorioBase<int, Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(SGEContext contexto)
            : base(contexto)
        {
        }
    }
}
