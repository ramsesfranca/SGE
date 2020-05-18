using RFSolucoes.SGE.Dominio.Entidades.Cadastros;
using RFSolucoes.SGE.Dominio.Interfaces.DAOs;
using RFSolucoes.SGE.Dominio.Interfaces.DAOs.Cadastros;
using RFSolucoes.SGE.Dominio.Interfaces.Servicos.Cadastros;

namespace RFSolucoes.SGE.Negocio.Servicos.Cadastros
{
    public class ProdutoServico : ServicoBase<int, Produto, IProdutoRepositorio>, IProdutoServico
    {
        public ProdutoServico(IUnitOfWork unitOfWork, IProdutoRepositorio repositorio)
            : base(unitOfWork, repositorio)
        {
        }
    }
}
