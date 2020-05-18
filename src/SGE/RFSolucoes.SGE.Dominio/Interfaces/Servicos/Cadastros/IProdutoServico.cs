using RFSolucoes.SGE.Dominio.Entidades.Cadastros;
using RFSolucoes.SGE.Dominio.Interfaces.DAOs.Cadastros;

namespace RFSolucoes.SGE.Dominio.Interfaces.Servicos.Cadastros
{
    public interface IProdutoServico : IServicoBase<int, Produto, IProdutoRepositorio>
    {
    }
}
